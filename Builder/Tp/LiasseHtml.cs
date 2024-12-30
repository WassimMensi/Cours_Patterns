using System;

public class LiasseHtml : Liasse
{
    public override void Imprime()
    {
        Console.WriteLine("Impression HTML :");
        foreach (var document in documents)
        {
            Console.WriteLine(document);
        }
    }
}
