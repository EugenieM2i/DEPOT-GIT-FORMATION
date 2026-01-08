using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_POO_2_salaires
{
    internal class Commercial : Salaries
    {
        public double ChiffreAffaires { get; set; }
        public double CommissionCommerciale { get; set; }


        public Commercial(string SonMatricule, string SonService, string SaCategoriePro, string SonNom, double SonSalaire, double SonCA, double SaCommission) : base (SonMatricule, SonService, SaCategoriePro, SonNom, SonSalaire)
        {

            ChiffreAffaires = SonCA;
            CommissionCommerciale = SaCommission;

        }


        public override void AfficherSalaire()
        {
            double SalaireReel = Salaire + (ChiffreAffaires * CommissionCommerciale) ;
           
            base.AfficherSalaire() ;
            Console.WriteLine($"Et votre salaire commissionné donc réel est : {SalaireReel}");



        }

        public override string ToString()
        {

            double SalaireReel = Salaire + (ChiffreAffaires * CommissionCommerciale);
           return base.ToString() + $"le salaire avec la commission en plus équivaut à : {SalaireReel} euros.";
           
        }

























    }
    


















}
