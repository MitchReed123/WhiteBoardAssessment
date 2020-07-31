using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBChallenge
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; }
        public DateTime BirthDate { get; set; }
        public string FullName
        {
            get
            {
                string fullName = $"{FirstName} {LastName}";
                return fullName;
            }

            set
            {
                FullName = FullName;
            }
        }

        public void totalNum(int numOne, int numTwo)
        {
            int total = numOne - numTwo;
            Console.WriteLine($"total num: {total}");
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, My name is {FullName}.");
        }

        public void SayHello(string firstName)
        {
            Console.WriteLine($"Hello {FirstName}, My name is {FullName}.");
        }

        public void SayHello(User person)
        {
            Console.WriteLine($"Hello {person.FirstName}, My name is {FullName}.");
        }
    }
}
