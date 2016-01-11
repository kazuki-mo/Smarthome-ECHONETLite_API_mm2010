using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECHONET_API.Controllers
{
    public class IHController : ApiController
    {
        // GET api/ih
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/ih/5
        public string Get(string fir, string sec) {
            Common com = new Common();
            return com.sendAPI("IH", fir, sec);
        }

        // GET api/ih/5
        public string Get(string fir) {
            Common com = new Common();
            return com.sendAPI_Short("IH", fir);
        }

        // POST api/ih
        public void Post([FromBody]string value)
        {
        }

        // PUT api/ih/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/ih/5
        public void Delete(int id)
        {
        }
    }
}
