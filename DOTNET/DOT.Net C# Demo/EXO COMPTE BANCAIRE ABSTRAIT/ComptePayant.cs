using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_COMPTE_BANCAIRE_ABSTRAIT
{
    public class ComptePayant : CompteBancaire
     {
        public decimal FraisOperation { get; set; }
        public ComptePayant(Clients clients, decimal soldeInitial, decimal fraisOperation) : base(clients, soldeInitial)
        {
            FraisOperation = fraisOperation;
        }

        public override void Depot(decimal montant)
        {

            if(montant<=0)
            throw new ArgumentException("Montant invalide.");

            decimal montantNet = montant - FraisOperation;
            if (montantNet < 0)
                throw new InvalidOperationException("Le depot ne couvre pas tes frais.");

            solde += montantNet;
            operations.Add(new Operations(montantNet, "Depot (payant)"));
                                  
        }

        public override void Retrait(decimal montant)
        {

            if (montant<=0)
            throw new ArgumentException("Montant invalide.");

            decimal total = montant + FraisOperation;

            if (solde < total)
                throw new InvalidOperationException("Solde insuffisant.");

            solde -= total;
            operations.Add(new Operations(montant, "Retrait(payant)"));
        }
    }
}
