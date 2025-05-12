using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class ClassOppgave3
    {
        public void Main()
        {
            bool shouldContinue = true;
            int i = 0;
            while (shouldContinue == true)
            {
                if (i > 9)
                {
                    shouldContinue = false;
                }
                Console.WriteLine("Runde nr: "+ i);
                i++;
            }
        }
    }
}
