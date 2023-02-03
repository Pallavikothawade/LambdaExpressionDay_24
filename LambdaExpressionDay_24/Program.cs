using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionDay_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome The Lambda Expression");

            List<Person> listOfPerson = new List<Person>();
            AddingPersonDetailsIntoList(listOfPerson);

            Console.ReadLine();
        }
        public static void AddingPersonDetailsIntoList(List<Person>list)
        {
                list.Add(new Person() { SSN = 1, Name = "Priyansh", Address = "Jalgaon", Age = 12 });
                list.Add(new Person() { SSN = 2, Name = "Riya", Address = "bnglor", Age = 70 });
                list.Add(new Person() { SSN = 3, Name = "Ankita", Address = "Mumbai", Age = 32 });
                list.Add(new Person() { SSN = 4, Name = "Swara", Address = "Pune", Age = 16 });
                list.Add(new Person() { SSN = 5, Name = "Riyansh", Address = "Dombivli", Age = 63 });
                list.Add(new Person() { SSN = 6, Name = "Shruti", Address = "Dhule", Age = 36 });
                list.Add(new Person() { SSN = 1, Name = "Anvay", Address = "Raver", Age = 14 });
                DisplayPersonDetails(list);
        }
        public static void DisplayPersonDetails(IEnumerable<Person>list)
        {
            foreach(Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    
    }
    
}
