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
            emplString.things = new List<string>();
            emplString.things.Add("screws");
            emplString.things.Add("bolts");
            emplString.things.Add("things");
            emplString.things.Add("stuff");

            foreach (string emplStrings in emplString.things)
            {
                Console.WriteLine(emplString);
            }

            Employee<int> emplInt = new Employee<int>();
            emplInt.things = new List<int>();
            emplInt.things.Add(12);
            emplInt.things.Add(13);
            emplInt.things.Add(14);
            emplInt.things.Add(15);
           
            foreach (int emplInts in emplInt.things)
            {
                Console.WriteLine(emplInt);
            }
            Console.ReadLine();
        }
    }
}
