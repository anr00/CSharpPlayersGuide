using System.Drawing;

Potion potion = Potion.Water;

while(true)
{
    Console.WriteLine($"Your potion {potion}");
    Console.WriteLine("Choose one ingredient");
    Console.WriteLine("1 - Stardust");
    Console.WriteLine("2 - Snake Venom");
    Console.WriteLine("3 - Dragon Breath");
    Console.WriteLine("4 - Shadow Glass");
    Console.WriteLine("5 - Eyeshine Gem");

    Ingredients ingredient = Convert.ToInt32(Console.ReadLine()) switch
    {
        1 => Ingredients.Stardust,
        2 => Ingredients.Snake_Venom,
        3 => Ingredients.Dragon_Breath,
        4 => Ingredients.Shadow_Glass,
        5 => Ingredients.Eyeshine_Gem
    };

    potion = (ingredient, potion) switch
    {
        (Ingredients.Stardust, Potion.Water) => Potion.Elixir,
        (Ingredients.Snake_Venom, Potion.Elixir) => Potion.Poison,
        (Ingredients.Dragon_Breath, Potion.Elixir) => Potion.Flying,
        (Ingredients.Shadow_Glass, Potion.Elixir) => Potion.Invisibility,
        (Ingredients.Eyeshine_Gem, Potion.Elixir) => Potion.Night_Sight,
        (Ingredients.Shadow_Glass, Potion.Night_Sight) => Potion.Cloudy_Brew,
        (Ingredients.Eyeshine_Gem, Potion.Invisibility) => Potion.Cloudy_Brew,
        (Ingredients.Stardust, Potion.Cloudy_Brew) => Potion.Wraith,
        (_, _) => Potion.Ruined
    };
    if (potion == Potion.Ruined)
    {
        Console.WriteLine("Your potion is ruined. Let's start again!");
        potion = Potion.Water;
    }
}


public enum Potion {Water, Elixir, Poison, Flying, Invisibility, Night_Sight, Cloudy_Brew, Wraith, Ruined}
public enum Ingredients {Stardust, Snake_Venom, Dragon_Breath, Shadow_Glass, Eyeshine_Gem}