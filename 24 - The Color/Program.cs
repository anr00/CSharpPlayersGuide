Color color1 = new Color(0, 233, 15);
Console.WriteLine("Your color properties:");
Console.WriteLine($"Red: {color1.Red}");
Console.WriteLine($"Blue: {color1.Blue}");
Console.WriteLine($"Green: {color1.Green}");

Color black = Color.Black;
Console.WriteLine("Your color properties:");
Console.WriteLine($"Red: {black.Red}");
Console.WriteLine($"Blue: {black.Blue}");
Console.WriteLine($"Green: {black.Green}");

public class Color
{
    public byte Red { get; }
    public byte Blue { get; }
    public byte Green { get; }

    public Color(byte red, byte blue, byte green)
    {
        Red = red;
        Blue = blue;
        Green = green;
    }

    public static Color White = new Color(255, 255, 255);
    public static Color Black = new Color(0, 0, 0);
    public static Color Red_ = new Color(255, 0, 0);
    public static Color Orange = new Color(255, 165, 0);
    public static Color Yellow = new Color(255, 255, 0);
    public static Color Green_ = new Color(0, 128, 0);
    public static Color Blue_ = new Color(0, 0, 255);
    public static Color Purple = new Color(128, 0, 128);
}
