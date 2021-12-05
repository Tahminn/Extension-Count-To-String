using System;
using System.Collections.Generic;
using System.Text;

namespace HierarchyUsingAbstraction
{
    public abstract class Humans
    {
        public string Gender { get; set; }
        public string Nation { get; set; }

        public abstract void Like();
        public abstract void Hate();
       
    }
}
