using Business.Concrete;
using DataAccess.Concrete;
using Entity.Entities.Concrete;

CarManager carManager = new CarManager(new CarDal());
carManager.Update(new Car { Guid = "2301aad3-d833-46e8-b7a5-57b165a868b5", BrandId = "2", ColorId = "1", DailyPrice = 25000, Description = "BMW M4 Comptetion", ModelYear = 2018 });

Console.WriteLine(carManager.Get(x => x.Guid == "2301aad3-d833-46e8-b7a5-57b165a868b5").UpdatedDate);
Console.ReadLine();