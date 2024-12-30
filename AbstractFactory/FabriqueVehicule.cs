using System;

public interface FabriqueVehicule
{
  Automobile creeAutomobile(string modele, string couleur,
    int puissance, double espace);

  Scooter creeScooter(string modele, string couleur, int
    puissance);
}
