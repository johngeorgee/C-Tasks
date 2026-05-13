using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Tasks
{
    internal class Person
    {
        public int NationalID;
        public int Age;
        public string Name;

        public override string ToString()
        {
            return $"Person Name: {Name} , Age {Age}, National ID {NationalID}";
        }
    }
}
