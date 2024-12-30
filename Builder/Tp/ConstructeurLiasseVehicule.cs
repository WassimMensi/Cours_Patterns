using System;

public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse;

    public abstract void ConstruitBonDeCommande(string nomClient);
    public abstract void ConstruitDemandeImmatriculation(string nomDemandeur);

    public Liasse Resultat()
    {
        return liasse;
    }
}
