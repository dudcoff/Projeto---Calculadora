public class Conversao
{
    public static double KmParaMilhas(double distanciadoQuilometros)
    {
        return Math.Round(distanciadoQuilometros / 1.609, 3);
    }
    public static double MilhasParaKm(double distanciaemMilhas)
    {
        return Math.Round(distanciaemMilhas * 1.609, 3);
    }
}
