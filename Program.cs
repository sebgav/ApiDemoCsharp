using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("api/users?page=2", Method.Get);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
           RestResponse restResponse = client.Execute(request);
            var content = restResponse.Content;
            Console.WriteLine(content); 
            Console.ReadKey();  
            
        }
    }
}
