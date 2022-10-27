using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите марку машины: ");
            string a=Console.ReadLine();
            Console.Write("Введите кол-во сил: ");
            double b=Convert.ToDouble(Console.ReadLine());
            Mercedes fgh = new Mercedes(a, b);
            fgh.Print();
            Console.ReadKey();
        }
        public class Mercedes
        {
            public string Stamp { get; set; }
            public double Horsepower { get; set; }

            public Mercedes(string stamp, double horsepower)
            {
                this.Stamp = stamp;
                this.Horsepower = horsepower;
            }


            public void Print()
            {
                Console.Write($"Stamp: {Stamp} Horsepower: {Horsepower}");
            }
        }
    }
}
