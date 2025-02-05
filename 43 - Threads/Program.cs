RecentNumbers rn = new RecentNumbers();
Thread thread = new Thread(rn.GenerateNumbers);
thread.Start();

while(true)
{
    Console.ReadKey(false);
    if (rn.Number1 == rn.Number2)
        Console.WriteLine("That's a duplicate");
    else
        Console.WriteLine("That's not a duplicate");
}


class RecentNumbers
{
    private int _number1;
    private int _number2;
    private readonly object _numberLock = new object();
    public int Number1 
    {
        get
        {
            lock(_numberLock) 
            {
                return _number1;
            }
        }
    }
    public int Number2
    {
        get
        {
            lock(_numberLock) 
            {
                return _number2;
            }
        }
    }

    Random r1  = new Random();

    public void GenerateNumbers()
    {
        while(true)
        {
            lock(_numberLock)
            {
                _number1 = r1.Next(0, 10);
                _number2 = r1.Next(0, 10);
                Console.WriteLine($"Number 1: {_number1}, Number 2: {_number2}");
            }
            Thread.Sleep(1000);
        }
    }
}