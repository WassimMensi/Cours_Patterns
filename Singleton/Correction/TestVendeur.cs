public class TestVendeur
{
  static void Main(string[] args)
  {
    // initialisation du vendeur du système
    Vendeur leVendeur = Vendeur.Instance();
    leVendeur.nom = "Vendeur Auto";
    leVendeur.adresse = "Paris";
    leVendeur.email = "vendeur@vendeur.com";
    // affichage du vendeur du système
    affiche();
  }

  public static void affiche()
  {
    Vendeur leVendeur = Vendeur.Instance();
    leVendeur.affiche();
  }
}
