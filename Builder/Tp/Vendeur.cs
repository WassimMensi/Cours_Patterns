using System;

public class Vendeur
{
    private ConstructeurLiasseVehicule constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        this.constructeur = constructeur;
    }

    public Liasse Construire()
    {
        constructeur.ConstruitBonDeCommande();
        constructeur.ConstruitDemandeImmatriculation();
        return constructeur.Resultat();
    }
}
