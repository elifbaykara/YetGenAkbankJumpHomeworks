using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Validation.Domain.Entities;
using Validation.Persistence.Contexts;

namespace Validation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly PerfectAppDbContext _perfectAppDbContext;

        public BankAccountsController(PerfectAppDbContext perfectAppDbContext)
        {
            _perfectAppDbContext = perfectAppDbContext;
        }

        [HttpPost("[action]")]
        public void SetDefaultUsersData()
        {
            List<BankAccount> people = new List<BankAccount>
            {
                new BankAccount
                {
                    Id = Guid.Parse("f4eella6-9d8e-4584-8d7f-8ed2d83119c9"),
                    FirstName = "James",
                    LastName = "Smith",
                },
                new BankAccount
                {
                    Id = Guid.Parse("73af4318-299e-41c8-9544-6bd131d6b651"),
                    FirstName = "Mary",
                    LastName = "Johnson",
                    PhoneNumber = "5798283382"
                },
                new BankAccount
                {
                    Id = Guid.Parse("d3c4bad1-5b5e-45ed-969c-63cdd1474397"),
                    FirstName = "John",
                    LastName = "Williams",
                    PhoneNumber = "5872876113"
                },
                new BankAccount
                {
                    Id = Guid.Parse("96ee8bd8-7604-4ca2-be17-9b4488ce3410"),
                    FirstName = "Patricia",
                    LastName = "Brown",
                    PhoneNumber = "5980755884"
                },
                new BankAccount
                {
                    Id = Guid.Parse("df4a398a-7faa-4d25-998a-7fcbdb074565"),
                    FirstName = "Robert",
                    LastName = "Jones",
                    PhoneNumber = "5877036595"
                }
            };

            _perfectAppDbContext.People.AddRange(people);
            _perfectAppDbContext.SaveChanges();
        }
    }
}
