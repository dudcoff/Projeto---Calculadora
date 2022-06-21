public class socorro 
{
public static void MilhasParaQuilometroscontinha()
    {
        double distanciadoQuilometros, distanciaemMilhas;
        Console.WriteLine("----- QUILOMÊTOS PARA MILHAS -----\n");

        Console.Write("Distância em km: ");
        distanciadoQuilometros = Convert.ToDouble(Console.ReadLine());

        distanciaemMilhas = Conversao.KmParaMilhas(distanciadoQuilometros);

    
        Console.WriteLine($"\nO equivalente em milhas é aproximadamente {distanciaMilhas} milha(s)");

        return;
    }

    public static void MilhasParaQuilometroscontinha()
    {
        Console.Clear();

        Console.WriteLine("----- MILHAS PARA QUILOMÊTROS -----\n");

        Console.Write("Distância em milha: ");
        double distanciaMilhas = Convert.ToDouble(Console.ReadLine());

        double distanciaQuilometros = Conversao.MilhaParaKm(distanciaMilhas);

        Console.WriteLine($"\nO equivalente em quilômetros é aproximadamente {distanciaQuilometros} Km");

        return;
    }

}