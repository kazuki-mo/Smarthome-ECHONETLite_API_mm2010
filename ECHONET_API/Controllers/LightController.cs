using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECHONET_API.Controllers
{
    public class LightController : ApiController
    {
        // GET api/light
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/light/5
        public string Get(string fir, string sec) {
            Common com = new Common();
            return com.sendAPI("Light", fir, sec);
        }

        // GET api/ih/5
        public string Get(string fir) {
            Common com = new Common();
            return com.sendAPI_Short("Light", fir);
        }

        // POST api/light
        public void Post([FromBody]string value)
        {
        }

        // PUT api/light/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/light/5
        public void Delete(int id)
        {
        }
    }
}
