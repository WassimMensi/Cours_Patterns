using System;

public class Vendeur
{
    private ConstructeurLiasseVehicule constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        this.constructeur = constructeur;
    }

    public Liasse Construire(string nomClient)
    {
        constructeur.ConstruitBonDeCommande(string nomClient);
        constructeur.ConstruitDemandeImmatriculation(string nomClient);
        return constructeur.Resultat();
    }
}
