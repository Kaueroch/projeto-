using System;
using System.Collections;


while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Calculadora");
    Console.WriteLine("2 - anotações");
    Console.WriteLine("3 - Tarefas");
    Console.WriteLine("0 - Sair");

    Console.Write("Digite o número da operação desejada: ");
    int escolha = Convert.ToInt32(Console.ReadLine());
    if (escolha == 0)
    {
        Console.WriteLine("Saindo! Até mais!!!");
        break;
    }
    NewMethod(escolha);

}

static void NewMethod(int escolha)
{
    switch (escolha)
    {

        case 1:
            Console.WriteLine("Qual dessas operações você quer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int escolhacalc = Convert.ToInt32(Console.ReadLine());

            double n1, n2, resultado = 0;

            switch (escolhacalc)
            {
                case 1:
                    Console.WriteLine("Digite o primeiro número:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    resultado = n1 + n2;
                    Console.WriteLine($"Resultado da Adição: {resultado}");
                    break;

                case 2:
                    Console.WriteLine("Digite o primeiro número:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    resultado = n1 - n2;
                    Console.WriteLine($"Resultado da Subtração: {resultado}");
                    break;

                case 3:
                    Console.WriteLine("Digite o primeiro número:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    resultado = n1 * n2;
                    Console.WriteLine($"Resultado da Multiplicação: {resultado}");
                    break;

                case 4:
                  Console.WriteLine("Digite o primeiro número:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    resultado = n1 / n2;
                    Console.WriteLine($"Resultado da Divisão: {resultado}");
                    break;


                default:
                    Console.WriteLine("Opção inválida dentro da Calculadora");
                    break;

            }
            break;
      case 2:
            Console.WriteLine("Você escolheu anotações!");  

            break;    
    }
    
}



