using System;

public class LiassePdf : Liasse
{
    public override void Imprime()
    {
        Console.WriteLine("Impression PDF :");
        foreach (var document in documents)
        {
            Console.WriteLine(document);
        }
    }
}
