using System;

public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculePdf()
    {
        liasse = new LiassePdf();
    }

    public override void ConstruitBonDeCommande()
    {
        liasse.AjouteDocument("Bon de commande PDF");
    }

    public override void ConstruitDemandeImmatriculation()
    {
        liasse.AjouteDocument("Demande d'immatriculation PDF");
    }
}
