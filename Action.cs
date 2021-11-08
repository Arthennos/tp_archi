using System;
using System.Collections.Generic;
using System.Text;

namespace Thilgen_Hugo_TPArchi
{
    class Action
    {
        private PointsDeVie pointsDeVie;
        private Etat etat;

        public Action()
        {
            this.pointsDeVie = new PointsDeVie();
            this.etat = new Etat();
        }

        public void attaque()
        {
            pointsDeVie.baissePointsDeVie();
            pointsDeVie.mortPersonnage(etat);
        }

        public void soigne()
        {
            pointsDeVie.augmentationPointsDeVie();
        }
    }
}
