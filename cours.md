# Pattern C# 

## Introduction

design pattern = schéma d'objet qui résout un problème récurrent

Ensemble de classes et de relations dans le cadre de la POO

Design pattern => basé sur des bonnes pratiques

## Description des patterns

Le langage UML et C#

Pour chaque pattern :
    - Nom
    - Description
    - Exemple sous forme d'UML
    - Structure générique du pattern
    - Le cas d'utilisation
    - Un exemple de code en C#
    - [lien vers refactoring.guru ](https://refactoring.guru)

# Étude de cas : la vente en ligne de véhicules

Véhicule destiné à la vente en ligne

- Catalogue de véhicules
- Options de véhicules
- Panier / Gestion de Commandes
- Gestion des clients

# Les patterns

Abstract Factory = Construire les objets du domaine (Automobile à essence, électrique, hybride)
Builder, Prototype = Construire les liasses de documents nécéssaires en cas d'acquisition d'un véhicule
Factory Method = Créer des commandes
Singleton = Créer la liasse vierge de documents



```csharp
public class Document
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime Created { get; set; }
}

public class Program {
    public Document CreateDoc(string typeDoc)
    {
        Document doc = null;

        if (typeDoc == "Word")
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
        else if (typeDoc == "Excel")
        {
            doc = new Document();
            doc.Title = "New Excel Document";
            doc.Content = "Excel Content";
        }
        else
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
    }
}
```

Le But du pattern est la création d'objets regroupés par famille sans devoir spécifier la classe concrète de l'objet

# Pattern Builder

## Description

séparer la construction d'un objet complexe de sa représentation

# Singleton

## Description

Pattern qui permet d'assurer qu'une classe n'a qu'une seule instance au cours de l'execution d'un programme et de fournir un point d'accès global à cette instance

Création de nouveaux objets par duplication de l'objet existant
On les appelle prototypes
Capacité de clonage