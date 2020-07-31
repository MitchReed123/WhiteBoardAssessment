using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = "mitchell";
            DateTime now = DateTime.Now;

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);


            Console.WriteLine("Feeling good today(Yes, no, maybe)?");
            string feeling = Console.ReadLine();

            switch (feeling)
            {
                case "Yes":
                    Console.WriteLine("Nice");
                    break;
                case "No":
                    Console.WriteLine("Ok");
                    break;
                case "Maybe":
                    Console.WriteLine("Gotcha");
                    break;
            }
            Console.WriteLine("Number One");
            string numOne = Console.ReadLine();
            Console.WriteLine("Number Two");
            string numTwo = Console.ReadLine();
            int numberOne = Convert.ToInt32(numOne);
            int numberTwo = Convert.ToInt32(numTwo);
            Console.WriteLine($"total num: {numberOne - numberTwo}");



            bool happy = true;
            if (happy)
            {
                Console.WriteLine("Noice");
            }
            else
            {
                Console.WriteLine("thats not good ");
            }

            string money;
            Console.WriteLine("What range of money do you make? (1000-10000, 11000 - 50000, 51000 - 100000)");
            money = Console.ReadLine();
            int theirMoney = Convert.ToInt32(money);

            if (theirMoney == 1000 || theirMoney == 10000)
            {
                Console.WriteLine("oof");
            }
            else if (theirMoney == 11000 || theirMoney == 50000)
            {
                Console.WriteLine("gettin there");
            }
            else if (theirMoney == 51000 || theirMoney == 100000)
            {
                Console.WriteLine("Fuckin nice");
            }
            else
            {
                Console.WriteLine("get your money up dog");
            }



            User person = new User();
            person.FirstName = "Mitch";
            person.LastName = "Reed";
            person.BirthDate = DateTime.Now;
            
            person.SayHello();
            person.SayHello(person.FirstName);

            Console.ReadLine();
        }
    }
}
