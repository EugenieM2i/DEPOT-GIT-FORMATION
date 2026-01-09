using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_1_INTERFACE_PAYPAL_TOUT_CA
{
    public class CarteDeCredit : IPaiement
    {
        public string? NumeroCarte { get; set; }
        public string? TitulaireCarte { get; set; }
        public DateTime DateExpi { get; set; }
        public string? CodeCVV { get; set; }


        public CarteDeCredit( string numeroDeCarte, string titulaireCarte, string codeCVV)
        {
            NumeroCarte = numeroDeCarte;
            TitulaireCarte = titulaireCarte;
            CodeCVV = codeCVV;
         }


        // METHODE A IMPLEMENTER
        public string EffectuerPaiement(double montant)
        {
            if (montant > 0)
            {
                return "Echec du paiement : montant invalide.";
            }
            if (DateExpi < DateTime.Now)
            {
                return "Echec du paiement : carte périmée.";
            }
            if (string.IsNullOrEmpty(CodeCVV) && CodeCVV.Length != 3)
            {
                return "Echec du paiement : code cvv non recevable.";
            }

            return $"Paiement de {montant} euros effectué avec succès.";
        }
    }
}