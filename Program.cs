using System;

namespace ProblemaDeCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int numero = 1000000;
            int iteracao = 0;
            //int[] comparador = new int[];

            Console.WriteLine("Problema de Collatz.\n");
            Console.WriteLine("Iniciando análise...\n");
            Console.WriteLine("....\n");

            if (n % 2 == 0)
            {
                n = n / 2;
            }
            else
            {
                n = 3 * n + 1;
            }

            Console.WriteLine("O valor é: " + n);


            /**while
            while ( numero != 1)
            {

                public testePar(int n, int iteracao)
                {

                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }

                    return numero;
                }
                iteracao++;
            }
            //par ou impar
            testePar()

            public testePar(int numero, int iteracao) {

                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    3 * n + 1;
                }

                return numero;
            }
            //ternario
            //numero % 2 == 0 ? numero = numero / 2 : numero = 3 * numero + 1;  
            **/
        }
    }
}
