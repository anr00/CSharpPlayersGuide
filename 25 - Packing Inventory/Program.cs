Pack pequi = new Pack(10, 10, 10);

while (true)
{
    Console.WriteLine($"Number of items: {pequi.CurrentItems}");
    Console.WriteLine($"Weight: {pequi.CurrentWeight}");
    Console.WriteLine("Choose an item");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");
    int answer = Convert.ToInt32(Console.ReadLine());
    InventoryItem newItem = answer switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword()
    };
    
    if (pequi.Add(newItem) == false)
    {
        Console.WriteLine("Can't add item");
    }
}

public class InventoryItem
{
    public double Volume { get; }
    public double Weight { get; }

    public InventoryItem(double volume, double weight)
    {
        Volume = volume;
        Weight = weight;
    }
}

public class Pack
{
    public double VolumeLimit { get; }
    public double WeightLimit { get; }
    public int ItemsLimit { get; }
    public double CurrentVolume { get; private set; }
    public double CurrentWeight { get; private set; }
    public int CurrentItems { get; private set; }
    private InventoryItem[] array;

    public Pack(double volumelimit, double weightlimit, int itemslimit)
    {
        VolumeLimit = volumelimit;
        WeightLimit = weightlimit;
        ItemsLimit = itemslimit;

        array = new InventoryItem[ItemsLimit];
    }

    public bool Add(InventoryItem Item)
    {
        if (CurrentVolume + Item.Volume > VolumeLimit) return false;
        if (CurrentWeight + Item.Weight > WeightLimit) return false;
        if (CurrentItems > ItemsLimit) return false;

        array[CurrentItems] = Item;
        CurrentItems++;
        CurrentVolume += Item.Volume;
        CurrentWeight += Item.Weight;
        return true;
    }

}

public class Arrow : InventoryItem
{
    public Arrow() : base (0.05, 0.1){}
}

public class Bow : InventoryItem
{
    public Bow() : base (4, 1){}
}

public class Rope : InventoryItem
{
    public Rope() : base (1.5, 1){}
}

public class Water : InventoryItem
{
    public Water() : base (3, 2){}
}

public class Food : InventoryItem
{
    public Food() : base (0.5, 1){}
}

public class Sword : InventoryItem
{
    public Sword() : base (3, 5){}
}
