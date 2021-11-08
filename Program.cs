using System;

namespace Thilgen_Hugo_TPArchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnage leGentilHerosQueToutLeMondeAime = new Personnage();
            Personnage leMonstrePasBeauVraimentPasBeau = new Personnage();

            Console.WriteLine("Vous croisez un monstre sur la route, vous lui donnez un coup\n\nHP du monstre :");
            leGentilHerosQueToutLeMondeAime.donneUnCoup(leMonstrePasBeauVraimentPasBeau);

            Console.WriteLine("\nLe méchant contre-attaque\n\nVos HP :");
            leGentilHerosQueToutLeMondeAime.prendUnCoup();

            Console.WriteLine("\nPuis vous enchaîne\n\nVos HP :");
            leGentilHerosQueToutLeMondeAime.prendUnCoup();

            Console.WriteLine("\nVous devez prendre votre potion de soin\n\nVos HP :");
            leGentilHerosQueToutLeMondeAime.prendUnSoin();

            Console.WriteLine("\nÉtourdit que vous êtes, vous en donnez une au monstre\n\nHP du monstre :");
            leGentilHerosQueToutLeMondeAime.donneUnSoin(leMonstrePasBeauVraimentPasBeau);

            Console.WriteLine("\nDésormais en forme, le monstre vous tabasse à mort\n\nVos HP :");
            leMonstrePasBeauVraimentPasBeau.donneUnCoup(leGentilHerosQueToutLeMondeAime);
            leMonstrePasBeauVraimentPasBeau.donneUnCoup(leGentilHerosQueToutLeMondeAime);
            leMonstrePasBeauVraimentPasBeau.donneUnCoup(leGentilHerosQueToutLeMondeAime);
            leMonstrePasBeauVraimentPasBeau.donneUnCoup(leGentilHerosQueToutLeMondeAime);
            leMonstrePasBeauVraimentPasBeau.donneUnCoup(leGentilHerosQueToutLeMondeAime);
            leMonstrePasBeauVraimentPasBeau.donneUnCoup(leGentilHerosQueToutLeMondeAime);
            leMonstrePasBeauVraimentPasBeau.donneUnCoup(leGentilHerosQueToutLeMondeAime);
            leMonstrePasBeauVraimentPasBeau.donneUnCoup(leGentilHerosQueToutLeMondeAime);
            leMonstrePasBeauVraimentPasBeau.donneUnCoup(leGentilHerosQueToutLeMondeAime);
        }
    }
}
