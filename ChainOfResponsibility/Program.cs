using System;

public class Client
{
    public static void Main(string[] args)
    {
        // Création des objets dans la chaîne
        ObjetBase véhicule = new Véhicule();
        ObjetBase modèle = new Modèle();
        ObjetBase marque = new Marque();

        // Configuration de la chaîne
        véhicule.SetSuivant(modèle);
        modèle.SetSuivant(marque);

        // Appel depuis l'utilisateur
        Console.WriteLine(véhicule.DonneDescription());
    }
}
