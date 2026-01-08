using EXO_POO_2_salaires;
Salaries SalarieGeorges = new Salaries("1234", "paie", "comptable", "Martine", 24000);
Salaries SalarieChloe = new Salaries("2345", "rh", "responsable", "chloe", 30000);
Salaries SalarieEmma = new Salaries("7899", "commerce", "adjoint", "emma", 26000);

SalarieGeorges.AfficherSalaire();
SalarieEmma.AfficherSalaire();
SalarieChloe.AfficherSalaire();
Console.WriteLine("/n");