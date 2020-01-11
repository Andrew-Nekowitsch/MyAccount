using MyAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAccount.Services
{
	public class AccountsRepository
	{
        public Accounts[] GetAllAccounts()
        {
            return new Accounts[]
            {
                new Accounts
                {
                    Id = 1,
                    Name = "Andrew Nekowitsch",
                    Password = "NeckOfWitch",
                    Filters = null
                },
                new Accounts
                {
                    Id = 2,
                    Name = "Grant Lalonde",
                    Password = "LaLaLand",
                    Filters = new string[] {"Gluten-Free"}
                },
                new Accounts
                {
                    Id = 3,
                    Name = "Patrick Van Landschoot",
                    Password = "SchoolShooter",
                    Filters = new string[] {"Carnivore"}
                },
                new Accounts
                {
                    Id = 4,
                    Name = "Mark Selyukov",
                    Password = "SuckYouOff",
                    Filters = new string[] {"Vegen"}
                },
            };
        }
    }
}
