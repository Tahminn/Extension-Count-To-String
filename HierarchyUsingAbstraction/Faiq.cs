using System;
using System.Collections.Generic;
using System.Text;

namespace HierarchyUsingAbstraction
{
    class Faiq : Employer
    {
        public override void Like()
        {
            Console.WriteLine("Faiq likes reading a book");
        }
        public override void Hate()
        {
            Console.WriteLine("Faiq hates fishing");
        }
    }
}
