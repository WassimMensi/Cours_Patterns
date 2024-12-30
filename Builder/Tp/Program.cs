// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ConstructeurLiasseVehicule constructeur = new ConstructeurLiasseVehiculeHtml();
        Vendeur vendeur = new Vendeur(constructeur);

        ClientVehicule client = new ClientVehicule();
        Liasse liasse = vendeur.Construire();
        liasse.Imprime();