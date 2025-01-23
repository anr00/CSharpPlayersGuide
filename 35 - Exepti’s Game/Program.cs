
try
{
    List<int> numbers = new List<int>();
    Random r1 = new Random();

    while(true)
    {
        int n1;
        bool tentativa;
        do
        {
            Console.WriteLine("Pick a number");
            n1 = Convert.ToInt32(Console.ReadLine());
            tentativa = numbers.Contains(n1);
            if (tentativa)
                Console.WriteLine("Choose a another number");

        } while (tentativa);
        if (n1 == r1.Next(0 ,9))
            throw new Exception();
        numbers.Add(n1);
    }
}
catch(Exception)
{
    Console.WriteLine("You lost!"); 
}