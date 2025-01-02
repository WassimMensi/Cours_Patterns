using System;

public abstract class ObjetBase
{
    protected ObjetBase suivant;
    protected string descriptionParDéfaut;

    public void SetSuivant(ObjetBase suivant)
    {
        this.suivant = suivant;
    }

    public virtual string GetDescription()
    {
        return descriptionParDéfaut;
    }

    
}