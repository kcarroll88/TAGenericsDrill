using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TAGenericsDrill
{
    class Program
    {
        static void Main(string[] args)
        {           
            Employee<string> emplString = new Employee<string>();
            emplString.things.Add("screws");
            emplString.things.Add("bolts");
            emplString.things.Add("things");
            emplString.things.Add("stuff");

            foreach (string emplStrings in emplString)
            {
                Console.WriteLine(emplString.things);
            }

            Employee<int> emplInt = new Employee<int>();
            emplInt.things.Add(12);
            emplInt.things.Add(13);
            emplInt.things.Add(14);
            emplInt.things.Add(15);
           
            foreach (int emplInts in emplInt)
            {
                Console.WriteLine(emplInt.things);
            }
            Console.ReadLine();
        }
    }
}
