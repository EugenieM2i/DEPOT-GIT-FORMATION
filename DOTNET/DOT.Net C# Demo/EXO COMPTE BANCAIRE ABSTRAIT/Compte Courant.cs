using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_COMPTE_BANCAIRE_ABSTRAIT
{
   public class Compte_Courant : CompteBancaire

    {
        public decimal decouvertAutorise { get; set; }
        public Compte_Courant (Clients clients, decimal soldeInitial, decimal DecouvertAutorise) : base (clients,soldeInitial)
        {
            decouvertAutorise = DecouvertAutorise;

        }
        public override void Depot(decimal montant)
        {
            if (montant <= 0)
                throw new ArgumentException("Le montant du dépot doit être positif.");

            solde += montant;
            operations.Add(new Operations(montant, "Dépot"));

        }

        public override void Retrait(decimal montant)
        {

            if (montant <= 0)
            throw new ArgumentException("Le montant du retrait doir être positif");

            if (solde - montant < -decouvertAutorise)
                throw new InvalidOperationException("Decouvert dépassé");

            solde -= montant;
            operations.Add(new Operations(montant, "Retrait"));

        }
    }

}
