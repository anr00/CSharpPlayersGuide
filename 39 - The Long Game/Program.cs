Console.WriteLine("Type your name");
string? name = Console.ReadLine();

int score = 0;

if (File.Exists(name))
{
    score = Convert.ToInt32(File.ReadAllText(name));
    Console.WriteLine($"You score is: {score}");
}

while(true)
{
    ConsoleKey key = Console.ReadKey().Key;
    if (key == ConsoleKey.Enter)
        break;
    score++;    
}

File.WriteAllText($"{name}", score.ToString());