Console.WriteLine("Available items:");
Console.WriteLine("1 – Rope");
Console.WriteLine("2 – Torches");
Console.WriteLine("3 – Climbing Equipment");
Console.WriteLine("4 – Clean Water");
Console.WriteLine("5 – Machete");
Console.WriteLine("6 – Canoe");
Console.WriteLine("7 – Food Supplies"); 

int choice = Convert.ToInt32(Console.ReadLine());  
string anwser = choice switch 
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoes",
    7 => "Food Supplies",
    _ => "Please, enter a valid number"
};
   
decimal price = anwser switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoes" => 200,
    "Food Supplies" => 1,
};

Console.WriteLine("What is your name? ");
string name = Console.ReadLine();

if (name == "anr00")
{
    Console.WriteLine("{0} costs {1}", anwser, price/2);
}
else 
{
    Console.WriteLine("{0} costs {1}", anwser, price);
}


