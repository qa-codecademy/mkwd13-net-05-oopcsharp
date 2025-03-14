using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.SeeSharp.Class06.App
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonStats()
        {
            return $"{FirstName} {LastName} and is {Age} years old";
        }
    }
}
