using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAccount.Models
{
	public class Account
	{
		public int Id { get; set; }
		public string[] Filters { get; set; }

		public Account(int identificationNumber, string[] filterList)
		{
			this.Id = identificationNumber;
			this.Filters = filterList;
		}

	}
}
