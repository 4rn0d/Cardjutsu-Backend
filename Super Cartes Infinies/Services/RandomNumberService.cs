namespace Super_Cartes_Infinies.Services;

public class RandomNumberService : IRandomNumberService
{
    private Random _random = new Random();

    public int GetRandomNumber(int nbValue, int offset)
    {
        return _random.Next(nbValue) + offset;
    }
}