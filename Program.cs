using System;

namespace primeiropoo
{
    class Program
    {
        static void Main(string[] args)
        {

        Personagem Thanos = new Personagem();
        Thanos.nome = "Thanos";
        Thanos.armadura = "Armadura Thanos";

        Console.WriteLine(Thanos.nome);
        Console.WriteLine(Thanos.Defender() );

        Console.WriteLine(Thanos.Atacar(34.5f, 20f));
        }
    }
}
