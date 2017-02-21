using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Entities;
using Newtonsoft.Json;

namespace ConsoleApp
{
    public class CarsRESTService
    {
        readonly string baseUri = "http://api.csspro.ir/api/organization/";

        public List<Organization> GetCars()
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<List<Organization>>(response.Result).Result;
            }
        }
    }

    class Program
    {
        private static CarsRESTService carsService = new CarsRESTService();


        static void Main(string[] args)
        {
             
            var cars = carsService.GetCars();
            foreach (var organization in cars)
            {
                Console.WriteLine($"Name: {organization.Name}\tPrice: {organization.Id}\tCategory: {organization.Desc}");
            }
            Console.ReadKey();



        }

       

    }
}
