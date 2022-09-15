using System;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}

        static void Main(string[] args)
        {

            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo a Calculadora, selecione uma opção:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        raiz();
                        break;
                    
                    case Menu.Sair:
                        escolheuSair = true;
                        break;                    
                }

                 Console.Clear();

               
            }

            
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());

            int resultado = a + b;
            Console.WriteLine("O Resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }

        static void Subtracao() 
        {
            Console.WriteLine("Subtração de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());

            int resultado = a - b;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }


        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine("digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());

            int resultado = a / b;

            Console.WriteLine("O resultado é: "+ resultado);
            Console.WriteLine("Digite ENTER para voltar ao Menu");
            Console.ReadLine();

        }

        static void Multiplicacao() 
        {
            Console.WriteLine("Multiplicação de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());

            int resultado = a * b;

            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Digite ENTER para voltar ao Menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potência de um número");
            Console.WriteLine("Digite a base:");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            int expoente = int.Parse(Console.ReadLine());

            int resultado = (int)Math.Pow(basenum,expoente);

            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Digite ENTER para voltar ao Menu");
            Console.ReadLine();
        }


        static void raiz()
        {
            Console.WriteLine("Raiz quadrada de um número");
            Console.WriteLine("Digite o número:");
            int a = int.Parse(Console.ReadLine());


            double resultado = Math.Sqrt(a);

            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Digite ENTER para voltar ao Menu");
            Console.ReadLine();
        }



    }


}
