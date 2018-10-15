using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoAPI
{
    class Program
    {
        static  void Main(string[] args)
        {
            InvocarAPI();
        }

        private static  void InvocarAPI()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://talleapi.azurewebsites.net/");

            var request =  client.GetAsync("/api/Publicacion").Result;
            if (request.IsSuccessStatusCode)
            {
                var response = request.Content.ReadAsStringAsync().Result;
            }
        }

    }
}
