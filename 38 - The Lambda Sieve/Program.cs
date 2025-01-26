Console.WriteLine("Choose wisely:");
Console.WriteLine("1 - Even");
Console.WriteLine("2 - Positive");
Console.WriteLine("3 - Multiple of ten");
int input = Convert.ToInt32(Console.ReadLine());

Sieve sieve = input switch
{
    1 => new Sieve(n => n % 2 == 0),
    2 => new Sieve(n => n >= 0),
    3 => new Sieve(n => n % 10 == 0)
};

while(true)
{
    Console.WriteLine("Type a number");
    int number = Convert.ToInt32(Console.ReadLine());
    if (sieve.IsGood(number) == true)
        Console.WriteLine("That number is good!");
    else
        Console.WriteLine("That number is evil!");
}
 
class Sieve
{
    private Func<int, bool> _function;
    public Sieve(Func<int, bool> function)
    {
        _function = function;
    }

    public bool IsGood(int number)
    {
        return _function(number);
    }
    
}