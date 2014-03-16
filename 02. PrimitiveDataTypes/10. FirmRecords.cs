using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many employers you have.");
            int employers = int.Parse(Console.ReadLine());
            string firstName;
            string secondName;
            byte age;
            string gender;
            int Id;
            int unique;
            for (int i = 0; i < employers; i++)
            {
                Console.WriteLine(new string('-', 40));
                Console.Write("Enter first name: ");
                 firstName = Console.ReadLine();
                Console.Write("Enter SecondName name: ");
                secondName = Console.ReadLine();
                Console.Write("Enter your age: ");
                age = byte.Parse(Console.ReadLine());
                Console.Write("Enter your gender: ");
                gender = Console.ReadLine();
                Console.Write("Enter you ID: ");
                Id = int.Parse(Console.ReadLine());
                Console.Write("Enter your unique employee number: ");
                unique = int.Parse(Console.ReadLine());
                Console.WriteLine(new string('-', 40));
			}
        }
    }
}
