using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Text;
using System.IO;
using System.Web;

namespace ECHONET_API.Controllers
{
    public class AirconController : ApiController
    {
        // GET api/aircon
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/aircon/{command}
        public string Get(string fir, string sec)
        {

            //// POSTする対象のURL
            //string url = "http://192.168.10.72:5000/Aircon_LR/" + fir + "/" + sec;

            //// リクエスト作成
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.Method = "GET";

            //// レスポンスの取得
            //WebResponse response = request.GetResponse();

            //// 結果の読み込み
            //string htmlString = "";
            //using (Stream resStream = response.GetResponseStream())
            //using (var reader = new StreamReader(resStream, Encoding.GetEncoding("utf-8")))
            //    htmlString = reader.ReadToEnd();

            //return htmlString;

            Common com = new Common();
            return com.sendAPI("Aircon_LR", fir, sec);
        }

        // POST api/aircon
        public void Post([FromBody]string value)
        {
        }

        // PUT api/aircon/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/aircon/5
        public void Delete(int id)
        {
        }
    }
}
