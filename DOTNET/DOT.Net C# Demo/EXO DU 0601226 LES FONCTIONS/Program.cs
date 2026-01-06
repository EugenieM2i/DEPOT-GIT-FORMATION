using System;

double CalculerValeurStock (double[] prix, int[] quantites)
{

    double ValeurTotaleStock = 0;
    Console.WriteLine("valeur du stock : ");
    for (int i = 0; i < prix.Length; i++)
    {
        double valeurProduit = prix[i] * quantites[i];
        ValeurTotaleStock += valeurProduit;

    }
    return ValeurTotaleStock;



    Console.WriteLine($"La valeur totale du stock est de : {ValeurTotaleStock}  euros.");

}

//demande du nombreproduits entre 5 et 20
int NbProduit;
do
{
    Console.WriteLine("Combien de produits dans votre inventaire entre 5 et 20 merci ?");
}
while (!int.TryParse(Console.ReadLine(), out NbProduit) || NbProduit < 5 || NbProduit > 20);

//tableaux zest parti

string[]NomProduit = new string[NbProduit];
double[]PrixUnit = new double[NbProduit];
int[] quantitéStock = new int[NbProduit];
int[] unitésVendues = new int[NbProduit];

Console.WriteLine();

//saisie noms produits

for (int i = 0; i < NbProduit; i++)
{
    Console.Write($"Nom du produit {i + 1} : ");
    NomProduit[i] = Console.ReadLine();

}

Console.WriteLine();

// saisie infos pour chaque pdt

for (int i = 0; i < NbProduit; i++)
{
    Console.WriteLine ($"--- {NomProduit[i]}");

    //prix unitaire de 0.01 à 10000
    do
    {
        Console.Write("Prix unitaire : ");
    }
    while (!double.TryParse(Console.ReadLine(),out PrixUnit[i])
    && PrixUnit[i] > 0.01
    && PrixUnit[i] < 10000) ;

    // quantites en stock de 0 à 1000
    do
    {
        Console.WriteLine("quantité en stock : ");
    }
    while (!int.TryParse(Console.ReadLine(), out quantitéStock[i])
    && quantitéStock [i] < 0
    && quantitéStock[i] >1000) ;

    // unités vendues ce mois de 0 à 1000
    do
    {
        Console.WriteLine(" Unités vendues ce mois : ");
    }
    while (!int.TryParse(Console.ReadLine(),out unitésVendues[i])
    && unitésVendues [i] < 0
    && unitésVendues[i] > 1000 ) ;

    Console.WriteLine();
}

/* chaise 1 : PrixUnit 10.Quantité stock : 1. unités : 2 
 * chaise 2 : PrixUnit 11.Quantité stock : 2. unités : 4
 * chaise 3 : PrixUnit 12.Quantité stock : 3. unités : 6
 * chaise 4 : PrixUnit 13.Quantité stock : 4. unités : 8
 * chaise 5 : PrixUnit 14.Quantité stock : 5. unités : 10
 * chaise 6 : PrixUnit 15.Quantité stock : 6. unités : 12
*/

// PARTIE 2 : 
/* FONTION 1 = **`double CalculerValeurStock(double[] prix, int[] quantites)`**
   - Calcule la valeur totale du stock (prix × quantité pour chaque produit)
   - Retourne la valeur totale
*/

Console.WriteLine(CalculerValeurStock(PrixUnit,quantitéStock));



