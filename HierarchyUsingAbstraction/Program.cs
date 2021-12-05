using System;

namespace HierarchyUsingAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Humans human1 = new Humans();
            Faiq faiq = new Faiq();
            faiq.Like();
            faiq.Hate();

            Zeyneb zeyneb = new Zeyneb();
            zeyneb.Like();
            zeyneb.Hate();

            Khalid khalid = new Khalid();
            khalid.Like();
            khalid.Hate();
        }
    }
}
