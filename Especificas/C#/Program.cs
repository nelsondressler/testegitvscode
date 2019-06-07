using System;

namespace C_ {
    class Program {
        static void Main (string[] args) {
            int x = 2;
            int y = 3;
            int z = x + y;
            Console.WriteLine (z);
            Console.WriteLine ("Hello World!");
        }

        /// <summary>
        /// Função que calcula o dobro de um valor
        /// </summary>
        /// <param name="a">Valor a ser calculado</param>
        /// <returns>Dobro do valor</returns>
        public int Dobro (int a) {
            return a * 2;
        }
    }
}