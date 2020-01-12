using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAccount.Models
{
	public class Accounts
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string[] Filters { get; set; }

		public string Password { get; set; }
		/* 
		public string email { get; set; }
		public string phone { get; set; }
		public int role { get; set; }
		 */
	}
}
