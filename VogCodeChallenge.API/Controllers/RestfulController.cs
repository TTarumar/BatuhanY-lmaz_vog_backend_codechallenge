using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestfulController : ControllerBase
    {
        // GET: api/Restful
        [HttpGet]
        public IEnumerable<Employee> Get()
        {

            var emplyolist = new List<Employee>();

            var EmployeInfo = new Employee();

            emplyolist.Add(EmployeInfo);

            return emplyolist;
        }

        // GET: api/Restful/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return new Employee {
                Adress="Ankara/Türkiye"    
            };
            
        }

        
    }
}
