using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.DTO.Entities;
using Dev69Restaurant.GUI.Food;
using Dev69Restaurant.GUI.InfoUser;
using Dev69Restaurant.GUI.Manager;
using Dev69Restaurant.GUI.TableFood;
using Dev69Restaurant.Infrastructure.Components.UserControls;
using Dev69Restaurant.Infrastructure.Settings;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.Home
{
    public partial class HomeForm : Form
    {
        #region Fields

        private DTO.Entities.User _currentUser;
        private BillService _billService;
        private FoodService _foodService;
        private DiscountService _discountService;
        private string _roleName;
        private UserService _userService;
        private int idTable = -1;
        private bool isCollapse = false;
        private Guna2GradientButton _currentButton;
        public static bool isDefaulTheme = true;
        double sum;
        double discountPrice;
        private Form activeForm = null;

        #endregion Fields

        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(DTO.Entities.User user, string roleShortName)
        {
            InitializeComponent();
            _currentUser = user;
            _roleName = roleShortName;
            _userService = new UserService();
            _billService = new BillService();
            _foodService = new FoodService();
            _discountService = new DiscountService();
            LoadFoodCategory();
            LoadData();
        }

        #region Events

        private void HomeForm_Load(object sender, EventArgs e)
        {
            CheckUser();
        }

        private void LoadFoodCategory()
        {
            List<FoodCategory> foodCategories = _foodService.GetAllCategory();
            foodCategories.Add(new FoodCategory { Name = "Tất cả" });
            cbCategoryFood.DataSource = foodCategories;
            cbCategoryFood.DisplayMember = "Name";
            cbCategoryFood.ValueMember = "Id";

            cbCategoryFood.SelectedItem = null;
        }

        private void btnToogleMenu_Click(object sender, EventArgs e)
        {
            ShowHideLeftBar();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            cbCategoryFood.Visible = false;
            lblFoodCategory.Visible = false;
            ActivateButton(sender, BaseIcon.HOME_ACTIVE);
        }

        private void btnTableFood_Click(object sender, EventArgs e)
        {
            cbCategoryFood.Visible = false;
            lblFoodCategory.Visible = false;
            HideFormActive();
            ActivateButton(sender, BaseIcon.TABLE_FOOD_ACTIVE);
            TableFoodForm tableFood = new TableFoodForm();

            tableFood.selectTableFoodDelegate += TableFood_selectTableFoodDelegate;
            activeForm = tableFood;
            tableFood.TopLevel = false;
            tableFood.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            tableFood.Dock = DockStyle.Fill;
            pnMain.Controls.Add(tableFood);
            tableFood.Show();
        }

        private void TableFood_selectTableFoodDelegate(object o)
        {
            string[] infoTable = o as string[];
            idTable = int.Parse(infoTable[0]);
            lblDetailTableName.Text = infoTable[2];
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnBillDetail.Controls.Count < 1)
                {
                    MessageBox.Show("Hóa đơn trống, vui lòng chọn món.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    CheckOut();
                }
            }
            catch
            {
                MessageBox.Show("Thanh toán không thành công!", "Thanh toán thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            cbCategoryFood.Visible = true;
            lblFoodCategory.Visible = true;
            HideFormActive();
            ActivateButton(sender, BaseIcon.FOOD_ACTIVE);
            FoodForm food = new FoodForm();
            food.selectFoodDelegate += Food_selectFoodDelegate;
            activeForm = food;
            food.TopLevel = false;
            food.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            food.Dock = DockStyle.Fill;
            pnMain.Controls.Add(food);
            food.Show();
        }

        private void Food_selectFoodDelegate(object obj)
        {
            if (idTable == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi chọn món!", "Không thể chọn món", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string[] food = obj as string[];
                string foodId = food[0];
                string foodPrice = food[1];
                string foodName = food[2];

                if (pnBillDetail.Controls.Count > 0)
                {
                    if (CheckFoodExist(int.Parse(foodId)) == -1)
                    {
                        findItemOfBill(foodId).nmrQuantity_ValueChanged(1 + "");
                    }
                    else
                    {
                        CreateNewItemOfBill(foodId, foodPrice, foodName);
                    }
                }
                else
                {
                    CreateNewItemOfBill(foodId, foodPrice, foodName);
                }
                LoadTotalPrice();
            }
        }

        private void UCItemOfBill_updateQuantityFoodDelegate()
        {
            LoadTotalPrice();
        }

        private void UCItemOfBill_deleteFoodDelegate(object obj)
        {
            pnBillDetail.Controls.Remove((UCItemOfBill)obj);
            LoadTotalPrice();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, BaseIcon.STATISTIC_ACTIVE);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, BaseIcon.SETTING_ACTIVE);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, BaseIcon.ABOUT_ACTIVE);
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            cbCategoryFood.Visible = false;
            lblFoodCategory.Visible = false;

            ActivateButton(sender, BaseIcon.USER_GROUP_ACTIVE);
            ManagerForm managerForm = new ManagerForm();
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            InfoUserForm infoUserForm = new InfoUserForm(_currentUser);
            infoUserForm.StartPosition = FormStartPosition.CenterScreen;
            infoUserForm.ShowDialog();
        }

        private void cbCategoryFood_SelectedValueChanged(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();

                HideFormActive();
                //ActivateButton(sender, BaseIcon.FOOD_ACTIVE);

                string keyword = cbCategoryFood.SelectedValue.ToString();
                if (keyword == 0 + "")
                {
                    keyword = "";
                }
                FoodForm food = new FoodForm(keyword);
                food.selectFoodDelegate += Food_selectFoodDelegate;
                activeForm = food;
                food.TopLevel = false;
                food.AutoScroll = true;
                //childForm.FormBorderStyle = FormBorderStyle.None;
                food.Dock = DockStyle.Fill;
                pnMain.Controls.Add(food);
                food.Show();
            }

        }

        #endregion Events

        #region methods
        private void ResetBill()
        {
            pnBillDetail.Controls.Clear();
            lblDetailTableName.Text = "Chưa chọn bàn!";
            txtTotalPrice.Text = "";
        }

        private void HideFormActive()
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
        }
        private void CreateNewItemOfBill(string foodId, string foodPrice, string foodName)
        {
            UCItemOfBill uCItemOfBill = new UCItemOfBill(foodId, foodPrice, foodName);
            uCItemOfBill.deleteFoodDelegate += UCItemOfBill_deleteFoodDelegate;
            uCItemOfBill.updateQuantityFoodDelegate += UCItemOfBill_updateQuantityFoodDelegate;
            pnBillDetail.Controls.Add(uCItemOfBill);
        }

        private void CheckOut()
        {
            Bill bill = new Bill();
            bill.TableId = idTable;
            bill.VATId = 1;
            bill.PaymentMethod = "Tiền mặt";
            bill.CreatedDate = DateTime.Now;
            bill.CreatedBy = _currentUser.Username;

            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                if (CheckDiscountExist() == 1)
                {
                    var discount = _discountService.GetByCode(txtDiscount.Text);
                    double condition = double.Parse(discount.ConditionPrice.ToString());

                    if (ValidateDiscount(condition)==1)
                    {
                        bill.DiscountCode = txtDiscount.Text;
                        double discountPercent = double.Parse(discount.DiscountPercent.ToString());
                        discountPrice = sum * discountPercent / 100;
                        double totalPrice = sum - discountPrice;
                        bill.Discount = decimal.Parse(discountPrice.ToString());
                        bill.TotalPrice = decimal.Parse(totalPrice.ToString());
                        _billService.Add(bill);
                        AddBillDetail(bill.Id);
                        MessageBox.Show("Thanh toán thành công!", "Đã Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        idTable = -1;
                        ResetBill();
                    }
                    else
                    {
                        MessageBox.Show("Mã giảm giá không hợp lệ!", "Thanh toán thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mã giảm giá không tồn tại!", "Thanh toán thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                bill.TotalPrice = decimal.Parse(sum.ToString());
                _billService.Add(bill);
                AddBillDetail(bill.Id);
                MessageBox.Show("Thanh toán thành công!", "Đã Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                idTable = -1;
                ResetBill();
            }
        }

        private void AddBillDetail(int idBill)
        {
            foreach (UCItemOfBill item in pnBillDetail.Controls)
            {
                BillDetail billDetail = new BillDetail();
                billDetail.BillId = idBill;
                billDetail.FoodId = item.idFood;
                billDetail.Quantity = item.quantity;
                billDetail.DateCheckin = DateTime.Now;
                billDetail.DateCheckout = DateTime.Now;
                _billService.Add(billDetail);
            }
        }

        private int CheckFoodExist(int foodId)
        {
            foreach (UCItemOfBill item in pnBillDetail.Controls)
            {
                if (item.idFood == foodId)
                {
                    return -1;
                }
            }
            return 1;
        }

        private UCItemOfBill findItemOfBill(string id)
        {
            UCItemOfBill uCItemOfBill = new UCItemOfBill();
            foreach (UCItemOfBill item in pnBillDetail.Controls)
            {
                if (item.idFood == int.Parse(id))
                {
                    return uCItemOfBill = item;
                }
            }
            return uCItemOfBill;
        }

        private void LoadTotalPrice()
        {
            sum = 0;
            foreach (UCItemOfBill item in pnBillDetail.Controls)
            {
                sum += item.totalPrice;
            }

            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            txtTotalPrice.Text = String.Format(info, "{0:c}", sum);
        }

        private void LoadData()
        {
            LoadInfoUser();
        }

        private void LoadInfoUser()
        {
            lblDisplayName.Text = _currentUser.DisplayName;
            try
            {
                picAvatarUser.Image = Image.FromFile(_currentUser.Avatar);
            }
            catch
            {
                picAvatarUser.Image = Image.FromFile(BaseIcon.USER);
            }
        }

        private void CheckUser()
        {
            if (_roleName != "admin")
            {
                btnManage.Enabled = false;
                btnManage.Visible = false;
            }
            else
            {
                btnManage.Enabled = true;
                btnManage.Visible = true;
            }
        }

        private void ShowHideLeftBar()
        {
            if (!isCollapse)
            {
                pnLeft.Visible = false;
                pnLeft.Width = 76;
                gnTransition.ShowSync(pnLeft);
                isCollapse = true;
            }
            else
            {
                pnLeft.Visible = false;
                pnLeft.Width = 320 - 76;
                gnTransition.ShowSync(pnLeft);
                isCollapse = false;
            }
        }

        private void ActivateButton(object sender, string iconActive)
        {
            if (sender != null)
            {
                DisableButton();

                _currentButton = (Guna2GradientButton)sender;

                _currentButton.CustomImages.CheckedImage = _currentButton.CustomImages.Image;

                _currentButton.FillColor = BaseColor.PRESS_COLOR_PRIMARY_ACTIVE;
                _currentButton.FillColor2 = BaseColor.PRESS_COLOR_PRIMARY_ACTIVE;
                _currentButton.ForeColor = BaseColor.FORE_COLOR_LIGHT_ACTIVE;
                _currentButton.CustomImages.Image = Image.FromFile(iconActive);
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnLeft.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2GradientButton))
                {
                    _currentButton = (Guna2GradientButton)previousBtn;

                    _currentButton.FillColor = BaseColor.BUTTON_LIGHT;
                    _currentButton.FillColor2 = BaseColor.BUTTON_LIGHT;
                    _currentButton.ForeColor = BaseColor.FORE_COLOR_LIGHT;
                    _currentButton.CustomImages.Image = _currentButton.CustomImages.CheckedImage;
                }
            }
        }

        private int CheckDiscountExist()
        {
            var discount = _discountService.GetByCode(txtDiscount.Text);
            if(discount != null)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private int ValidateDiscount(double condition)
        {
            //var discount = _discountService.GetByCode(txtDiscount.Text);
            //double conditionPrice = double.Parse(discount.ConditionPrice.ToString());

            if (sum >= condition)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        #endregion methods
    }
}