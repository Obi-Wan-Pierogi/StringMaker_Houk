// Lee Houk
// IT113
// NOTES: Fun project, really got me thinking.
// BEHAVIORS NOT IMPLIMENTED AND WHY: Got them all

namespace StringMaker_Houk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringManager sm = new StringManager();

            Console.WriteLine("Reverse string");
            string reverse = "Sunbeam Tiger";
            Console.WriteLine(sm.Reverse(reverse) + "\n");

            Console.WriteLine("Convert a string to ASCII and return the summed value as words");
            string strAscii = "One Two Five Four";
            sm.SetInput(strAscii);
            Console.WriteLine(sm.ToString() + "\n");

            Console.WriteLine("Reverse string with preserved case location");
            Console.WriteLine(sm.Reverse(reverse, true) + "\n");

            Console.WriteLine("Equality check");
            string equality = "Sunbeam Tiger";
            sm.SetInput(equality);
            Console.WriteLine(sm.Equals("Sunbeam Tiger") + "\n");

            Console.WriteLine("Symmetric string");
            string sym1 = "ABBA";
            string sym2 = "ABA";
            string sym3 = "ABba";
            Console.WriteLine(sm.Symmetric(sym1));
            Console.WriteLine(sm.Symmetric(sym2));
            Console.WriteLine(sm.Symmetric(sym3) + "\n");
        }
    }
}