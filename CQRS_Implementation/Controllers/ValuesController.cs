using Microsoft.AspNetCore.Mvc;
using Service.Commands;
using Service.DTO;
using Service.Queries.Demo;
using Service.Transmitter;
using System.Collections.Generic;

namespace CQRS_Implementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Transmitter _transmitter;

        public ValuesController(Transmitter transmitter)
        {
            _transmitter = transmitter;
        }

        // GET api/values
        [HttpGet]
        [Route("{name}")]
        public ActionResult<IEnumerable<string>> Get(string name)
        {
            var valuesQuery = new GetDemoValuesQuery(name);
            var result = _transmitter.Transmit(valuesQuery);
            return Ok(result);
        }


        // POST api/values/type
        [HttpPost]
        [Route("type/{type}")]
        public IActionResult Post(int type,[FromBody]PostValueCommandDTO postValuesCommand)
        {
            var post = new PostValuesCommand(postValuesCommand.Name, type);
            var result = _transmitter.Transmit(post);
            return Ok(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
