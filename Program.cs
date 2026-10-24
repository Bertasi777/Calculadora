using System;
using System.Globalization;
class Calculadora
{
    
static void soma()
{
    Console.WriteLine("Digite o primeiro número: ");
    string entrada1 = Console.ReadLine() ?? "0";
    double num1 = double.Parse(
        entrada1.Replace(',', '.'),
        CultureInfo.InvariantCulture
    );

    Console.WriteLine("Digite o segundo número: ");
    string entrada2 = Console.ReadLine() ?? "0";
    double num2 = double.Parse(
        entrada2.Replace(',', '.'),
        CultureInfo.InvariantCulture
    );

    double resultado = num1 + num2;

    Console.WriteLine("O resultado da soma é: " + resultado);
}

static void subtracao()
{
    Console.WriteLine("Digite o primeiro número: ");
    string entrada1 = Console.ReadLine() ?? "0";
    double num1 = double.Parse(
        entrada1.Replace(',', '.'),
        CultureInfo.InvariantCulture
    );

    Console.WriteLine("Digite o segundo número: ");
    string entrada2 = Console.ReadLine() ?? "0";
    double num2 = double.Parse(
        entrada2.Replace(',', '.'),
        CultureInfo.InvariantCulture
    );

    double resultado = num1 - num2;

    Console.WriteLine("O resultado da subtração é: " + resultado);
}

static void multiplicacao()
{
    Console.WriteLine("Digite o primeiro número: ");
    string entrada1 = Console.ReadLine() ?? "0";
    double num1 = double.Parse(
        entrada1.Replace(',', '.'),
        CultureInfo.InvariantCulture
    );

    Console.WriteLine("Digite o segundo número: ");
    string entrada2 = Console.ReadLine() ?? "0";
    double num2 = double.Parse(
        entrada2.Replace(',', '.'),
        CultureInfo.InvariantCulture
    );

    double resultado = num1 * num2;

    Console.WriteLine("O resultado da multiplicação é: " + resultado);
}

static void divisao()
{
    Console.WriteLine("Digite o primeiro número: ");
    string entrada1 = Console.ReadLine() ?? "0";
    double num1 = double.Parse(
        entrada1.Replace(',', '.'),
        CultureInfo.InvariantCulture
    );

    Console.WriteLine("Digite o segundo número: ");
    string entrada2 = Console.ReadLine() ?? "0";
    double num2 = double.Parse(
        entrada2.Replace(',', '.'),
        CultureInfo.InvariantCulture
    );

    if (num2 == 0)
    {
        Console.WriteLine("Erro: Divisão por zero não é permitida.");
        return;
    }

    double resultado = num1 / num2;

    Console.WriteLine("O resultado da divisão é: " + resultado);
}

    static void Main()
    {
        string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU DE ESCOLHAS ===");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                opcao  = Console.ReadLine() ?? "";


        switch (opcao)
        {
            case "1":
                Console.WriteLine("\nVocê selecionou a opção de Somar");
                soma(); // Chama o método de soma
                break;

            case "2":
                Console.WriteLine("\nVocê selecionou a opção de Subtrair");
                subtracao(); // Chama o método de subtração
                break;

            case "3":
                Console.WriteLine("\nVocê selecionou a opção de Multiplicar");
                multiplicacao(); // Chama o método de multiplicação
                break;

            case "4":
                Console.WriteLine("\nVocê selecionou a opção de Dividir");
                divisao(); // Chama o método de divisão
                break;

            case "5":
                Console.WriteLine("\nVocê selecionou a opção de sair do programa");
                break;

            default:
                Console.WriteLine("\nOpção inválida!");
                break;
        }
        if(opcao != "5")
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            } while(opcao != "5");
    }
        }