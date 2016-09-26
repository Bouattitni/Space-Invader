using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpicyInvader
{
    class TimeCtrl
    {
        const int delay = 1000;

        public void dodo()
        {
            while (true)
            {
                Thread.Sleep(delay);
                Console.SetCursorPosition(30, 15);
                Console.Write("-OO-");
                Thread.Sleep(delay);
                Console.SetCursorPosition(30, 15);
                Console.Write("-XX-");
            }
        }
    }
}
