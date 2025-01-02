using System;

public interface FabriqueDocuments
{
  Automobile creeAutomobile(string modele, string couleur,
    int puissance, double espace);

  Scooter creeScooter(string modele, string couleur, int
    puissance);
}

