using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAccount.Models;
using MyAccount.Services;

namespace MyAccount.Controllers {
	[Route ("api/[controller]")]
	[ApiController]
	public class AccountsController : ControllerBase {
		private AccountsRepository accountsRepository;
		string connStr = "Server=tcp:cc-accounts.database.windows.net,1433;Initial Catalog=accounts;Persist Security Info=False;User ID=CCMyAccount;Password=CC-MyAccount;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
		SqlConnection sqlConnection;

		string filers;

		public AccountsController () {
			this.accountsRepository = new AccountsRepository ();
			var conn = new SqlConnection (connStr);
			this.sqlConnection = conn;
			this.sqlConnection.Open ();
		}

		// GET: api/Accounts
		[HttpGet]
		public Account[] Get () {
			return this.accountsRepository.GetAllAccounts ();
		}

		// GET: api/Accounts/#
		[HttpGet ("{id}", Name = "Get")]
		public Account Get (int id) { 

			using (SqlCommand command = new SqlCommand ("SELECT * FROM account where id=" + id + ";", sqlConnection)) {
				using (SqlDataReader reader = command.ExecuteReader ()) {
					while (reader.Read ()) {
						if(id == reader.GetInt32(0))
							return new Account (reader.GetInt32(0), reader.GetString (1).Split(","));
					}
					//Console.ReadLine ();
				}
			}
			return new Account (id, new string[] { "Get(int id)" });
		}

		// POST: api/Accounts
		[HttpPost]
		public void Post ([FromBody] string value) { 
			
		}

		// PUT: api/Accounts/#
		[HttpPut ("{id}")]
		public void Put (int id, [FromBody] string value) { }

		// DELETE: api/ApiWithActions/5
		[HttpDelete ("{id}")]
		public void Delete (int id) { }
	}
}