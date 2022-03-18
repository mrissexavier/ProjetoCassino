namespace ProjetoCassino
{
    class Program
    {
        static Random rnd = new Random();
        static string nome = "";
        static int saldo = 100;

        static void Main(string[] args)
        {

            Console.WriteLine("Eai, qual teu vulgo?");
            nome = Console.ReadLine();

            int op = 1;
            while(op != 0)
            {
                Console.Clear();
                Console.WriteLine($"Chega mais {nome}! Seu saldo é de: R${saldo}");
                Console.WriteLine("Escolha uma das seguintes opções:");
                Console.WriteLine("1-Loteria");
                Console.WriteLine("2-Raspadinha");
                Console.WriteLine("3-Carteira");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:                break;
                    case 1: Loteria();     break;
                    case 2: Raspadinhas(); break;
                    case 3: Carteira();    break;
                    default: Console.WriteLine("Ops, opção inválida :p"); 
                        Console.ReadKey(); break;
                }
            }
        }

        private static void Carteira()
        {
            int op = 1;

            while(op != 0)
            {
                Console.Clear();
                Console.WriteLine($"Bem vindo a tua carteira {nome}. Seu saldo atual é: R${saldo}");
                Console.WriteLine("Escolha as seguintes opções:");
                Console.WriteLine("1-Levantamento");
                Console.WriteLine("2-Depósitos");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:                 break;
                    case 1: Levantamento(); break;
                    case 2: Depositos();    break;
                    default: Console.WriteLine("Ops, opção inválida :p");
                        Console.ReadKey();  break;
                }
            }
        }

        private static void Depositos()
        {
            Console.Clear();

            Console.WriteLine("");
        }

        private static void Levantamento()
        {
            throw new NotImplementedException();
        }

        private static void Raspadinhas()
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
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
            Console.Clear();

            int numPrincipal = rnd.Next(1, 10);
            int premio = rnd.Next(1, 100);

            int num1 = rnd.Next(1, 10);
            int num2 = rnd.Next(1, 10);
            int num3 = rnd.Next(1, 10);
            int num4 = rnd.Next(1, 10);
            int num5 = rnd.Next(1, 10);
            int num6 = rnd.Next(1, 10);
            int num7 = rnd.Next(1, 10);
            int num8 = rnd.Next(1, 10);
            int num9 = rnd.Next(1, 10);

            int contador = 0;
            if (numPrincipal == num1) contador++;
            if (numPrincipal == num2) contador++;
            if (numPrincipal == num3) contador++;
            if (numPrincipal == num4) contador++;
            if (numPrincipal == num5) contador++;
            if (numPrincipal == num6) contador++;
            if (numPrincipal == num7) contador++;
            if (numPrincipal == num8) contador++;
            if (numPrincipal == num9) contador++;

            Console.WriteLine($"Número principal: {numPrincipal} (R${premio})");
            Console.WriteLine($"{num1}  {num2}  {num3}");
            Console.WriteLine($"{num4}  {num5}  {num6}");
            Console.WriteLine($"{num7}  {num8}  {num9}");

            if(contador >= 3)
                Console.WriteLine($"Boa mlk, ganhou R${premio}");
            else
                Console.WriteLine("Ops, raspadinha não premiada");
            
            Console.ReadKey();
        }

        private static void RaspadinhaA()
        {
            Console.Clear();    

            int numPrincipal = rnd.Next(1, 10);
            int num1 = rnd.Next(1, 10); int premio1 = rnd.Next(1, 100);
            int num2 = rnd.Next(1, 10); int premio2 = rnd.Next(1, 100);
            int num3 = rnd.Next(1, 10); int premio3 = rnd.Next(1, 100);
            int num4 = rnd.Next(1, 10); int premio4 = rnd.Next(1, 100);
            int num5 = rnd.Next(1, 10); int premio5 = rnd.Next(1, 100);

            Console.WriteLine($"Número principal: {numPrincipal}");
            Console.WriteLine($"1º número: {num1} (R${premio1})");
            Console.WriteLine($"2º número: {num2} (R${premio2})");
            Console.WriteLine($"3º número: {num3} (R${premio3})");
            Console.WriteLine($"4º número: {num4} (R${premio4})");
            Console.WriteLine($"5º número: {num5} (R${premio5})");

            int premio = 0;

            if (num1 == numPrincipal) premio += premio1;
            if (num2 == numPrincipal) premio += premio2;
            if (num3 == numPrincipal) premio += premio3;
            if (num4 == numPrincipal) premio += premio4;
            if (num5 == numPrincipal) premio += premio5;

            Console.WriteLine($"Premio: R${premio}");


            Console.ReadKey();

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
                Console.WriteLine("Chave mlk, ganhou o 1º premio!");
            }
            else if (numPremiado % 1000 == numJogador % 1000)
            {
                Console.WriteLine("Pica pae, ganhou o 2º premio!");

            }
            else if (numPremiado % 100 == numJogador % 100)
            {
                Console.WriteLine("Mlk de ouro, ganhou o 3º premio!");
            }
            else
            {
                Console.WriteLine("Não foi dessa vez, mas não desanima não!");
            }
            Console.ReadKey();
        }
    }
}
