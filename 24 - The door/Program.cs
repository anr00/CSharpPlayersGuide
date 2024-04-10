Door door1 = CreateDoor();

while (true)
{
    Console.WriteLine($"The door is {door1.State} What do you want to do? Close, unlock, lock, open or change passcode?");
    string answer = Console.ReadLine();
    if (answer == "close") door1.Close();
    if (answer == "lock") door1.Lock();
    if (answer == "open") door1.Open();
    if (answer == "unlock") door1.Unlock();
    if (answer == "change passcode") door1.NewPass();
}

Door CreateDoor()
{
    Console.WriteLine("Please choose a passcode for your new door");
    int pass = Convert.ToInt32(Console.ReadLine());
    return new Door(pass);
}

public class Door
{
    public DState State { get; private set; }
    public int Passcode;

    public Door(int passcode)
    {
        State = DState.Open;
        Passcode = passcode;
    }

    public void Close()
    {
        if (State == DState.Open) State = DState.Closed;
    }

    public void Open()
    {
        if (State == DState.Closed) State = DState.Open;
    }

    public void Lock()
    {
        if (State == DState.Closed) State = DState.Locked;
    }

    public void Unlock()
    {
        Console.WriteLine("Type the passcode");
        int p = Convert.ToInt32(Console.ReadLine());
        if (State == DState.Locked && p == Passcode ) State = DState.Open;
    }

    public void NewPass()
    {
        Console.WriteLine("Type the current passcode");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type the new passcode");
        int p2 = Convert.ToInt32(Console.ReadLine());
        if (p == Passcode) Passcode = p2;
    }
}

public enum DState { Locked, Open, Closed }

