using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionDay_24
{ 
    class Person
    {
        public int SSN { get;set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"SSN:{SSN} Name:{Name} address:{Address} age:{Age}";
        }

    }
}
