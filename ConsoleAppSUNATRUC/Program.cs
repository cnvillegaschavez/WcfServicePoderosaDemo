using ConsoleAppSUNATRUC.Class;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace ConsoleAppSUNATRUC
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese RUC or DNI:");
                var number = Console.ReadLine();
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/sunatphp/prueba.php?number=" + number);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";
                string text;
                var response = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                }

                var result = JsonConvert.DeserializeObject<ResponseDto>(text);

                Console.WriteLine(text);
            }

        }
    }
}
