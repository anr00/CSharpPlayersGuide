CharberryTree tree = new CharberryTree();

Notifier notifier = new Notifier(tree);
Harvest harvest = new Harvest(tree);

while (true)
    tree.MaybeGrow();
public class CharberryTree
{
    private Random _random = new Random();
    public bool Ripe { get; set; }
    public event Action? Ripened; 

    public void MaybeGrow()
    {
        // Only a tiny chance of ripening each time, but we try a lot!
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
            Ripened?.Invoke();
        }
    }
}

public class Notifier
{
    public Notifier(CharberryTree charberryTree)
    {
        charberryTree.Ripened += OnTree;
    }
    private void OnTree()
    {
        Console.WriteLine("Ready");
    }
}

public class Harvest
{
    private int count;
    private CharberryTree charberryTree;
    public Harvest(CharberryTree _charberryTree)
    {
        charberryTree = _charberryTree;
        charberryTree.Ripened += OnTree;
    }
    
    private void OnTree()
    {
        count++;
        charberryTree.Ripe = false;
        Console.WriteLine($"It's been harvested {count} times");
    }
}
