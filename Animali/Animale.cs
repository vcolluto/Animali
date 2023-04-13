using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali
{
    internal abstract class Animale
    {
        public abstract void faiVerso(int nrVolte);    //metodo astratto => il corpo lo scrivo nelle classi derivate

        public void dormi()
        {
            Console.WriteLine("ZZZZZZ");
        }

    }
}
