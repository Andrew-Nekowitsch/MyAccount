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

        // GET: api/Accounts
        [HttpGet]
        public Accounts[] Get()
        {
            return this.accountsRepository.GetAllAccounts();
        }

        // GET: api/Accounts/5
        [HttpGet("{id}", Name = "Get")]
        public Accounts Get(int id)
        {
            return new Accounts
            {
                Name = "Andrew Nekowitsch",
                Id = id,
                Password = "Get(int id)",
                Filters = new string[] { "Get(int id)" }
            };
        }

        // POST: api/Accounts
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Accounts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
