class Program
{
    static void Main()
    {
        GenerateurDeMots generateur = new GenerateurDeMots();
        string mot = generateur.Generate();

        Pendu jeu = new Pendu(mot);
        Console.WriteLine("Jeu du pendu!");

        while(!jeu.TestWin() &&! jeu.EstPerdu())
        {

            Console.WriteLine();
            Console.WriteLine("Mot : " + jeu.GetMasque());
            Console.WriteLine("essais restants : " + jeu.GetEssais());
            Console.WriteLine("Propose une lettre : ");

            char lettre = Console.ReadLine().ToLower()[0];
            jeu.TestChar(lettre);
            
        }
        Console.WriteLine();
        {

            if (jeu.TestWin())
            { Console.WriteLine("Bravo!");

        }
            else { Console.WriteLine("Perdu! le mot etait : " + mot);


    }


} // EXO RATER A REFAIRE

