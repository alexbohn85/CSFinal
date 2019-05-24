using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebAPI_Json
{
    class Program
    {
        const string baseURI = "http://www.json-generator.com/api/json/get/bPCtVMPmNu?indent=0";

        static void Main(string[] args)
        {
            // gather json data from API and store at array of Student
            HttpClient client = new HttpClient();
            string json = client.GetStringAsync(baseURI).Result;
            Student[] jsonArr = JsonConvert.DeserializeObject<Student[]>(json);

            // print each student greeting method
            foreach (var item in jsonArr)
            {
                item.Greeting();
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }

}