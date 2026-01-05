using System.ComponentModel.Design;

Random rnd = new Random();
int nombre = rnd.Next(0, 101); // entre 0 et 100
Console.WriteLine(nombre);

int NiveauFacile = 10;
int NiveauInter = 5;
int NiveauDifficcile = 3;
int NiveauExpert = 1;

Console.WriteLine("quel niveau souhaitez-vous utiliser ?");
string RepUtilisateur = Console.ReadLine();

int leChoix= RepUtilisateur switch
{

    "facile" => 10,
    "intermediaire" => 5,
    "difficile" => 3,
    "expert" => 1,
      _ => 0
};

Console.WriteLine("choisis un nobre entre 0 et 100");



while (leChoix > 0)
{
    
   int sonNombre = Convert.ToInt32(Console.ReadLine());

    if (sonNombre < nombre)
    {
        Console.WriteLine("trop petit");
    }
    else if (sonNombre > nombre)
    {
        Console.WriteLine("trop grand");
    }

    else if (sonNombre == nombre) 
    {
        Console.WriteLine("c'est gagné !");
        break;

    
        }
        

    leChoix --;
if (leChoix == 0) 
{
        Console.WriteLine("c'est perdu!");

        break;
        
    }

    Console.WriteLine("il vous reste" + " "+leChoix +" "+ "vies");
    Console.WriteLine("essaie encore");

}

