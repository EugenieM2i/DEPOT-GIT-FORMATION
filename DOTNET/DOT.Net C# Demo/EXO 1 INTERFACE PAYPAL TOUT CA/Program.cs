using EXO_1_INTERFACE_PAYPAL_TOUT_CA;

IPaiement paiement = new CarteDeCredit("4976559731974546", "Eugenie", "277");


string resultat = paiement.EffectuerPaiement(50);
Console.WriteLine(resultat);

IPaiement paiementPaypal = new Paypal("eugenie@gmail.fr", "secretmotdepasse");

Console.WriteLine(paiementPaypal.EffectuerPaiement(75));
