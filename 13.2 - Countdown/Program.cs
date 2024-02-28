Counter(10);
 
void Counter(int n) 
{
    if (n > 0)
    {
        Console.WriteLine(n);
        Counter(n - 1);
    }
}

 
