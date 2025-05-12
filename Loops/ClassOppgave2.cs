using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class ClassOppgave2
    {

        public void Main()
        {
            string[] stringArray = { "T", "e", "r", "j", "e", "M", "a", "n", "n", "e", "n" };

            foreach (var terjeMannen in stringArray)
            {
                Console.WriteLine(terjeMannen);
            }
        }

    }
}
