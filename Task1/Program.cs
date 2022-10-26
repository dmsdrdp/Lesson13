using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес");
            string adress = Console.ReadLine();
            Console.WriteLine("Введите длину здания");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину здания");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту здания");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите этажность здания");
            int floors = Convert.ToInt32(Console.ReadLine());
            Building building = new Building(adress, l, b, h);
            MultiBuilding multiBuilding = new MultiBuilding(adress, l, b, h, floors);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
