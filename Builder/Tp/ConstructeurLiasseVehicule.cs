using System;

public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse;

    public abstract void ConstruitBonDeCommande();
    public abstract void ConstruitDemandeImmatriculation();

    public Liasse Resultat()
    {
        return liasse;
    }
}
