using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamirasRestaurant.Domain.Infrastructure
{
	public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataAccess>
	{
		protected override void Seed(DataAccess db)
		{
			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Almiralei",
					LastName = "Maravillo",
					Password = "Oct1207",
					UserName = "Mira",
					Role = Models.Enums.Role.Admin
				}
			);
			db.SaveChanges();

			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Shayne",
					LastName = "Maravillo",
					Password = "Oct1207",
					UserName = "Shayne",
					Role = Models.Enums.Role.Admin
				}
			);
			db.SaveChanges();

			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Shayne",
					LastName = "Maravillo",
					Password = "Oct1207",
					UserName = "Shayne",
					Role = Models.Enums.Role.InventoryController
				}
			);
			db.SaveChanges();

			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "AlmiraLei",
					LastName = "Maravillo",
					Password = "Oct1207",
					UserName = "Mira",
					Role = Models.Enums.Role.InventoryController
				}
			);
			db.SaveChanges();

			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Janielle",
					LastName = "Ramos",
					Password = "Oct1207",
					UserName = "Jane",
					Role = Models.Enums.Role.Cashier
				}
			);
			db.SaveChanges();

			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Sophia",
					LastName = "DelaCruz",
					Password = "Oct1207",
					UserName = "Phia",
					Role = Models.Enums.Role.Cashier
				}
			);
			db.SaveChanges();

			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Carolyn",
					LastName = "Reyes",
					Password = "Oct1207",
					UserName = "Carol",
					Role = Models.Enums.Role.Waiter
				}
				);
			db.SaveChanges();

			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Ariane",
					LastName = "Garcia",
					Password = "Oct1207",
					UserName = "Ayen",
					Role = Models.Enums.Role.Waiter
				}
				);
			db.SaveChanges();
			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Pamela",
					LastName = "Miranda",
					Password = "Oct1207",
					UserName = "Pam",
					Role = Models.Enums.Role.Waiter
				}
				);
			db.SaveChanges();
			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Christian",
					LastName = "Dabu",
					Password = "Oct1207",
					UserName = "Chris",
					Role = Models.Enums.Role.Waiter
				}
				);
			db.SaveChanges();
			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Romenick",
					LastName = "Peralta",
					Password = "Oct1207",
					UserName = "Rome",
					Role = Models.Enums.Role.Waiter
				}
				);
			db.SaveChanges();
			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "Marco",
					LastName = "Layacan",
					Password = "Oct1207",
					UserName = "Mar",
					Role = Models.Enums.Role.Waiter
				}
			   );
			db.SaveChanges();
			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "JohnFrancis",
					LastName = "Susi",
					Password = "Oct1207",
					UserName = "Francis",
					Role = Models.Enums.Role.Chef
				}
				);
			db.SaveChanges();
			db.Users.Add(
				new Models.User()
				{
					Id = Guid.NewGuid(),
					FirstName = "JohnPaul",
					LastName = "Santos",
					Password = "Oct1207",
					UserName = "Paul",
					Role = Models.Enums.Role.Chef
				}
				);
		}
	}
}
		
               
