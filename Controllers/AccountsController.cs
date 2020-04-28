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

		string filers;

		public AccountsController () {
			this.accountsRepository = new AccountsRepository ();
		}

		// GET: api/Accounts
		[HttpGet]
		public Account[] Get () {
			return this.accountsRepository.GetAllAccounts ();
		}

		// GET: api/Accounts/#
		[HttpGet ("{id}", Name = "Get")]
		public Account Get (string id) { 
			return accountsRepository.RetrieveAccount(id);
		}

		// POST: api/Accounts
		[HttpPost]
		public void Post (string id, string filters) { 
			accountsRepository.createAccount(id, filters);
		}

		// PUT: api/Accounts/#
		[HttpPut ("{id}")]
		public void Put (string id, string filters) { 

		}

		// DELETE: api/ApiWithActions/5
		[HttpDelete ("{id}")]
		public void Delete (string id) { 			
			accountsRepository.deleteAccount(id);
		}
	}
}