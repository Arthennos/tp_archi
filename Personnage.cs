using System;
using System.Collections.Generic;
using System.Text;

namespace Thilgen_Hugo_TPArchi
{
    class Personnage
    {
        private Level level;
        private Action action;

        public Personnage()
        {
            this.level = new Level();
            this.action = new Action();
        }

        public void prendUnCoup()
        {
            action.attaque();
        }

        public void donneUnCoup(Personnage personnage)
        {
            personnage.prendUnCoup();
        }

        public void prendUnSoin()
        {
            action.soigne();
        }

        public void donneUnSoin(Personnage personnage)
        {
            personnage.prendUnSoin();
        }
    }
}
