using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali
{
    internal class Gatto : Animale
    {
        

        public override void faiVerso(int nrVolte)
        {
            for (int i = 0; i < nrVolte; i++)
                Console.WriteLine("Miao");
        }
    }
}
