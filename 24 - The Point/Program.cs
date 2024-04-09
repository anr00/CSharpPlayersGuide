Point origin = new Point(); 
Console.WriteLine($"{origin.PointX}, {origin.PointY}");
Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);
Console.WriteLine($"{point1.PointX}, {point1.PointY}");
Console.WriteLine($"{point2.PointX}, {point2.PointY}");

public class Point
{
	public int PointX { get; }
	public int PointY { get; }
	
	public Point(int pointx, int pointy)
	{
		PointX = pointx;
		PointY = pointy;
	}

    public Point() : this(0,0) { }
}
 
 