using Dev69Restaurant.Common;
using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.DTO.Entities;
using Dev69Restaurant.GUI.Food;
using Dev69Restaurant.GUI.Manager;
using Dev69Restaurant.GUI.TableFood;
using Dev69Restaurant.Infrastructure.Components.UserControls;
using Dev69Restaurant.Infrastructure.Settings;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.Home
{
    public partial class HomeForm : Form
    {
        #region Fields

        private DTO.Entities.User _currentUser;
        private BillService _billService;
        private string _roleName;
        private UserService _userService;
        private int idTable = -1;
        private bool isCollapse = false;
        private Guna2GradientButton _currentButton;
        public static bool isDefaulTheme = true;

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
            LoadData();
        }

        #region Events

        private void HomeForm_Load(object sender, EventArgs e)
        {
            CheckUser();
        }

        private void btnToogleMenu_Click(object sender, EventArgs e)
        {
            ShowHideLeftBar();
        }

        private Form activeForm = null;

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, BaseIcon.HOME_ACTIVE);
        }

        private void HideFormActive()
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
        }

        private void btnTableFood_Click(object sender, EventArgs e)
        {
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
                CheckOut();
                MessageBox.Show("Thanh toán thành công!", "Đã Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                idTable = -1;
            }
            catch
            {
                MessageBox.Show("Thanh toán không thành công!", "Thanh toán thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
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
            if(idTable == -1)
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
            ActivateButton(sender, BaseIcon.USER_GROUP_ACTIVE);
            ManagerForm managerForm = new ManagerForm();
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void tgbtnSwitchTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (!isDefaulTheme)
            {
                this.BackColor = BaseColor.BACK_COLOR_DARK;
                pnLeft.BackColor = BaseColor.PANNEL_DARK;
                pnFeature.BackColor = BaseColor.PANNEL_DARK;
                pnRight.BackColor = BaseColor.PANNEL_DARK;
                pnMain.BackColor = BaseColor.PANNEL_DARK;

                foreach (Control button in pnLeft.Controls)
                {
                    if (button is Guna2GradientButton)
                    {
                        (button as Guna2GradientButton).BackColor = BaseColor.BUTTON_DARK;
                        (button as Guna2GradientButton).ForeColor = BaseColor.FORE_COLOR_DARK;
                        (button as Guna2GradientButton).FillColor = BaseColor.BUTTON_DARK;
                        (button as Guna2GradientButton).FillColor2 = BaseColor.BUTTON_DARK;
                    }
                }

                foreach (Control button in pnTop.Controls)
                {
                    if (button is GunaControlBox)
                    {
                        (button as GunaControlBox).BackColor = BaseColor.BUTTON_DARK;
                        (button as GunaControlBox).IconColor = BaseColor.FORE_COLOR_DARK;
                    }
                }

                btnHome.CustomImages.Image = Image.FromFile(BaseIcon.HOME_DARK);
                btnTableFood.CustomImages.Image = Image.FromFile(BaseIcon.TABLE_FOOD_DARK);
                btnFood.CustomImages.Image = Image.FromFile(BaseIcon.FOOD_DARK);
                btnStatistic.CustomImages.Image = Image.FromFile(BaseIcon.STATISTIC_DARK);
                btnManage.CustomImages.Image = Image.FromFile(BaseIcon.USER_GROUP_DARK);
                btnSetting.CustomImages.Image = Image.FromFile(BaseIcon.SETTING_DARK);
                btnAbout.CustomImages.Image = Image.FromFile(BaseIcon.ABOUT_DARK);
                btnToogleMenu.Image = Image.FromFile(BaseIcon.TOOGLE_MENU_DARK);
            }
            else
            {
                this.BackColor = BaseColor.BACK_COLOR_LIGHT;
                pnLeft.BackColor = BaseColor.PANNEL_LIGHT;
                pnFeature.BackColor = BaseColor.PANNEL_LIGHT;
                pnRight.BackColor = BaseColor.PANNEL_LIGHT;
                pnMain.BackColor = BaseColor.PANNEL_LIGHT;

                foreach (Control button in pnTop.Controls)
                {
                    if (button is GunaControlBox)
                    {
                        (button as GunaControlBox).BackColor = BaseColor.BUTTON_LIGHT;
                        (button as GunaControlBox).IconColor = BaseColor.FORE_COLOR_LIGHT;
                    }
                }

                foreach (Control button in pnLeft.Controls)
                {
                    if (button is Guna2GradientButton)
                    {
                        (button as Guna2GradientButton).BackColor = BaseColor.BUTTON_LIGHT;
                        (button as Guna2GradientButton).ForeColor = BaseColor.FORE_COLOR_LIGHT;
                        (button as Guna2GradientButton).FillColor = BaseColor.BUTTON_LIGHT;
                        (button as Guna2GradientButton).FillColor2 = BaseColor.BUTTON_LIGHT;
                    }
                }

                btnHome.CustomImages.Image = Image.FromFile(BaseIcon.HOME);
                btnTableFood.CustomImages.Image = Image.FromFile(BaseIcon.TABLE_FOOD);
                btnFood.CustomImages.Image = Image.FromFile(BaseIcon.FOOD);
                btnStatistic.CustomImages.Image = Image.FromFile(BaseIcon.STATISTIC);
                btnManage.CustomImages.Image = Image.FromFile(BaseIcon.USER_GROUP);
                btnSetting.CustomImages.Image = Image.FromFile(BaseIcon.SETTING);
                btnAbout.CustomImages.Image = Image.FromFile(BaseIcon.ABOUT);
                btnToogleMenu.Image = Image.FromFile(BaseIcon.TOOGLE_MENU);
            }
        }

        #endregion Events

        #region methods

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
            bill.CustomerCategoryId = 1;
            bill.VATId = 1;
            bill.PaymentMethod = "Tiền mặt";
            bill.TotalPrice = decimal.Parse(txtTotalPrice.Text);
            _billService.Add(bill);

            foreach (UCItemOfBill item in pnBillDetail.Controls)
            {
                BillDetail billDetail = new BillDetail();
                billDetail.BillId = bill.Id;
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
            double sum = 0;
            foreach (UCItemOfBill item in pnBillDetail.Controls)
            {
                sum += item.totalPrice;
            }
            txtTotalPrice.Text = sum + "";
        }

        private void LoadData()
        {
            LoadInfoUser();
        }

        private void LoadInfoUser()
        {
            lblDisplayName.Text = _currentUser.DisplayName;
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
                pnLeft.Width = 80;
                gnTransition.ShowSync(pnLeft);
                isCollapse = true;
            }
            else
            {
                pnLeft.Visible = false;
                pnLeft.Width = 320 - 80;
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

        #endregion methods
    }
}