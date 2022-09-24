using System.Threading;

namespace cronometro
{
    class Program
    {
        static void Main (string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Quanto tempo?");
            Console.WriteLine("M para minuto /// S para segundo");

            string dados = Console.ReadLine().ToLower();

            int time = int.Parse(dados.Substring(0,dados.Length - 1));

            char type = char.Parse(dados.Substring(dados.Length - 1,1));

            Console.WriteLine(time);
            Console.WriteLine(type);

            int multiplicador = 1;

            if(type == 'm')
            {
                multiplicador = 60;
            }

            if(time == 0)
            {
                System.Environment.Exit(0);
            }

            Start(time * multiplicador);
        }

        static void Start(int tempo)
        {   
            Console.WriteLine("Digite uma contagem");
            int tempoAtual = 0;

            while(tempo != tempoAtual)
            {
                Console.Clear();
                tempoAtual ++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Contagem finalizada");
        }
        
    }
}

