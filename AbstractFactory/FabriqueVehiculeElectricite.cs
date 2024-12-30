using System;

public class FabriqueVehiculeElectricite : FabriqueVehicule
{
  public Automobile creeAutomobile(string modele, string
    couleur, int puissance, double espace)
  {
    return new AutomobileElectricite(modele, couleur,
      puissance, espace);
  }

  public Scooter creeScooter(string modele, string
    couleur, int puissance)
  {
    return new ScooterElectricite(modele, couleur,
      puissance);
  }
}
