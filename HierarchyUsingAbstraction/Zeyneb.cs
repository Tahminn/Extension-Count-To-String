using System;
using System.Collections.Generic;
using System.Text;

namespace HierarchyUsingAbstraction
{
    class Zeyneb : Student
    {
        public override void Like()
        {
            Console.WriteLine("Zeyneb likes to go on a journey");
        }
        public override void Hate()
        {
            Console.WriteLine("Zeyneb hates to swim");
        }
    }
}
