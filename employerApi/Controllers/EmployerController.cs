using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using unitTesting.models.Services;

namespace unitTesting.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerServices _employer;

        public EmployerController(IEmployerServices service)
        {
            _employer = service;
        }

        //api/employer/get
        [HttpGet]
        public IActionResult Get() => Ok(_employer.Get());

        //api/employer/GetById/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employer = _employer.Get(id);
            if(employer == null)
                return NotFound();

            return Ok(employer);
        }
    }
}