using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace OrderService.Utilities
{
    public static class WebApiClient
    {
        //todo: read from config
        private const string ProxyUrl = "172.0.0.0.1";

        public static async Task<dynamic> CallWebApi(string targetUrl)
        {
            if (targetUrl == null) throw new ArgumentNullException(nameof(targetUrl));

            try
            {
                var targetURL = targetUrl;

                var handler = new HttpClientHandler()
                {
                    Proxy = new WebProxy(Address: ProxyUrl),
                    UseProxy = true,
                };

                var client = new HttpClient(handler);

                var response = await client.GetAsync(targetURL);
                var content = response.Content;

                if (!response.IsSuccessStatusCode) return null;
                object result = await content.ReadAsStringAsync();

                if (result == null) return null;
                dynamic dyn = JObject.Parse(result.ToString());

                return dyn;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
