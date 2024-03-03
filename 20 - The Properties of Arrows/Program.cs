Arrow arrow1 = new Arrow(GetHead(), GetFletch(), Lenght());
Console.WriteLine($"The arrow costs: {arrow1.Cost}");

Fletch GetFletch()
{   
    Console.WriteLine("Please choose a fletching");
    Console.WriteLine("1 - Goose Feathers");
    Console.WriteLine("2 - Turkey Feather");
    Console.WriteLine("3 - Plastic");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer switch
    {
        1 => Fletch.goose_feathers,
        2 => Fletch.turkey_feathers,
        3 => Fletch.plastic
    };
}

Head GetHead()
{
    Console.WriteLine("Please choose an arrowhead");
    Console.WriteLine("1 - Steel");
    Console.WriteLine("2 - Wood");
    Console.WriteLine("3 - Obsidian");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer switch
    {
        1 => Head.steel,
        2 => Head.wood,
        3 => Head.obsidian
    };
}

float Lenght()
{   
    float lenght = 0;
    while (true)
    {
        if (lenght < 60 || lenght > 100)
        {
            Console.WriteLine("Please choose a shaft between 60 to 100 centimeters");
            lenght = Convert.ToSingle(Console.ReadLine());
        }
        else break;
        }return lenght;
}
    
class Arrow 
{
    public Head Head { get; }
    public Fletch Fletch { get; }
    public float Lenght { get; }

    public Arrow(Head head, Fletch fletch, float lenght)
    {
        Head = head;
        Fletch = fletch;
        Lenght = lenght;
    }

    public float Cost
    {
        get
        {
            float headcost = 0;
            float fletchcost = 0;
            if (Head == Head.steel) headcost = 10;
            if (Head == Head.wood) headcost = 3;
            if (Head == Head.obsidian) headcost = 5;
            if (Fletch == Fletch.plastic) fletchcost =+ 10;
            if (Fletch == Fletch.turkey_feathers) fletchcost =+ 5;
            if (Fletch == Fletch.goose_feathers) fletchcost =+ 3;
            float total = headcost + fletchcost + (Lenght * 0.05f);

            return total;
        }
    }
}

enum Head {steel, wood, obsidian}
enum Fletch {goose_feathers, plastic, turkey_feathers}