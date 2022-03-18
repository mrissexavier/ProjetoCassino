namespace ProjetoCassino
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ---------------------- MENU ---------------------- */

            Console.WriteLine("Eai, qual teu vulgo?");
            string nome = Console.ReadLine();

            int op = 1;
            while(op != 0)
            {
                Console.Clear();
                Console.WriteLine($"Sinta-se em casa {nome}! (>‿◠)✌");
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
            Random rnd = new Random();
            int num1 = rnd.Next(1, 10);
        }

        private static void RaspadinhaA()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 10);
        }

        private static void Loteria()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 10);
        }
    }
}
