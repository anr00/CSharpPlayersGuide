public struct Coordinate
{
    public int Row { get; set; }
    public int Column { get; set; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

     public static bool Adjacent(Coordinate a, Coordinate b)
    {
        if (Math.Abs(a.Row - b.Row) <= 1 && a.Column - b.Column == 0) return true;
        if (Math.Abs(a.Column - b.Column) <= 1 && a.Row - b.Row == 0) return true;
        return false;
    }
}

