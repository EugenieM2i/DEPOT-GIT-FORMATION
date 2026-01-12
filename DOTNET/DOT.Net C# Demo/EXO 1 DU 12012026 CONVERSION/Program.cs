using System;
class Program
{

    static void Main()
    {

        bool SaisieValide = false;

        while (!SaisieValide)
        {
            Console.WriteLine("Veuillez saisir un nombre entier please : ");
            string saisie = Console.ReadLine();


            try
            {
                int nombre = int.Parse(saisie);
                SaisieValide = true;
                Console.WriteLine("Vouc avez saisie le nombre :" + nombre);
            }
            catch (FormatException)

            {
                Console.WriteLine("erreur");

            }

            // MAINTENANT BONUS C A D REDEMANDER DE SAISIR TT QUE C'EST PAS BON..... WHILE ?
        }
    }
}
