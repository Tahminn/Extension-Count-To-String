using System;
using System.Collections.Generic;
using System.Text;

namespace HierarchyUsingAbstraction
{
    class Khalid : Employer
    {
        public override void Like()
        {
            Console.WriteLine("Khalid likes to meet with friends");
        }
        public override void Hate()
        {
            Console.WriteLine("Khalid hates to do homework");
        }
    }
}
