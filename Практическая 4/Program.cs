using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _4_практическая
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { "regwa", 24, 2, "GSD", "bFDS", "q", 112301, 13123437, "IDDQD", 22325328, "qfdsgfd", "gfdq", "nhgf", "juyr", 2254235 };
            ArrayList lost = new ArrayList();
            string h = "";
            foreach (var i in list)
            {
                Type t = i.GetType();
                if (t.Equals(typeof(int)) == false)
                {
                    h += i + " ";
                }
            }
            Console.WriteLine(h);
            Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (Char.IsUpper(list[i].ToString().ToCharArray()[0]))
                {
                    lost.Add(list[i]);
                }
            }
            foreach (var i in lost)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadLine();
        }
    }
}
