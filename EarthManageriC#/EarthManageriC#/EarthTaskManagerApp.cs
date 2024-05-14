using System;

public class EarthTaskManagerApp
{
    public static void Main()
    {
        // Create an instance of the Earth class with initial position (0, 0)
        Earth earth = new Earth(0, 0);

        // Update Earth's position
        earth.UpdatePosition(10, 20);

        // Print out Earth's current position
        Console.WriteLine($"Earth's current position: ({earth.PositionX}, {earth.PositionY})");
    }
}
