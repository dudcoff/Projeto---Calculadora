public class Calculadora
{
    public static void CalcularSoma()
    {
        double x, y, resultado;

        Console.WriteLine("--- Soma ---\n");
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
        double x, y, resultado;

        Console.WriteLine("--- Subtração ---\n");
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
        double x, y, resultado;

        Console.WriteLine("--- Multiplicação ---\n");
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
        double x, y, resultado;

        Console.WriteLine("--- Divisão ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("X = ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y = ");
        y = Convert.ToDouble(Console.ReadLine());

        if (b == 0)
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
        double Exponenciação, x, y;

        Console.WriteLine("-- EXPONENCIAÇÃO --\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("Base: ");
        x= Convert.ToDouble(Console.ReadLine());
        Console.Write("Expoente: ");
        y= Convert.ToDouble(Console.ReadLine());
                
        Exponenciação= Math.Pow(x, y);

        Console.WriteLine($"O resultado é: {Exponenciação}");

        Console.Write("Pressione uma tecla para continuar");
        Console.ReadKey();
    }
    public static void CalcularRadiciaçao()
    {
        double raiz,x;

        Console.Clear();
        Console.WriteLine("-- RAIZ QUADRADA --");
        Console.WriteLine("Digite os valores.");
        Console.Write("Número: ");
        x = Convert.ToDouble(Console.ReadLine());
                
        raiz = Math.Sqrt(x);

        Console.WriteLine($"O resultado é: {Raiz}");

        Console.Write("Pressione uma tecla para continuar");
        Console.ReadKey();
    }
    public static void CalcularBhaskara()
    {
        string n1,n2,n3;
        double a,b,c,delta,x1,x2;

        Console.WriteLine("-- BHASKARA--");
        Console.Write("Valor a: ");
        n1 = Console.ReadLine();
        a = Convert.ToDouble(n1);

        Console.Write("Valor b: ");
        n2 = Console.ReadLine();
        b = Convert.ToDouble(n2);

        Console.Write("Valor c: ");
        n3 = Console.ReadLine();
        c = Convert.ToDouble(n3);
            
        delta= b*b - 4*a*c;
            x1= (-b + Math.Sqrt(delta)) / (2*a);
            x2= (-b - Math.Sqrt(delta)) / (2*a);
            
        if (A<=0)
        {
            Console.WriteLine("Não é uma equação de segundo grau.");
        }

        else if(delta < 0)
        {
            Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais.");
        }

        else
        {
            Console.WriteLine("O resultado é:");
            Console.WriteLine($"x1= {x1:N2} e x2= {x2:N2}");
        }
        
        Console.Write("Pressione uma tecla para continuar");
        Console.ReadKey();
    }
    public static void CalcularMedia()
    {
        decimal a, b, Media;

        Console.WriteLine("-- MÉDIA --");
        Console.WriteLine("Digite os valores.");

        Console.Write("A: ");
        a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("B: ");
        b = Convert.ToDecimal(Console.ReadLine());

        Media= (a+b) / 2;
            
        Console.WriteLine($"O resultado é {Media:N1}");

        Console.Write("Pressione uma tecla para continuar");
        Console.ReadKey();

    }
    public static void CalcularConversoes()
    {
        string opçaoDesejada;

            Console.Clear();
            Console.WriteLine("----- CONVERSÃO DE MEDIDA -----\n");
            Console.WriteLine("[01] Quilômetros para milhas");
            Console.WriteLine("[02] Milhas para quilômetros");
            Console.WriteLine("\n[0] Voltar");

            Console.Write("\nEscolha uma opção: ");
            opçaoDesejada = Console.ReadLine()!;

                switch (opçaoDesejada)
                {
                    //preciso de ajuda nessa parte
                    case "1":
                        //quilo
                        break;

                    case "2":
                        //milhas
                        break;
            case "0":
            return;
                }
    }
    public static void ExibeSair()
    {
        string saida;
        
        Console.WriteLine("Deseja sair do programa?");
        Console.WriteLine("S-Sim || N-Não");
        Console.Write("Escolha uma opção: ");
        saida = Console.ReadLine()!;
            
        switch (saida.ToUpper())
        {
            case "S":
    
            Console.ForegroundColor = ConsoleCololor.DarkMagenta;
            Console.WriteLine("\nObrigado por usar meu programa!");
            
            return;
            
            case "N":

            ExibeOpções();
            break;
            }
    }
    public static void ExibeMiniintroduçao()
    {
        Console.WriteLine("-- Um pouco sobre mim e o motivo do projeto--");
        Console.WriteLine("Me chamo Maria Eduarda, tenho 16 anos e faço curso de Informática, na Etec Adolpho Berezin, estou no 1° Módulo do Ensino Técnico.");
        Console.WriteLine("Este projeto foi realizado com a intenção de por em prática os conteudos explicado pelos professores durante curso!");
        Console.WriteLine("Quero parabenizar e agaradecer aos excelentes professores, Ermogenes Palacio e Diego Neri, por serem excelentes profissionas e conseguirem passar adiante seus conhecimentos");
    
        Console.Write("Pressione uma tecla para continuar");
        Console.ReadKey();
    }
}