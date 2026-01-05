#region OPERATEURS ARITHMETIQUES



using System.ComponentModel.Design;
using System.Globalization;

int monNombreA = 5;
int monNombreB = 8;

int laSomme = monNombreA + monNombreB;
int laDifference = monNombreA - monNombreB;
int leProduit = monNombreA * monNombreB;
int leQuotient = monNombreA / monNombreB;
int leModulo = 10 % 3; 

Console.WriteLine($"10 / 4 en int = {10 / 4}");
Console.WriteLine($"10 / 4 en double = {10 / 4.0}");



#endregion

#region LES OPERATEURS DE COMPARAISONS

int monNombre = 32;
bool superieurA50 = monNombre > 50;
bool inferieuA50 = monNombre < 50;
bool egalA50 = monNombre == 50;
bool inferieurOuEgalA50 = monNombre <= 50;
bool superieurOuEgalA50 = monNombre >= 50;
bool differentDe50 = monNombre != 50;



#endregion

#region LES OPERATEURS LOGIQUES

bool estMajeur = true;
bool estTitulaireDuPermis = false;

bool GrandGagnant = estMajeur && estTitulaireDuPermis; //ET
bool SoitMajeurSoitPermis = estMajeur || estTitulaireDuPermis; //ou
bool Maxime = estMajeur && !estTitulaireDuPermis;//ET ... NOT



#endregion

#region LES CONDITIONS IF...ELSE IF...ELSE

Console.Write("Votre âge: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 21) Console.WriteLine("Vous êtes majeur");
else Console.WriteLine("Vous êtes mineur loooooser");
else if (age >= 18) Console.WriteLine("Vous êtes majeur en France mais pas aux USA");



#endregion

#region LES SWITCH : ...CASE...BREAK

Console.Write("=== SODAS ===");
Console.WriteLine("1. Coca-cola");
Console.WriteLine("2. Iced Tea");
Console.WriteLine("3. Eau Petillante");
Console.WriteLine("4. Vin chaud");
Console.WriteLine("5. Café frappé");


Console.Write("\nVotre choix. ");
string choixUtilisateur = Console.ReadLine();


double lePrix = choixUtilisateurBis switch
{

    "1" => 10,
    "2" => 4,
    "3" => 3,
    "4" => 2,
    "5" => 1,
    _ => 0.0
};

int laNote = 17;

StringInfo appreciation = laNote switch
{ 
    // >= note => "tres bien ou pas et ceux pour toutes les notes



}

switch (choixUtilisateur)
{
    case "1":
        Console.WriteLine("Vous voulez un coca-cola ! Cela vous coûtera 10 euros");
        break;
    case "2":
        Console.WriteLine("Vous voulez un iced-tea! Cela vous coûtera 4 euros");
        break;
    case "3":
        Console.WriteLine("Vous voulez un Eau pet ! Cela vous coûtera 3 euros");
        break;
    case "4":
        Console.WriteLine("Vous voulez un Vin chaud ! Cela vous coûtera 2 euros");
        break;
    case "5":
        Console.WriteLine("Vous voulez un café frappé ! Cela vous coûtera 1 euros");
        break;
    default:
        Console.WriteLine("Faire un choix existant, debilos");
        break;
}
#endregion

#region TERNAIRE

int nombreEnfants = 5;

string tailleFamille = nombreEnfants > 2 ? "Big Mif" : "Samll mif";

Console.WriteLine($"Votre famille est {(nombreEnfants > 2 ? "big" : "small")}");



#endregion