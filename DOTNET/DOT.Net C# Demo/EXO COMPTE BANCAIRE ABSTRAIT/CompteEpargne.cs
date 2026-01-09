using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_COMPTE_BANCAIRE_ABSTRAIT
{
    public class CompteEpargne : CompteBancaire
    {
        public double TauxInteret {  get; set; }
        public CompteEpargne(Clients clients, decimal soldeInitial, double tauxInteret) : base (clients,soldeInitial)
        {
            TauxInteret = tauxInteret;
         }

        public override void Depot(decimal montant)
        {
            if (montant <=0)
            throw new ArgumentException("Montant invalide.");
            solde += montant;
            operations.Add(new Operations(montant, "Depot"));
        }
        public override void Retrait(decimal montant)
        {
            if(montant<=0)
            throw new ArgumentException("Montant invalide.");

            if (solde < montant)
                throw new InvalidOperationException("Solde insuffisant.");

            solde -= montant;
            operations.Add(new Operations(montant, "Retrait"));
        }

        public void AppliquerInterets()
        {
            decimal interets = solde * (decimal)TauxInteret;
            solde += interets;
            operations.Add(new Operations(interets, "Interets"));


        }
    }
}
