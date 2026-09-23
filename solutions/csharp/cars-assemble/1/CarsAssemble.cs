static class AssemblyLine
{
    public static double SuccessRate(int speed) // Bloco 1: Define a taxa de sucesso usando a estrutura if / else if / else
    {
        if (speed == 0)
        {
            return 0.0;
        }
        else if (speed >= 1 && speed <= 4)
        {
            return 1.0;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else // Velocidade == 10
        {
            return 0.77;
        }
    }
   
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed); // Bloco 2: Calcula a taxa de produção por hora usando a taxa de sucesso
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60); // Bloco 3: Calcula o número de itens funcionais por minuto
    }
}
