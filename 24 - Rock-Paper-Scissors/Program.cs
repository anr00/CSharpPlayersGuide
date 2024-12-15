while (true)
{
    Game.Battle();
    Game.ShowScore();
} 
 

public class Game
{
    public static Guess Guess;
    public static int Draw;
    public static int Win;
    public static int Loss;
     

    public Game(Guess guess)
    {
        Guess = guess;
    }

    public static void Battle()
    {

        Game g1 = new Game(PlayerGuess());
        Random rnd = new Random();
        Guess guess = (Guess)rnd.Next(3);
        if (Guess == guess) Draw++;
        else if (Guess == Guess.Rock && guess == Guess.Paper) Loss++;
        else if (Guess == Guess.Paper && guess == Guess.Scissor) Loss++;
        else if (Guess == Guess.Scissor && guess == Guess.Rock) Loss++;
        else if (Guess == Guess.Rock && guess == Guess.Scissor) Win++;
        else if (Guess == Guess.Scissor && guess == Guess.Paper) Win++;
        else if (Guess == Guess.Paper && guess == Guess.Rock) Win++;
    }
 
    
    public static void ShowScore()
    {
        System.Console.WriteLine($"Wins: {Win}");
        System.Console.WriteLine($"Losses: {Loss}");
        System.Console.WriteLine($"Draws: {Draw}");
    }

    public static Guess PlayerGuess()
    {
        System.Console.WriteLine("Choose one");
        System.Console.WriteLine("1 - Rock");
        System.Console.WriteLine("2 - Paper");
        System.Console.WriteLine("3 - Scissor");
        int answer = Convert.ToInt32(Console.ReadLine());
        return answer switch
        {
            1 => Guess.Rock,
            2 => Guess.Paper,
            3 => Guess.Scissor
        }; 
    }
}

public enum Guess {Rock, Paper, Scissor}





 