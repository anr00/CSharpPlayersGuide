﻿Robot r1 = new Robot();

Console.WriteLine("Type three commands");
Console.WriteLine("on");
Console.WriteLine("off");
Console.WriteLine("north");
Console.WriteLine("south");
Console.WriteLine("west");
Console.WriteLine("east");


while(true)
{
    string? answer = Console.ReadLine();
    if (answer == "stop")
        break;
        
    r1.Commands.Add(answer switch{
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "west" => new WestCommand(),
        "east" => new EastCommand()
    });
}

r1.Run();

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public List<IRobotCommand?> Commands { get; } = new List<IRobotCommand?>();
    public void Run()
    {
        foreach (IRobotCommand? command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
    }
}

public interface IRobotCommand
{
    void Run(Robot robot);
}

public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered == true) robot.Y++;
    }
}

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered == true) robot.Y--;
    }
}

public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered == true) robot.X++;
    }
}

public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered == true) robot.X--;
    }
}