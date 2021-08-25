using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahr, celsius;

            Console.Write("Informe a temperatura em Fahrenheit: ");
            fahr = double.Parse(Console.ReadLine());

            celsius = (fahr - 32)/1.8;

            Console.WriteLine("A temperatura equivalente em Celcius é de " + celsius + "°!");

            Console.ReadKey();
        }
    }
}
