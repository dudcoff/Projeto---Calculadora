string opcaoDesejada;

do
{
Console.Clear();

Console.WriteLine("--- Calculadora ---\n");

Console.WriteLine("[1] Soma");
Console.WriteLine("[2] Subtração");
Console.WriteLine("[3] Multiplicação");
Console.WriteLine("[4] Divisão");
Console.WriteLine("[5] Exponenciação");
Console.WriteLine("[6] Radiciação");
Console.WriteLine("[7] Bhaskara");
Console.WriteLine("[8] Média entre números");
Console.WriteLine("[C] Conversão de medida");
Console.WriteLine("[0] Sair");
Console.WriteLine("[+] Sobre");

Console.Write("\nEscolha uma opção: ");

opcaoDesejada = Console.ReadLine()!;

try
{
    switch (opcaoDesejada)
    {
     case "1":
        Calculadora.CalcularSoma();
        break;

    case "2":
        Calculadora.CalcularSubtracao();
        break;

    case "3":
        Calculadora.CalcularMultiplicacao();
        break;

    case "4":
        Calculadora.CalcularDivisao();
        break;

    case "5":
        Calculadora.CalcularExponenciaçao();
        break;

    case "6":
        Calculadora.CalcularRadiciaçao();
        break;

    case "7":
        Calculadora.CalcularBhaskara();
        break;

    case "8":
        Calculadora.CalcularMedia();
        break;

    case "C" or "c":
        Calculadora.CalcularConversoes();
        break;

    case "0":
        string confirmou = Calculadora.ExibeSair();

        if (confirmou == "N" || confirmou == "n")
        {
            opcaoDesejada = "X";
        }
        break;

    case "+":
        Calculadora.ExibeMiniintroduçao();
        break;
        
    default:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Opção inválida.");
        break;
        }
}
 finally
    {
        Console.ResetColor();
    }
}
while (opcaoDesejada != "0");