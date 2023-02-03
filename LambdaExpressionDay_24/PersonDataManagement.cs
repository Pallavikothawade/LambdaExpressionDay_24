using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace LambdaExpressionDay_24
{
    class PersonDataManagement
    {
        public static void RetreiveTop2Records(List<Person>list)
        {
            Console.WriteLine("\nRetrieve top 1 Records based on age ");
            //var ageLessThan60= list.Where(p => p.Age < 60);
            //var sortedData=ageLessThan60.OrderBy(a => a.Age);
            //var top2 = sortedData.Take(2);
            var top2 = list.Where(p => p.Age < 60).OrderBy(a => a.Age).Take(2);
            Program.DisplayPersonDetails(top2);
        }

    }
}
