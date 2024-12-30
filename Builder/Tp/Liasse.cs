using System;
using System.Collections.Generic;

public abstract class Liasse
{
    protected List<string> documents = new List<string>();

    public void AjouteDocument(string document)
    {
        documents.Add(document);
    }

    public abstract void Imprime();
}
