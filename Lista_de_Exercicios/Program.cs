using System;
using System.Threading;
using Lista_de_Exercícios;

namespace Lista_de_Exercícios
{
    public class ContabilizaVotos
    {

        double totalEleitores = 1000;
        double validos = 800;
        double votosBrancos = 150;
        double nulos = 50;

        public double PercVotosValidos()
        {
            Console.WriteLine("Votos Válidos");
            Console.WriteLine("Calculando....");
            Thread.Sleep(2000);

            double votosValidos = (validos / totalEleitores);

            return votosValidos;

        }

        public double PercVotosBrancos()
        {
            Console.WriteLine("Votos em branco");
            Console.WriteLine("Calculando....");
            Thread.Sleep(2000);

            double votosEmBranco = (votosBrancos / totalEleitores);

            return votosEmBranco;

        }

        public double PercVotosNulos()
        {
            Console.WriteLine("Votos Nulos");
            Console.WriteLine("Calculando....");
            Thread.Sleep(2000);

            double votosNulos = (nulos / totalEleitores);

            return votosNulos;

        }
        public static void Main(string[] args)
        {
            var votos = new ContabilizaVotos();
            
            double pVotosValidos = votos.PercVotosValidos();
            Console.WriteLine($"PERCENTUAL DE VOTOS VÁLIDOS: " + pVotosValidos * 100 + "%");
            
            double pVotosBrancos = votos.PercVotosBrancos();
            Console.WriteLine($"PERCENTUAL DE VOTOS VÁLIDOS: " + pVotosBrancos * 100 + "%");
            
            double pVotosNulos = votos.PercVotosNulos();
            Console.WriteLine($"PERCENTUAL DE VOTOS VÁLIDOS: " + pVotosNulos * 100 + "%");


            //Console.WriteLine("Selecione a Opção Desejada");
        }


    }
}
