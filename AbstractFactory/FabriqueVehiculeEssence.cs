using System;

public class FabriqueVehiculeEssence : FabriqueVehicule
{
  public Automobile creeAutomobile(string modele, string
    couleur, int puissance, double espace)
  {
    return new AutomobileEssence(modele, couleur,
      puissance, espace);
  }

  public Scooter creeScooter(string modele, string
    couleur, int puissance)
  {
    return new ScooterEssence(modele, couleur, puissance);
  }
}
