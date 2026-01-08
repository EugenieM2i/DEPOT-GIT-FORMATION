using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_COMPTE_BANCAIRE_ABSTRAIT
{
    public class Operations
    {
        public decimal Montant { get; set; }
        public string Type { get; set; } // depot ou retrait.
        public int Numero { get; set; }

      


        public Operations(decimal montant, string type)
        {
            Montant = montant;
            Type = type;
            Numero = 1;
        }



    }










}
