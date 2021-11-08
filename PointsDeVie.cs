using System;
using System.Collections.Generic;
using System.Text;

namespace Thilgen_Hugo_TPArchi
{
    class PointsDeVie
    {
        private int pointsDeVie;

        public PointsDeVie()
        {
            this.pointsDeVie = 1000;
        }

        public void baissePointsDeVie()
        {
            pointsDeVie = pointsDeVie - 100;
            Console.WriteLine("Perte de 100 HP, les HP s'élèvent à " + pointsDeVie);
        }

        public void augmentationPointsDeVie()
        {
            if(pointsDeVie > 0 && pointsDeVie <= 900)
            {
                pointsDeVie += 100;
                Console.WriteLine("Gain de 100 HP, les HP s'élèvent à " + pointsDeVie);
            }
            if (pointsDeVie > 900)
            {
                pointsDeVie = 1000;
                Console.WriteLine("La barre de vie est désormais remplie");
            }
        }

        public void mortPersonnage(Etat etat)
        {
            if(pointsDeVie <= 0)
            {
                etat.mort();
                Console.WriteLine("GAME OVER !");
            }
        }
    }
}
