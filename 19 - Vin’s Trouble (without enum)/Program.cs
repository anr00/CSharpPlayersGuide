Arrow arrow1 = new Arrow(Arrowhead(), Fletching(), Length());
Console.WriteLine("Your arrow:");
Console.WriteLine($"Arrowhead: {arrow1.GetArrowhead()}");
Console.WriteLine($"Fletching: {arrow1.GetFletching()}");
Console.WriteLine($"Shaft's length: {arrow1.GetLength()} cm");
Console.WriteLine($"Price: {arrow1.Price()} golds");


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
    private string _arrowhead;
    private string _fletching;
    private float _length;

    public string GetArrowhead() => _arrowhead;
    public string GetFletching() => _fletching;
    public float GetLength() => _length;
    
    public Arrow(string arrowhead, string fletching, float length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    public float Price()
    {
        float total = 0;
        if (_arrowhead == "Steel") total = 10;
        if (_arrowhead == "Wood") total = 3;
        if (_arrowhead == "Obsidian") total = 10;
        if (_fletching == "Plastic") total = total + 10;
        if (_fletching == "Turkey Feathers") total = total + 5;
        if (_fletching == "Goose Feathers") total = total + 3;

        total = total + (_length * 0.05f);
        return total;
    }
}


  
