Arrow arrow1 = new Arrow(Arrowhead(), Fletching(), Length());
Console.WriteLine("Your arrow:");
Console.WriteLine($"Arrowhead: {arrow1.Arrowhead}");
Console.WriteLine($"Fletching: {arrow1.Fletching}");
Console.WriteLine($"Shaft's length: {arrow1.Length} cm");
Console.WriteLine($"Price: {arrow1.Price} golds");


string Arrowhead()
{
    Console.WriteLine("Choose your arrowhead");
    Console.WriteLine("1 - Steel");
    Console.WriteLine("2 - Wood");
    Console.WriteLine("3 - Obsidian");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer switch
    {
        1 => "Steel",
        2 => "Wood",
        3 => "Obsidian"
    };
} 

string Fletching()
{
    Console.WriteLine("Choose your arrowhead");
    Console.WriteLine("1 - Plastic");
    Console.WriteLine("2 - Turkey feathers");
    Console.WriteLine("3 - Goose feathers");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer switch
    {
        1 => "Plastic",
        2 => "Turkey Feathers",
        3 => "Goose Feathers"
    };
}

float Length()
{
    float length = 0;
    while(length < 60 || length > 100)
    {
        Console.WriteLine("Please choose a shaft between 60 and 100 cm");
        length = Convert.ToSingle(Console.ReadLine());
    }
    return length;
}

class Arrow
{
    public string Arrowhead { get; }
    public string Fletching { get; }
    public float Length { get; }
    
    public Arrow(string arrowhead, string fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public float Price
    {
        get
        {
            float total = 0;
            if (Arrowhead == "Steel") total = 10;
            if (Arrowhead == "Wood") total = 3;
            if (Arrowhead == "Obsidian") total = 10;
            if (Fletching == "Plastic") total = total + 10;
            if (Fletching == "Turkey Feathers") total = total + 5;
            if (Fletching == "Goose Feathers") total = total + 3;

            total = total + (Length * 0.05f);
            return total;
        }
    }
}


  
