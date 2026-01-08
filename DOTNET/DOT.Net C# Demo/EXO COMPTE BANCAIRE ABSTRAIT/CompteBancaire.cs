using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_COMPTE_BANCAIRE_ABSTRAIT
{

    using System.Collections.Generic;
    public abstract class CompteBancaire
    {


        // alors mes attributs : 


        protected decimal solde;
        protected Clients clients;
        protected List<Operations> operations;

        // constructeur

        protected CompteBancaire(Clients client, decimal soldeInitial)

        {
            this.clients = client;
            solde = soldeInitial;
            operations = new List<Operations>();

        }

        // PROPRIETES

        public decimal Solde => solde;
        public Clients Clients => clients;
        public List<Operations> Operations => operations;

        // METHODES ABSTRAITES

        public abstract void Depot(decimal montant);
        public abstract void Retrait(decimal montant);

    }
}
