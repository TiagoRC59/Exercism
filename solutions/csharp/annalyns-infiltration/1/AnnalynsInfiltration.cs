static class QuestLogic
{
    // 1. Ataque rápido: verdadeiro se o cavaleiro estiver dormindo
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    // 2. Espiar: verdadeiro se pelo menos um dos personagens estiver acordado
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    // 3. Sinalizar prisioneiro: prisioneiro acordado e arqueiro dormindo
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return prisonerIsAwake && !archerIsAwake;
    }

    // 4. Libertar prisioneiro: regras combinadas com cão ou furtividade
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        bool freeWithDog = petDogIsPresent && !archerIsAwake;
        bool freeWithoutDog = prisonerIsAwake && !knightIsAwake && !archerIsAwake;

        return freeWithDog || freeWithoutDog;
    }
}