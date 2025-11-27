using System;
using Drone.Models;

namespace Drone.Services;

public class AsyncFlightService
{
    public static async Task FlyTwoDronesWithAsync()
    {
        Console.WriteLine("Starting drone journey");
        var drone1 = new DroneModel("DJI _Air_Series", 20, 200);
        var drone2 = new DroneModel("DJI_Avata_Series", 50, 400);

        var flight1 = DronesFlyingWithAsync(drone1);
        var flight2 = DronesFlyingWithAsync(drone2);

        await Task.WhenAll (flight1, flight2);
        Console.WriteLine("All drones successfully completed their journeys");
    }

    public static async Task DronesFlyingWithAsync(DroneModel drone)
    {
        Console.WriteLine($"{drone.DroneName} activated!");

        for (int i = 1; i <= drone.MaxCheckPoint ; i++)
        {
            await Task.Delay(drone.WaitTime);
            Console.WriteLine($"Drone: {drone.DroneName} reached CheckPoint: {i} of {drone.MaxCheckPoint}"); 
        }
        Console.WriteLine($"{drone.DroneName} has reached its destination");
    }
}
