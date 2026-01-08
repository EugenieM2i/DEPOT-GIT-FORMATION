using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_POO_2_salaires
{
    public class Salaries
    {
        public string? Matricule { get; set; }
        public string? Service { get; set; }
        public string? CategoriePro { get; set; }
        public string? Nom { get; set; }
        public double Salaire { get; set; }

        public Salaries() { }
        public Salaries(string SonMatricule, string SonService, string SaCategoriePro, string SonNom, double SonSalaire)
        {
            Matricule = SonMatricule ;
            Service = SonService ;
            CategoriePro = SaCategoriePro;
            Nom = SonNom;
            Salaire = SonSalaire;

        }

        public void AfficherSalaire()

        {
            Console.WriteLine($"le salaire de {Nom}, matricule {Matricule}, est de {Salaire} euros");

        }
    }
}