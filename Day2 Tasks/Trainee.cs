using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Tasks
{
    internal class Trainee : Person
    {
        public int IntakeNumber;
        public override string ToString()
        {
            return $"Trainee  Name: {Name} , Age {Age}, National ID {NationalID}, Intake Number {IntakeNumber}";
            ;
        }
    }
}
