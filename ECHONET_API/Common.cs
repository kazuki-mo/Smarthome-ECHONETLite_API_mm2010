using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.IO;
using System.Net;

namespace ECHONET_API {
    public class Common {

        public string sendAPI(string Appliance, string fir, string sec) {

            // POSTする対象のURL
            string url = "http://192.168.10.72:5000/" + Appliance + "/" + fir + "/" + sec;

            // リクエスト作成
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            // レスポンスの取得
            WebResponse response = request.GetResponse();

            // 結果の読み込み
            string htmlString = "";
            using (Stream resStream = response.GetResponseStream())
            using (var reader = new StreamReader(resStream, Encoding.GetEncoding("utf-8")))
                htmlString = reader.ReadToEnd();

            return htmlString;

        }

        public string sendAPI_Short(string Appliance, string fir) {

            // POSTする対象のURL
            string url = "http://192.168.10.72:5000/" + Appliance + "/" + fir;

            // リクエスト作成
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            // レスポンスの取得
            WebResponse response = request.GetResponse();

            // 結果の読み込み
            string htmlString = "";
            using (Stream resStream = response.GetResponseStream())
            using (var reader = new StreamReader(resStream, Encoding.GetEncoding("utf-8")))
                htmlString = reader.ReadToEnd();

            return htmlString;

        }

    }
}