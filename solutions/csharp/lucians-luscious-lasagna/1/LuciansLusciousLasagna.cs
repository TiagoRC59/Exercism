class Lasagna
{

    // 1. Devolve o tempo esperado no forno (40 min)
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // 2. Devolve os minutos restantes no forno
    public int RemainingMinutesInOven(int actualMinutes)
    {
        return ExpectedMinutesInOven() - actualMinutes;
    }

    // 3. Devolve o tempo de preparo baseado no número de camadas (2 min por camada)
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // 4. Devolve o tempo total decorrido (preparo + tempo atual de forno)
    public int ElapsedTimeInMinutes(int layers, int actualMinutes)
    {
        return PreparationTimeInMinutes(layers) + actualMinutes;
    }
}

