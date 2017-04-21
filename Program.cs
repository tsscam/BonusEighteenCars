using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string str = new string('*', 20);
            CarClass CarClass1 = new CarClass();
            CarClass1.CarMake1 = "";
            CarClass1.CarModel1 = "";
            CarClass1.CarYear1 = 0;
            CarClass1.CarPrice1 = 0;

            //greeting
            Console.WriteLine("Welcome to Grand Circus Motors Admin Console");
            Console.WriteLine("");

            //direction to user
            Console.WriteLine("Enter your cars information, as seen below:");
            Console.WriteLine("");
            
            CarClass Car1 = new CarClass();
            
            //input requested
            Console.WriteLine("Enter the Make of your car: ");
            Car1.CarMake1 = Console.ReadLine();

            Console.WriteLine("Enter the Model of your car: ");
            Car1.CarModel1 = Console.ReadLine();

            Console.WriteLine("Enter the Year of your car: ");
            Car1.CarYear1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Price of your car: ");
            Car1.CarPrice1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Response from user input 
            Console.WriteLine("Current Inventory: ");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.Write( Car1.CarMake1 + "\t");
            
            Console.Write(Car1.CarModel1 + "\t");
            
            Console.Write(Car1.CarYear1 + "\t");
            
            Console.Write("$" + Car1.CarPrice1 + "\t" + "\t");
            Console.WriteLine("");

            //Pretty
            
            Console.WriteLine("*********************");
            //Salute
            Console.WriteLine("Thank you! ");
            Console.WriteLine("");

        }
    }
}
