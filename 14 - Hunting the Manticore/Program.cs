int manticore = 10;
int city = 15;
int round = 1;

int range = Range("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
Console.WriteLine("Player 2, it is your turn.");


while (city > 0 && manticore > 0)
{
    int shoot = Input("Enter desired cannon range: ");
    if (shoot == range)
    {
        int damage = Attack(round);
        manticore = manticore - damage;
        Status();
        round ++;
    }
    if (shoot > range)
    {
        Console.WriteLine("That round OVERSHOT the target.");
        city = city -1;
        Status();
        round++;
    } 
    if (shoot < range)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
        city = city - 1;
        Status();
        round++;
    }
    Victory();
}


int Attack(int round)
{
    if (round % 5 == 0 && round % 3 == 0 ) return 10;
    else if (round % 5 == 0) return 3;
    else if (round % 3 == 0) return 3;
    return 1;
}

void Victory()
{
    if (city <= 0) Console.WriteLine("You've lost. The Manticore has destroyed the city");
    if (manticore <= 0) Console.WriteLine("You've won! The Manticore has been destroyed");
}

void Status()
{
    Console.WriteLine($"STATUS: Round: {round} City Life: {city}/15 Manticore Life: {manticore}/10");
}

int Input (string text)

{
    Console.WriteLine(text + " ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int Range(string text, int low, int high)
{
    while (true)
    {
        int n = Input(text);
        if (n >= low && n < high) return n;
    }
}
