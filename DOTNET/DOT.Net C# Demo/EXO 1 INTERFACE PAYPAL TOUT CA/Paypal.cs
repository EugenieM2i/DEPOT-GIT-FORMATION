using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_1_INTERFACE_PAYPAL_TOUT_CA
{
    public class Paypal : IPaiement
    {
        public string? AdresseMail { get; set; }
        public string? MotdePasse {  get; set; }

        public Paypal (string adresseMail, string? motdePasse)
        {
            AdresseMail = adresseMail;
            MotdePasse = motdePasse;
        }

        public string EffectuerPaiement(double montant)
        {
         
                if (montant <= 0)
                {
                    return "Echec du paiement : montant invalide.";
                }
                 if (string.IsNullOrEmpty(AdresseMail) && !AdresseMail.Contains("@"))
                {
                    return "Echec du paiement : adresse mail erronée.";
                }
                if (string.IsNullOrEmpty(MotdePasse) && MotdePasse.Length<6)

                {
                    return "Echec du paiement : mot de passe erroné.";
                }

                return $"Paiement de {montant} euros effectué avec succès.";
            }







        }
}
