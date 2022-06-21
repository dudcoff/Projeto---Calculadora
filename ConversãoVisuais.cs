public class ConversaoVisuais
{
    public static void QuilometrosParaMilhascontinha()
    {
        double distanciadoQuilometros, distanciaemMilhas;
        Console.WriteLine("----- QUILOMÊTOS PARA MILHAS -----\n");

        Console.Write("Distância em km: ");
        distanciadoQuilometros = Convert.ToDouble(Console.ReadLine());

        distanciaemMilhas = Conversao.KmParaMilhas(distanciadoQuilometros);

        Console.WriteLine($"\nO equivalente em milhas é aproximadamente {distanciaemMilhas} milha(s)");

        Console.Write("Pressione uma tecla para continuar");
        Console.ReadKey();


        return;
    }

    public static void MilhasParaQuilometroscontinha()
    {
        Console.Clear();

        Console.WriteLine("----- MILHAS PARA QUILOMÊTROS -----\n");

        Console.Write("Distância em milha: ");
        double distanciaMilhas = Convert.ToDouble(Console.ReadLine());

        // double distanciaQuilometros = Conversao.MilhaParaKm(distanciaMilhas);
        double distanciaQuilometros = 2;

        Console.WriteLine($"\nO equivalente em quilômetros é aproximadamente {distanciaQuilometros} Km");

        Console.Write("Pressione uma tecla para continuar");
        Console.ReadKey();

        return;
    }

}