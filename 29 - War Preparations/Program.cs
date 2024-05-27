
Sword sword = new Sword(Material.Iron, Gemstone.None, 30, 45);
Sword sword1 = sword with {Material = Material.Wood, Width = 50};
Sword sword2 = sword with {Gemstone = Gemstone.Amber, Length = 25};

Console.WriteLine(sword);
Console.WriteLine(sword1);
Console.WriteLine(sword2);

public record Sword(Material Material, Gemstone Gemstone, float Length, float Width);

public enum Material {Wood, Bronze, Iron, Steel, Binarium}

public enum Gemstone {Emerald, Amber, Sapphire, Diamond, Bitstone, None}

