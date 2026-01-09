/* creer un client en premier 
 * PUIS au moins deux comptes bancaires reliés à ce même client 
 * (j'attends un client en entrée de mon constructeur donc il va falloir le renseigner coté compte bancaire 
 * PUIS ajouter les CB créés dans la liste pré faite mais vide stockées en client.
 * 
 */

using EXO_COMPTE_BANCAIRE_ABSTRAIT;

class Program
{
    static void Main(string[] args)
    {
        // creation clientkuy

        Clients client1 = new Clients("Dupont", "Jeanne", 1, "0699312347");


        // creation comptes

        Compte_Courant compte_Courant = new Compte_Courant(client1, 10000, 200);
        CompteEpargne compteEpargne = new CompteEpargne(client1, 30000, 0.02);

        client1.ListedesComptes.Add(compte_Courant);
        client1.ListedesComptes.Add(compteEpargne);

        Console.WriteLine($"La cliente {client1.Nom}, {client1.Prenom} a : {client1.ListedesComptes.ElementAt(1).Solde}");
        /* je dois maintenant lancer une console pour preuve de bon fonctionnement de mon programme. Donc Console. writeline. 
         * Si je renseigne, dans la parenthèse uniquement {client1}, il m'affiche le nom de la classe + namespace. Je dois donc être plus précise : 
         * je note alors {client1.Nom + client1.Prenom .....)
         * ElementAt me permet d'aller chercher un élement particulier choisi à un index en fonction de son propre index (emplacement) dans la liste.
         * */

        client1.ListedesComptes.ElementAt(1).Depot(500);
        client1.ListedesComptes.ElementAt(1).Retrait(100);
        Console.WriteLine($"La cliente {client1.Nom}, {client1.Prenom} a : {client1.ListedesComptes.ElementAt(1).Solde}");

    }




}