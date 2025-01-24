Console.WriteLine("Choose wisely:");
Console.WriteLine("1 - Even");
Console.WriteLine("2 - Positive");
Console.WriteLine("3 - Multiple of ten");
int input = Convert.ToInt32(Console.ReadLine());

Sieve sieve = input switch
{
    1 => new Sieve(Even),
    2 => new Sieve(Positive),
    3 => new Sieve(MultipleTen)
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

bool Even(int number)
{
    if (number % 2 == 0)
        return true;
    else
        return false;
}

bool Positive(int number)
{
    if (number >= 0)
        return true;
    else 
        return false;
}

bool MultipleTen(int number)
{
    if (number % 10 == 0)
        return true;
    else 
        return false;
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