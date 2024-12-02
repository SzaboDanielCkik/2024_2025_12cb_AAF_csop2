using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_25_Interface
{
    internal class Osztaly: IFenykepezo
    {
        public void FenykepetKeszit(int p)
        {
            Console.WriteLine(p+" Fényképet készítettem.");
        }
    }
}
