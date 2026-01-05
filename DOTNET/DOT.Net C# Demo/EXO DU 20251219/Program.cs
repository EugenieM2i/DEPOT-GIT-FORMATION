#region EXO DU 19/12 Petit programme

using System;

Console.Write("Quel est ton prénom ? ");
string prenomUtilisateur = Console.ReadLine();
Console.Write("quel est votre nom ? ");
string nomUtilisateur = Console.ReadLine();

Console.WriteLine($"Bienvenue à vous" + prenomUtilisateur + nomUtilisateur);


Console.Write("Quel est ton âge ? ");
string ageEntreParUtilisateurEnTexte = Console.ReadLine();
int ageConvertiEnNombre = Convert.ToInt32(ageEntreParUtilisateurEnTexte);
int ageBis = ageConvertiEnNombre;
int ardoise = 0;

if (ageBis >= 18) Console.WriteLine("Vous êtes majeur, ok pour continuer");
else Console.WriteLine("Vous êtes mineur loooooser, c'est terminé");
bool var = true; 
while (var)
{
    Console.WriteLine("Veuillez entre STOP pour arrêter la commande");

    


Console.WriteLine("=== MENU ===");
Console.WriteLine("1. Coca-cola 10 euros");
Console.WriteLine("2. Iced Tea 4 euros");
Console.WriteLine("3. Eau Petillante 3 euros");
Console.WriteLine("4. Vin chaud 2 euros");
Console.WriteLine("5. Café frappé 1 euro");


Console.Write("\nVotre choix : ");
string choixUtilisateur = Console.ReadLine();


    int lePrix = choixUtilisateur switch
    {

        "1" => 10,
        "2" => 4,
        "3" => 3,
        "4" => 2,
        "5" => 1,
        _ => 0
    };

    ardoise += lePrix;
 
Console.Write( lePrix + "euros");

    if (choixUtilisateur == "STOP") break;


}
Console.WriteLine("Et n'oubliez pas votre ardoise de : " + ardoise + "euros. Merci et à bientôt !");





#endregion