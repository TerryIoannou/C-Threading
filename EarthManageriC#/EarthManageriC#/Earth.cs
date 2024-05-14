using System;

public class Earth
{
    // Properties to store the position of Earth
    public double PositionX { get; private set; }
    public double PositionY { get; private set; }

    // Constructor to initialize Earth's position
    public Earth(double initialPositionX, double initialPositionY)
    {
        PositionX = initialPositionX;
        PositionY = initialPositionY;
    }

    // Method to update Earth's position
    public void UpdatePosition(double newPositionX, double newPositionY)
    {
        PositionX = newPositionX;
        PositionY = newPositionY;
    }
}
