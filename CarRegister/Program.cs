using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            Console.Write("Förnamn: ");
            p.FirstName = Console.ReadLine();
            Console.Write("Efternamn: ");
            p.LastName = Console.ReadLine();

            Console.Write("Antal bilar: ");
            int carCount = int.Parse(Console.ReadLine());

            p.Cars = new List<Car>();

            for (int i = 0; i < carCount; i++)
            {
                Console.Write("RegNo: ");
                p.Cars.Add(new Car() { RegNo = Console.ReadLine() });
            }

            using (CarRegisterContext ctx = new CarRegisterContext())
            {
                ctx.People.Add(p);
                ctx.SaveChanges();
            }

            Console.WriteLine("{0} {1} sparad med {2} bilar",
                p.FirstName, p.LastName, carCount);

            Console.WriteLine("Tryck på någon tangent för att fortsätta...");
            Console.ReadKey();
        }
    }
}
