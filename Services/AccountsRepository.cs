using MyAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAccount.Services
{
	public class AccountsRepository
	{
        public Account[] GetAllAccounts()
        {
            return new Account[]
            {
                new Account(1, null),
                new Account(2, new string[] {"Gluten-Free"}),
                new Account(3, new string[] {"Carnivore"}),
                new Account(4, new string[] {"Vegen"}),
            };
        }

		public Account RetrieveAccount(int id)
		{
			//query db
			string[] filters = {"",""};
			return new Account(id, filters);
		}
    }
}
