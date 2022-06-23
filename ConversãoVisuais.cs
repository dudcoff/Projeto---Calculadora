public class ConversaoVisuais
{
    public static void QuilometrosParaMilhascontinha()
    {
        double distanciadoQuilometros, distanciaemMilhas;

        Console.WriteLine("--- QUILOMÊTOS PARA MILHAS ---\n");

        Console.Write("Distância em km: ");
        distanciadoQuilometros = Convert.ToDouble(Console.ReadLine());

        distanciaemMilhas = Conversao.KmParaMilhas(distanciadoQuilometros);

        Console.WriteLine($"\nO equivalente em milhas é aproximadamente {distanciaemMilhas} milha(s)");

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();


        return;
    }

    public static void MilhasParaQuilometroscontinha()
    {
        double distanciaemMilhas, distanciadoQuilometros;

        Console.WriteLine("--- MILHAS PARA QUILOMÊTROS ---\n");

        Console.Write("Distância em milha(s): ");
        distanciaemMilhas = Convert.ToDouble(Console.ReadLine());

         distanciadoQuilometros = Conversao.MilhasParaKm(distanciaemMilhas);

        Console.WriteLine($"\nO equivalente em quilômetros é aproximadamente {distanciadoQuilometros} Km");

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();

        return;
    }

}