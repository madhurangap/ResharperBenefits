using System;
using Microsoft.AspNetCore.Mvc;

namespace Questrade.ResharperBenefits.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            string ending = "";
            return "value" + ending;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return "Value1";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
           
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
