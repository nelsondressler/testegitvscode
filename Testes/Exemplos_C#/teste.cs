using System;
using System.Collections.Generic;

#region HelloWorld
namespace ConsoleApp {
    public class Program {
        public static void Main (string[] args) {
            System.Console.WriteLine ("Hello World!");
        }
    }
}
#endregion

public class Teste {
    public int Mensagem { get; set; }

    public Teste () {
        Mensagem = "Saudações! Meu nome é Nelson J. Dressler, tenho 28 anos e 11 meses de idade. Sou formado em Ciência da Computação pelo Centro Universitário Senac - São Paulo/SP e em Tecnologia da Informação e Comunicação pelo Instituto Superior de Tecnologia em Ciência da Computação de Petrópolis/RJ.";
    }

    public void Testando () {
        Console.WriteLine (Mensagem);

        string nome = "Felipe";
        string numero = 123123;

        // Olá
        /*
            Teste 0oO
        */

        if (nome == numero.ToString ()) {
            Console.WriteLine ("Teste");
            Console.WriteLine ("São iguais!");
        }

        List<int> codigos = new List<int> ();
        codigos.Add (4);
        codigos.Add (5);
    }
}