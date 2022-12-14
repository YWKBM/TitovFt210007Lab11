using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Requests
{
    public class GetRequest
    {
        string Address;
        HttpWebRequest Request;

        public string Response { get; set; }


        public GetRequest(string adress)
        {
            Address = adress;
        }

        //Делаем запрос и получаем ответ
        public void Run()
        {
            Request = (HttpWebRequest)WebRequest.Create(Address);
            Request.Method = "Get";

                HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
                var stream = response.GetResponseStream();
                if (stream != null)
                {
                    Response = new StreamReader(stream).ReadToEnd();
                stream.Close();
                }
        }
    }
}