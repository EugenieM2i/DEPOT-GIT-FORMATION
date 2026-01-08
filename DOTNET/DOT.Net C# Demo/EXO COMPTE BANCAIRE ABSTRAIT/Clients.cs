using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_COMPTE_BANCAIRE_ABSTRAIT
{
    public class Clients
    {
        public string Nom {  get; set; }
        public string Prenom {  get; set; }

        public double Identifiant { get; set; }
        public List< CompteBancaire> ListedesComptes { get; set; }

        public string NumeroTel {  get; set; }


        public Clients (string nom, string prenom, double identifiant, string numtel)
        {
            Nom = nom;
            Prenom = prenom;
            Identifiant = identifiant;
            NumeroTel = numtel;

        }







    }
}
