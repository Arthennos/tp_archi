using System;
using System.Collections.Generic;
using System.Text;

namespace Thilgen_Hugo_TPArchi
{
    class Etat
    {
        private bool etat;

        public Etat()
        {
            this.etat = true;
        }

        public void mort()
        {
            etat = false;
        }
    }
}
