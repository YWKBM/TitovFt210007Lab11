using Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TitovFt210007Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //тестовый запрос
            GetRequest get = new GetRequest("https://restcountries.com/v3.1/capital/Moscow");
            get.Run();
            Console.WriteLine(get.Response);
        }
    }
}
