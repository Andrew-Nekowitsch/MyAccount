using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAccount.Models;
using MyAccount.Services;

namespace MyAccount.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountsController : ControllerBase
	{

		private AccountsRepository accountsRepository;

		public AccountsController()
		{
			this.accountsRepository = new AccountsRepository();
		}

		public Accounts[] Get()
		{
			return this.accountsRepository.GetAllAccounts();
		}
	}
}