int number = Range("User 1, type a number between 0 and 100.", 0, 100);
Console.Clear();
Console.WriteLine("User 2, guess the number!");
      
while (true)
{
    int guess = Ask_number("What is your guess? ");
    if (guess > number)
    {
        Console.WriteLine("Too high.");
    }
    else if (guess < number)
    {
        Console.WriteLine("Too low.");
    }
    else
    {
        break;    
    }          
}

Console.WriteLine("You've guessed the number!");

int Ask_number (string text)
{
    Console.WriteLine(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Range (string text, int min, int max)
{
    while (true)
    {
        int number = Ask_number(text);
        if (number >= min && number <= max)
        {
            return number;
        }       
    }
}