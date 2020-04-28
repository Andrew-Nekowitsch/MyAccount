using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAccount.Models
{
	public class Account
	{
		public string Id { get; set; }
		public string[] Filters { get; set; }

		public Account(string identifier, string[] filterList)
		{
			this.Id = identifier;
			this.Filters = filterList;
		}

	}
}
