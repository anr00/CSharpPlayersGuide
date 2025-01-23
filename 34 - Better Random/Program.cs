public static class RandomExtensions
{
    public static double DoubleRandom(this Random r1)
    {
        return r1.NextDouble() * 100;
    }

    public static string RandomArrow(this Random r1, params string[] arrows)
    {
        return arrows[r1.Next(arrows.Length)];
    }
    public static bool CoinRandon(this Random r1)
    {
        return r1.NextDouble() < r1.NextDouble();
    }
}