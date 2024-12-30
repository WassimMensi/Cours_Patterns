using System;

public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculeHtml()
    {
        liasse = new LiasseHtml();
    }

    public override void ConstruitBonDeCommande()
    {
        liasse.AjouteDocument("Bon de commande HTML");
    }

    public override void ConstruitDemandeImmatriculation()
    {
        liasse.AjouteDocument("Demande d'immatriculation HTML");
    }
}
