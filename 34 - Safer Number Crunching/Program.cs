int n;

while(true)
{
    if (int.TryParse(Console.ReadLine(), out n))
        break;
}

double n2;

while(true)
{
    if (double.TryParse(Console.ReadLine(), out n2))
        break;
}

bool boolean;

while(true)
{
    if (bool.TryParse(Console.ReadLine(), out boolean))
        break;
}