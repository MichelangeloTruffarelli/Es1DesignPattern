using System;
using System.Collections.Generic;
using System.Text;

namespace Es1DesignPattern
{
    public class Riga
    {
        List<Cella> celle = new List<Cella>();

        internal Riga() { }

        public Cella NuovaCella()
        {
            Cella c = new Cella();
            celle.Add(c);
            return c;
        }
    }
}
