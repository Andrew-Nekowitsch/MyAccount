using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyAccount.Models;

namespace MyAccount.Services {
	public class AccountsRepository {
		private SqlConnection sqlConnection;
		private string connStr = "Server=tcp:cc-accounts.database.windows.net,1433;Initial Catalog=accounts;Persist Security Info=False;User ID=CCMyAccount;Password=CC-MyAccount;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

		public AccountsRepository () {
			var conn = new SqlConnection (connStr);
			this.sqlConnection = conn;
			this.sqlConnection.Open ();
		}

		public Account[] GetAllAccounts () {
			return new Account[] {
				new Account ("1", null),
					new Account ("2", new string[] { "Gluten-Free" }),
					new Account ("3", new string[] { "Carnivore" }),
					new Account ("4", new string[] { "Vegen" }),
			};
		}

		public Account RetrieveAccount (string id) {
			using (SqlCommand command = new SqlCommand ("SELECT * FROM account where id=" + id + ";", sqlConnection)) {
				using (SqlDataReader reader = command.ExecuteReader ()) {
					while (reader.Read ()) {
						if (id == reader.GetString (0))
							return new Account (reader.GetString (0), reader.GetString (1).Split (","));
					}
				}
			}
			return new Account ("404", new string[] { "Couldn't find account with id=" + id });
		}

		public void createAccount (string id, string filters) {
			SqlCommand command = new SqlCommand ("INSERT into account values ('" + id + "', '" + filters + "');", sqlConnection);
			command.ExecuteNonQuery ();
		}

		public void deleteAccount (string id) {
			SqlCommand command = new SqlCommand ("delete from account where id = " + id + "');", sqlConnection);
			command.ExecuteNonQuery ();
		}
	}

}