namespace ProjetoCassino
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            /* ---------------------- MENU ---------------------- */

            Console.WriteLine("Eai, qual teu vulgo?");
            string nome = Console.ReadLine();

            int op = 1;
            while(op != 0)
            {
                Console.Clear();
                Console.WriteLine($"Chega mais {nome}!");
                Console.WriteLine("Escolha uma das seguintes opções:");
                Console.WriteLine("1-Loteria");
                Console.WriteLine("2-Raspadinha");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:                break;
                    case 1: Loteria();     break;
                    case 2: Raspadinhas(); break;
                    default: Console.WriteLine("Ops, opção inválida :p"); 
                        Console.ReadKey(); break;
                }
            }
        }

        private static void Raspadinhas()
        {
            int op = 1;
            while (op != 0)
            {
                Console.WriteLine("Menu Raspadinhas");
                Console.WriteLine("1-Raspadinha A");
                Console.WriteLine("2-Raspadinha B");
                Console.WriteLine("0-Voltar ao menu principal");
                op = int.Parse(Console.ReadLine());

                if (op == 0)
                {
                    break;
                }
                else if (op == 1)
                {
                    RaspadinhaA();
                }
                else if (op == 2)
                {
                    RaspadinhaB();
                }   
                else
                {
                    Console.WriteLine("Ops, opção inválida :p");
                    Console.ReadKey();
                }
            }
        }

        private static void RaspadinhaB()
        {
        }

        private static void RaspadinhaA()
        {
        }

        private static void Loteria()
        {
            Console.Clear();
            int numPremiado = rnd.Next(1000, 10000);
            int numJogador = 0;

            while(numJogador < 1000 || numJogador > 9999)
            {
                Console.WriteLine("Qual o número da vez? (1.000-9.999");
                numJogador = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Bilhete premiado: {numPremiado}");

            if (numPremiado == numJogador)
            {
                Console.WriteLine("Chave mlk, ganhou o 1º prémio!");
            }
            else if (numPremiado % 1000 == numJogador % 1000)
            {
                Console.WriteLine("Pica pae, ganhou o 2º prémio!");

            }
            else if (numPremiado % 100 == numJogador % 100)
            {
                Console.WriteLine("Mlk de ouro, ganhou o 3º prémio!");
            }
            else
            {
                Console.WriteLine("Não foi dessa vez, mas não desanima não!");
            }
            Console.ReadKey();
        }
    }
}
