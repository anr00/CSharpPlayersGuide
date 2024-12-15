// 1:13:48
Board b1 = new Board();
Player p1 = new Player(TypeCell.X);
Player p2 = new Player(TypeCell.O);
Game g1 = new Game(p1, p2, b1);
g1.Run();
 

public class Game
{
    private readonly Board _board;
    private readonly Player _p1;
    private readonly Player _p2;

    public Game(Player p1, Player p2, Board board)
    {
        _p1 = p1;
        _p2 = p2;
        _board = board;
    }
    public void Run()
    {
        Player current = _p1;
        while (!IsGameOver())
        {
            _board.Table();
            Location location = current.PickLocation(_board);
            _board.SetCell(location.Row, location.Column, current.TypeCell);
            current = current == _p1 ? _p2 : _p1;
        }
    }

    private bool IsGameOver()
    {
        if (HasWon(_board, TypeCell.X)) return true;
        if (HasWon(_board, TypeCell.O)) return true;
        if (IsDraw(_board)) return true;
        return false;
    }
    private bool IsDraw(Board board)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                if(board.GetCell(row, column) == TypeCell.Empty) return false;
            }
        }
        return false;
    }
    private bool HasWon(Board board, TypeCell typecell)
    { 
        if (Equals(typecell, board.GetCell(0,0), board.GetCell(0,1), board.GetCell(0,2))) return true;
        if (Equals(typecell, board.GetCell(1,0), board.GetCell(1,1), board.GetCell(1,2))) return true;
        if (Equals(typecell, board.GetCell(2,0), board.GetCell(2,1), board.GetCell(2,2))) return true;
        if (Equals(typecell, board.GetCell(0,0), board.GetCell(1,0), board.GetCell(2,0))) return true;
        if (Equals(typecell, board.GetCell(0,1), board.GetCell(1,1), board.GetCell(2,1))) return true;
        if (Equals(typecell, board.GetCell(0,2), board.GetCell(1,2), board.GetCell(2,2))) return true;
        if (Equals(typecell, board.GetCell(0,0), board.GetCell(1,1), board.GetCell(2,2))) return true;
        if (Equals(typecell, board.GetCell(0,2), board.GetCell(1,1), board.GetCell(2,0))) return true;
        return false;
    }
    private bool Equals(TypeCell a, TypeCell b, TypeCell c, TypeCell d)
    {
        if (a == b && a == c && a == d) 
            return true;
        return false;
    }
}

public class Board
{
    private readonly TypeCell[,] cells = new TypeCell [3,3];
    public TypeCell GetCell(int row, int column)
    {
        return cells[row, column];
    }
    public bool SetCell(int row, int column, TypeCell typecell)
    {
        if (cells[row, column] == TypeCell.Empty)
        {
            cells[row, column] = typecell;
            return true;
        }
        else return false;
    }
    public bool IsOcuppied(Location location)
    {
        return cells[location.Row, location.Column] != TypeCell.Empty;
    }
    public void Table()
    {
        Console.WriteLine($" {ToChar(cells[0,0])} | {ToChar(cells[0,1])} | {ToChar(cells[0,2])}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {ToChar(cells[1,0])} | {ToChar(cells[1,1])} | {ToChar(cells[1,2])}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {ToChar(cells[2,0])} | {ToChar(cells[2,1])} | {ToChar(cells[2,2])}");
    }
    private char ToChar(TypeCell typecell)
    {
        return typecell switch
        {
            TypeCell.Empty => ' ',
            TypeCell.O => 'O',
            TypeCell.X => 'X',
            _ => '?'
        };
    }
}

public class Location
{
    public int Row { get; }
    public int Column { get; }
    public Location(int row, int column )
    {
        Row = row;
        Column = column;
    }
}

public class Player
{
    public TypeCell TypeCell { get; }
    public Player(TypeCell typecell)
    {
        TypeCell = typecell;
    }

    public Location PickLocation(Board board)
    {
        while (true)
        {
            int locationInput = Convert.ToInt32(Console.ReadLine());
            Location l1 = locationInput switch
            {
                1 => new Location(0,0),
                2 => new Location(0,1),
                3 => new Location(0,2),
                4 => new Location(1,0),
                5 => new Location(1,1),
                6 => new Location(1,2),
                7 => new Location(2,0),
                8 => new Location(2,1),
                9 => new Location(2,2),
            };
            if (!board.IsOcuppied(l1)) return l1;
            else    
                Console.WriteLine("Space taken");
        }
    }
}

public enum TypeCell {Empty, X, O}