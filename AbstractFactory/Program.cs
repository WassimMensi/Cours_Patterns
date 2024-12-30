// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var nbAutos = 3;
var nbScooters = 2;

FabriqueVehicule fabrique;
Automobile[] autos = new Automobile[nbAutos];
Scooter[] scooters = new Scooter[nbScooters];
Console.WriteLine("Voulez-vous utiliser " +
  "des v�hicules �lectriques (1) ou � essence (2) :");
string choix = Console.ReadLine();
if (choix == "1")
{
  fabrique = new FabriqueVehiculeElectricite();
}
else
{
  fabrique = new FabriqueVehiculeEssence();
}
for (int index = 0; index < nbAutos; index++)
  autos[index] = fabrique.creeAutomobile("standard", 
    "jaune", 6+index, 3.2);
for (int index = 0; index < nbScooters; index++)
  scooters[index] = fabrique.creeScooter("classic", 
    "rouge", 2+index);
foreach (Automobile auto in autos)
  auto.afficheCaracteristiques();
foreach (Scooter scooter in scooters)
  scooter.afficheCaracteristiques();