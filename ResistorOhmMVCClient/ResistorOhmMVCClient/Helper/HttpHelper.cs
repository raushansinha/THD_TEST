using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ResistorOhmMVCClient.Helper
{
    public class HttpHelper
    {
        private string _ohmCalculatorURI = "http://localhost:14009/";
        HttpClient client = new HttpClient();
        public HttpClient InitializeClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_ohmCalculatorURI);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }



    }
}
