Card card2 = GetCard();
Console.WriteLine($"The {card2.Color} {card2.Rank}");
Console.WriteLine($"Card type: {card2.Verify()}");

Card GetCard()
{
    Random rnd = new Random();
    Color color = (Color)rnd.Next(4);
    Rank rank = (Rank)rnd.Next(14);
    return new Card(color, rank);
}

public class Card
{
    public Color Color { get; }
    public Rank Rank { get; }

    public Card(Color color, Rank rank)
    {
        Color = color;
        Rank = rank;
    }

    public string Verify()
    {
        if (Rank == Rank.DollarSign || Rank == Rank.Percent || Rank == Rank.Caret || Rank == Rank.Ampersand) return "Symbol Card";
        else return "Number Card";
    }
}

public enum Color { Red, Green, Blue, Yellow }
public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }





 