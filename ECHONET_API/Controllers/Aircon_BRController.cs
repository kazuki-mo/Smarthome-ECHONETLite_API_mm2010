using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECHONET_API.Controllers
{
    public class Aircon_BRController : ApiController
    {
        // GET api/aircon_br
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/aircon_br/5
        public string Get(string fir, string sec)
        {
            Common com = new Common();
            return com.sendAPI("Aircon_BR", fir, sec);
        }

        // GET api/ih/5
        public string Get(string fir) {
            Common com = new Common();
            return com.sendAPI_Short("Aircon_BR", fir);
        }

        // POST api/aircon_br
        public void Post([FromBody]string value)
        {
        }

        // PUT api/aircon_br/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/aircon_br/5
        public void Delete(int id)
        {
        }
    }
}
