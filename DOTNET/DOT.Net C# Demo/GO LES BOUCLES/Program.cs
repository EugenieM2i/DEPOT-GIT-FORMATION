#region LES BOUCLES 

/* tant ... que  = WHILE.

On crée un nombre en amont ex : 5.
    Tant que ce nombre est inférieur à 10, on continue

donc 1) int monNombre = ...
Puis while (monNombre < 10) 
{ 
    console writeline("je continue..");
    monNombre += 1 (ça veut dire mon nombre +1, on peut aussi écrire monnombre++)
}
puis en console wrtiteline, on peut inscrire "Fin de boucle".

TYPE DO... WHILE = c'est faire... tant que
donc DO puis mes accolades PUIS ma condition, c a d mon while.
Le DO fait au moins une fois avant d'évaluer la boucle ! 

La plupart du temps on utilise WHILE sauf si on demande à rentrer un nombre entre 1 et 10, par exemple, pour poser la question au moins un fois et recup le nombre.

*/


#endregion

#region CONTINUE ... BREAK ..


/* "continue" toujours après un IF.
 * if (monMot == "stop") BREEEAAAAKKKK; et ça s'arrête.
 * 

*/

#endregion


#region LES BOUCLES FOR : 2 tyoes : 

/* for (int i = 0; i < 10; i++) Console.Writeline($"La valeur de \"i\" est de {i}");
 * 
 



*/

#endregion
#region FOR EACH
/* 

*/

#endregion


#region NOMBRE ALEATOIRE




int nombreMin = 0;
int nombreMax = 10;

var random = new Random();

var nbAleatoireEntre0et10 = random.Next(nombreMin, nombreMax +1);

#endregion