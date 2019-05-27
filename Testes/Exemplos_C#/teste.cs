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
    public Teste () {

    }
    public void Testando () {
        Console.WriteLine ("Eu sou um teste");

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