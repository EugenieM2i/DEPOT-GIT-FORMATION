/* ## Objectifs

Appréhender le langage C# dans le cadre de la réalisation d'un programme de base

## Sujet 

Créer une application de type console en C# permettant:

* A un utilisateur de pouvoir choisir entre plusieurs modes de difficultés 
* Le programme va générer une succession de pions de couleurs aléatoire (de 4 à 10 pions en fonction du mode de difficulté)
* Le but pour l'utilisateur est de trouver la succession de pions de couleurs générée par le programme, par exemple `BJJR` pour Bleu, Jaune, Jaune, Rouge.
* Le programme devra compter les tentatives de découvertes de l'utilisateur et l'informer, à chaque tentative, de si il a trouvé: 
    *Un pion faisant partie de l'ensemble des pions, placé au bon emplacement
    * Un pion faisant partie de l'ensemble des pions, mais n'étant pas à la bonne place
    * Un pion faisant ne faisant pas partie de l'ensemble des pions de la chaine de pions
* Le nombre de tentatives pourra être limité via un système de vie, au besoin
*/

        Console.WriteLine("=== JEU DE PIONS DE COULEURS ===");
        Console.WriteLine("Choisissez la difficulté :");
        Console.WriteLine("1 - Facile (4 pions)");
        Console.WriteLine("2 - Moyen (6 pions)");
        Console.WriteLine("3 - Difficile (8 pions)");
        Console.WriteLine("4 - Expert (10 pions)");

        int longueur = 4;
        int vies = 12;
        
        switch (Console.ReadLine())
        {
            case "2": longueur = 6; vies = 10; break;
            case "3": longueur = 8; vies = 8; break;
            case "4": longueur = 10; vies = 6; break;
        }

        char[] couleurs = { 'R', 'B', 'J', 'V', 'N', 'O' };
        Random random = new Random();

        List<char> secret = new List<char>();
        for (int i = 0; i < longueur; i++)
            secret.Add(couleurs[random.Next(couleurs.Length)]);

        Console.WriteLine($"\nCouleurs possibles : R B J V N O");
        Console.WriteLine($"Entrez une combinaison de {longueur} lettres.");

        while (vies > 0)
        {
            Console.Write($"\nTentative ({vies} vies restantes) : ");
            string saisie = Console.ReadLine().ToUpper();

            if (saisie.Length != longueur)
            {
                Console.WriteLine("Mauvaise longueur.");
                continue;
            }

            int bienPlaces = 0;
            int malPlaces = 0;

            List<char> secretTemp = new List<char>(secret);
            bool[] utilises = new bool[longueur];

            // Bien placés
            for (int i = 0; i < longueur; i++)
            {
                if (saisie[i] == secret[i])
                {
                    bienPlaces++;
                    utilises[i] = true;
                    secretTemp[i] = '*';
                }
            }

            // Mal placés
            for (int i = 0; i < longueur; i++)
            {
                if (!utilises[i] && secretTemp.Contains(saisie[i]))
                {
                    malPlaces++;
                    secretTemp[secretTemp.IndexOf(saisie[i])] = '*';
                }
            }

            if (bienPlaces == longueur)
            {
                Console.WriteLine("Bravo ! Vous avez trouvé la combinaison !");
                return;
            }

            Console.WriteLine($"Bien placés : {bienPlaces}");
            Console.WriteLine($"Mal placés : {malPlaces}");
            Console.WriteLine($"Absents : {longueur - bienPlaces - malPlaces}");

            vies--;
        }

        Console.WriteLine("\nVous avez perdu !");
        Console.WriteLine($"La combinaison était : {string.Join("", secret)}");
    

