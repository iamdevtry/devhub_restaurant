# Restaurant
## Technologies
- Windows Form Application .NET Framwork 4.5
- Entity Framework
- Guna UI Framework
## Project structure

--|DAL (Data Access Layer)
--|--|Infrastructure (Contains base files that interact with the DB)
--|--|Repositories
--|--|Services (Business handling)

--|DTO (Data Transfer Object)
--|--|Abstract (Contains shared attributes)
--|--|Entities (Contains Entities)

--|GUI (Graphical User Interface)

--|Infrastructure (Contains core application components and settings)
--|--|Components
--|--|Setting

--|Migrations (Contains changes when updating the database)
--|Resources (Contains the application's resources)

## How to use CRUD ?
- Create new file in --DAL--Services
-- Ex: DiscountService.cs
- Declare 2 private variables:         private IDiscountRepository _discountRepository;
                                       private IUnitOfWork _unitOfWork;
- Config Constructor method:
                                       public DiscountService()
                                       {
                                            var dbFactory = new DbFactory();
                                            _discountRepository = new DiscountRepository(dbFactory);
                                            _unitOfWork = new UnitOfWork(dbFactory);
                                       }
- Code your method:
                                       //Add a new Discount 
--Ex:                                  public Discount Add(Discount discount)
                                       {
                                            Discount newDis = discount;
                                            _discountRepository.Add(newDis);
                                            _unitOfWork.Commit();

                                            return newDis;
                                       }

                                       //Get all Discount 
                                       public IEnumerable<Discount> GetAll()
                                       {
                                            return _discountRepository.GetAll();
                                       }