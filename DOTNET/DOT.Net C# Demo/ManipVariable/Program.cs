#region Creation de variable

internal class Program
{
    private static void Main(string[] args)
    {
        int monNombre = 22;
        short monNombrePetit = 23;
        string monTexte = "Mon texte";
        bool monBooleen = true;

        var monNombreBis = 22;
        var monTexteBis = "je suis un nouveau texte";
        var monBooleenBis = false;
        // Ici on crée des variables et c'est super :
        /* voila voila
         * - Par typage explicite c a d on définit, on nomme la variable avant son nom
         * Pour le sans typage, on écrit dynamic avant mais ce n'est pas recommandé
         *
          */

        Console.WriteLine("La valeur de la variable monNombreBis est : " + monNombreBis + ".");

        const int MON_NOMBRE = 254;
        // readonly String monTexteReadonly : pour créer une variable dont on pourra ensuite renseigner la valeur, celle-ci ne pouvant pas être changé (ex connexion BDD)

        string prenom = "Eugenie";
        string nomDeFamille = "Klinckemaillie";
        int monAge = 33;
        int sonSalaireAnnuel = 57000;

        Console.WriteLine("je m'appelle " + prenom + " " + nomDeFamille + " " + "j'ai " + monAge + "ans" + " et je gagne " + sonSalaireAnnuel + " euros par an.");
        //la concaténation c'est sympa mais si on se loupe sur un + , c'est relou

        /* on peut donc faire :
         */
        Console.WriteLine($"Je m'appelle {prenom} {nomDeFamille}, j'ai {monAge} ans et je touche un salaire annuel de {sonSalaireAnnuel} euros.");

        Console.WriteLine("=== MENU PRINCIPAL ===");
        Console.WriteLine("1. Coca");
        Console.WriteLine("2. Ice Tea");
        Console.WriteLine("\t3. Eau pétillante");


        #endregion

        #region 



        int ageBis = 0;

        string prenomBis = "";

        string nomDeFamilleBis = string.Empty;

        int salaireBis = 0;




        Console.Write("Quel est ton âge ? ");
        string ageEntreParUtilisateurEnTexte = Console.ReadLine();
        int ageConvertiEnNombre = Convert.ToInt32(ageEntreParUtilisateurEnTexte);
        ageBis = ageConvertiEnNombre;



        Console.Write("Quel est ton prénom ? ");
        prenomBis = Console.ReadLine();

        Console.Write("Quel est ton nom de famille ? ");
        nomDeFamilleBis = Console.ReadLine();

        Console.Write(" Quel est ton salaire ? ");
        salaireBis = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Bonjour, tu t'appelles {prenomBis} {nomDeFamilleBis}, tu as {ageBis} ans et tu touches un salaire annuel de {salaireBis} euros.");
    }
}

#endregion

