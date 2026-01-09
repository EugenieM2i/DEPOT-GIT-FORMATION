using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_1_INTERFACE_PAYPAL_TOUT_CA
{
    internal interface IPaiement
    {

        string EffectuerPaiement(double montant);
    }
}
