using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_20_Szuperhosok
{
    internal interface ISzuperhos
    {
        bool LegyoziE(ISzuperhos ellenfel);
        double MekkoraAzEreje();
    }
}
