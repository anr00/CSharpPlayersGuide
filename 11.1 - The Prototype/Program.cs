int n1;
do
{
    Console.WriteLine("User 1, please choose a number between 1 and 100.");
    n1 = Convert.ToInt32(Console.ReadLine());
}while(n1 < 0 || n1 > 100);

Console.WriteLine("User 2, guess the number!");

while(true)
{     
    int n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Try again!");
    if (n1 > n2) Console.WriteLine("Too low.");
    else if (n1 < n2) Console.WriteLine("Too high.");
    else break;
}

Console.WriteLine("You've guessed the number! Congrats!");