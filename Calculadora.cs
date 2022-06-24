public class Calculadora
{
    public static void CalcularSoma()
    {
        Console.Clear();
        double x, y, resultado;

        Console.WriteLine("--- SOMA ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("X = ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y = ");
        y = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Soma(x, y);

        Console.WriteLine($"{x} somado com {y} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }
    public static void CalcularSubtracao()
    {
        Console.Clear();
        double x, y, resultado;

        Console.WriteLine("--- SUBTRAÇÃO ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("X = ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y = ");
        y = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Subtracao(x, y);

        Console.WriteLine($"{x} subtraindo {y} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }
    public static void CalcularMultiplicacao()
    {
        Console.Clear();
        double x, y, resultado;

        Console.WriteLine("--- MULTIPLICAÇÃO ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("X = ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y = ");
        y = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Multiplicacao(x, y);

        Console.WriteLine($"{x} multiplicado por {y} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }
    public static void CalcularDivisao()
    {
        Console.Clear();
        double x, y, resultado;

        Console.WriteLine("--- DIVISÃO ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("X = ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y = ");
        y = Convert.ToDouble(Console.ReadLine());

        if (y == 0)
        {
            Console.WriteLine("\nNão é possível dividir por zero.");
        }
        else
        {
            resultado = Aritmetica.Divisao(x, y);

            Console.WriteLine($"{x} dividido por {y} é {resultado}");
        }

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }
    public static void CalcularExponenciaçao()
    {
        Console.Clear();
        double Exponenciação, x, y;

        Console.WriteLine("--- EXPONENCIAÇÃO ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("Base: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Expoente: ");
        y = Convert.ToDouble(Console.ReadLine());

        Exponenciação = Math.Pow(x, y);

        Console.WriteLine($"O resultado é: {Exponenciação}");

        Console.Write("Pressione uma tecla para continuar");
        Console.ReadKey();
    }
    public static void CalcularRadiciaçao()
    {
        Console.Clear();
        double raiz, x;

        Console.WriteLine("--- RADICIAÇÃO ---");
        Console.WriteLine("Digite os valores.");
        Console.Write("Número: ");
        x = Convert.ToDouble(Console.ReadLine());

        raiz = Math.Sqrt(x);

        Console.WriteLine($"O resultado é: {raiz}");

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();
    }
    public static void CalcularBhaskara()
    {
        Console.Clear();
        double a, b, c, delta, x1, x2;

        Console.WriteLine("--- BHASKARA ---");
        Console.Write("Valor a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor c: ");
        c = Convert.ToDouble(Console.ReadLine());

        delta = b * b - 4 * a * c;
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (a <= 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Não é uma equação de segundo grau.");
            Console.ResetColor();
        }

        else if (delta < 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais.");
            Console.ResetColor();
        }

        else
        {
            Console.WriteLine("O resultado é:");
            Console.WriteLine($"x1= {x1:N2} e x2= {x2:N2}");
        }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();
    }
    public static void CalcularMedia()
    {
        Console.Clear();
        decimal a, b, Media;

        Console.WriteLine("--- MÉDIA ---");
        Console.WriteLine("Digite os valores.");

        Console.Write("A: ");
        a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("B: ");
        b = Convert.ToDecimal(Console.ReadLine());

        Media = (a + b) / 2;

        Console.WriteLine($"O resultado é {Media:N1}");

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();

    }
    public static void CalcularConversoes()
    {
        Console.Clear();
        string opçaoDesejada;

        Console.Clear();
        Console.WriteLine("--- CONVERSÃO DE MEDIDA ---\n");
        Console.WriteLine("[01] Quilômetros para milhas");
        Console.WriteLine("[02] Milhas para quilômetros");
        Console.WriteLine("\n[0] Voltar");

        Console.Write("\nEscolha uma opção: ");
        opçaoDesejada = Console.ReadLine()!;

        switch (opçaoDesejada)
        {
            case "1":
                ConversaoVisuais.QuilometrosParaMilhascontinha();
                break;

            case "2":
                ConversaoVisuais.MilhasParaQuilometroscontinha();
                break;
            case "0":
                return;
        }
    }
    public static string ExibeSair()
    {
        Console.Clear();
        string saida;

        Console.WriteLine("Deseja sair do programa?");
        Console.WriteLine("S-Sim || N-Não");
        Console.Write("Escolha uma opção: ");
        saida = Console.ReadLine()!;

        switch (saida.ToUpper())
        {
            case "S":

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nObrigado por usar meu programa!");
                Console.ResetColor();

                return saida;

            case "N" or "n":
                return saida;

                default:
                return "N";
        }
    }
    public static void ExibeMiniintroduçao()
    {
        Console.Clear();
        Console.WriteLine("-- Um pouco sobre mim e o motivo do projeto--\n");

        Console.WriteLine("Me chamo Maria Eduarda, tenho 16 anos e faço curso de Informática, na Etec Adolpho Berezin, estou no 1° Módulo do Ensino Técnico.");

        Console.WriteLine("Este projeto foi realizado com a intenção de por em prática os conteudos explicado pelos professores durante curso!\n");
        Console.WriteLine("Quero parabenizar e agaradecer aos excelentes professores, Ermogenes Palacio e Diego Neri, por serem excelentes profissionas e conseguirem passar adiante seus conhecimentos.");

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();
    }
}