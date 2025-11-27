using System;


namespace Drone.Models;

public class DroneModel(string droneName, int maxCheckPoint, int delay)
{
    public string DroneName {get; set;} = droneName;
    public int MaxCheckPoint {get; set;} = maxCheckPoint;
    public int WaitTime {get; set;} = delay;

    public void StartFlight() 
    {
       
        
        Console.WriteLine();
        for (int i = 1; i <= MaxCheckPoint; i++)
        {
            Console.WriteLine($"Drone: {DroneName} reached CheckPoint: {i}"); 
            Thread.Sleep(delay);
        }

    Console.WriteLine($"Drone: {DroneName} finished flight.");

    }

}
