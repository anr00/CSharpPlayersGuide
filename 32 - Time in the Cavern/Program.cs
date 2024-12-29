DateTime inicio = DateTime.Now;
Fountain f1 = new Fountain();
f1.Run();
DateTime final = DateTime.Now;

System.Console.WriteLine($"Tempo gasto: {final - inicio}");

public class Fountain
{
    public Player Player { get; }
    public Map Map { get; }
    public Fountain()
    {
        Player = new Player();
        Map = new Map();
    }
    public void Run()
    {
        Input input = new Input();
        while(!HasWon())
        {
            Write();
            IAction action = input.ChooseAction();
            action.Execute(this);
        }
        Console.WriteLine("You've won!");
    }

    private bool HasWon()
    {
        Room playerRoom = Map.GetRoom(Player.Location);
        if (!(playerRoom is EntranceRoom)) 
            return false;
        for (int row = 0; row < Map.Rows; row++)
        {
            for (int column = 0; column < Map.Columns; column++)
            {
                if (Map.GetRoom(row, column) is FountainRoom fountainRoom)
                {
                    if (fountainRoom.IsOff)
                        return false;
                }
            }
        }
        return true; 
    }

    public void Write()
    {
        Console.WriteLine($"{Player.Location.Row}, {Player.Location.Column}");
    }
}
 
public interface IAction
{
    void Execute(Fountain game);
}

public class MoveAction : IAction
{
    private readonly Direction Direction;
    public MoveAction(Direction direction)
    {
        Direction = direction;
    }

    public void Execute(Fountain game)
    {
        Location current = game.Player.Location;
        Location next = GetLocation(current, Direction);
        if (game.Map.IsOnMap(next))
            game.Player.Location = next;
        else
            Console.WriteLine("You can't. Stop it!");
    }

    private Location GetLocation(Location start, Direction directionMove)
    {
        return directionMove switch
        {
            Direction.North => new Location(start.Row - 1, start.Column),
            Direction.South => new Location(start.Row + 1, start.Column),
            Direction.East => new Location(start.Row, start.Column + 1),
            Direction.West => new Location(start.Row, start.Column - 1),
        };
    }

}

public class EnableFountain : IAction
{
    public void Execute(Fountain game)
    {
        Location playerLocation = game.Player.Location;
        Room playerRoom = game.Map.GetRoom(playerLocation);
        FountainRoom? fountainRoom = playerRoom as FountainRoom;
        if (fountainRoom == null)
        {
            Console.WriteLine("You can't");
            return;
        }
        fountainRoom.IsOn = true;
    }
}

public class Input
{
    public IAction ChooseAction()
    {
        do
        {
            Console.WriteLine("What do you want to do?");
            string? input = Console.ReadLine();
            IAction? chosenAction = input switch
            {
                "north" => new MoveAction(Direction.North),
                "south" => new MoveAction(Direction.South),
                "east" => new MoveAction(Direction.East),
                "west" => new MoveAction(Direction.West),
                "enable" => new EnableFountain(),
                _ => null
            };

            if (chosenAction != null)
                return chosenAction;
            else 
                Console.WriteLine("Don't do that");
        }
        while(true);
    }
}

public class Player
{
    public Location Location { get; set; } = new Location(0, 0);
}

public record Location(int Row, int Column);

public class Map
{
    private readonly Room[,] _rooms;
    public int Rows => 4;
    public int Columns => 4;
    
    public bool IsOnMap(Location location)
    {
        if (location.Row < 0) return false;
        if (location.Row >= Rows) return false;
        if (location.Column < 0) return false;
        if (location.Column >= Rows) return false;
        return true;
    }

    public Map()
    {
        _rooms = new Room[Rows, Columns];
        for (int row = 0; Rows < 4; row++)
        {
            for (int column = 0; Columns < 4; column++)
            {
                _rooms[row, column] = new EmptyRoom();
            }
        }
        _rooms[0, 0] = new EntranceRoom();
        _rooms[0, 2] = new FountainRoom(); 
    }

    public Room GetRoom(int row, int column)
    {
        return _rooms[row, column];
    }
    public Room GetRoom(Location location)
    {
        return _rooms[location.Row, location.Column];
    }
}

public abstract class Room {}
public class EmptyRoom : Room {}
public class EntranceRoom : Room {}
public class FountainRoom : Room
{
    public bool IsOn { get; set; }
    public bool IsOff => !IsOn;
}

public enum Direction {North, South, East, West}