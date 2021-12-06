using System;
using System.Collections.Generic;
using System.Text;

namespace HM.Interface.Models
{
    public abstract class Human: IBreath
    {
 
        public void IBreath()
        {
            Console.WriteLine("Breathing");
        }

        public abstract string Breathing();
    }
}
