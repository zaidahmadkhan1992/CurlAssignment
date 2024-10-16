﻿using Demo.Connection;
using Demo.HelperFunctions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ADPController : ControllerBase
    {
        public readonly IConnection utilityFucntion;
        public ADPController(IConnection utilityFucntion)
        {
            this.utilityFucntion = utilityFucntion;
            //this.utilityFucntion.writeToMySQL();
        }
        // GET: api/<ADPController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ADPController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return this.utilityFucntion.getConnection;
        }

        // POST api/<ADPController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ADPController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ADPController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
