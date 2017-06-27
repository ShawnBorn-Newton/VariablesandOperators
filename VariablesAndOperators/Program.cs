using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //donor info
            Console.WriteLine("Name of donor:");
            string don = Console.ReadLine() ;

            Console.WriteLine("Address of donor: ");
            string address = Console.ReadLine();

            Console.WriteLine("Email adress of donor: ");
            string email = Console.ReadLine();

            //donation imput
            Console.WriteLine("How many quarters donated?");
            double quarters = double.Parse(Console.ReadLine());

            Console.WriteLine("How many dollars donated?");
            double dollars = double.Parse(Console.ReadLine());

            Console.WriteLine("How many $5s donated?");
            double fives = double.Parse(Console.ReadLine());

            Console.WriteLine("How many $10s donated?");
            double tens = double.Parse(Console.ReadLine());

            Console.WriteLine("How many $20s donated?");
            double twonties = double.Parse(Console.ReadLine());

            Console.WriteLine("How many $50s donated?");
            double fties = double.Parse(Console.ReadLine());

            Console.WriteLine("How many $100s donated?");
            double hundreds = double.Parse(Console.ReadLine());


            // donation tally
            double totalQuarters = quarters * .25d;
            double totalDollars = dollars * 1d;
            double totalFives = fives * 5d;
            double totalTens = tens * 10d;
            double totalTwonties = twonties * 20d;
            double totalFties = fties * 50d;
            double totalHundreds = hundreds * 100d; 
            
            double donationTotal = totalQuarters + totalDollars + totalFives + totalTens + totalTwonties + totalFties + totalHundreds;

            //receipte print

            Console.WriteLine("Name: " + don);
            Console.WriteLine("Adress: " + address);
            Console.WriteLine("Email: " + email);
            Console.WriteLine(" Fiscal year: 2017");
            Console.WriteLine("Donation total: " + donationTotal);

        }
    }
}
