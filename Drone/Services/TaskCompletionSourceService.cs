using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using Drone.Services;
using Drone.Models;
using Figgle;

namespace Drone.Services;

public class TaskCompletionSourceService
{
    public static Task FlyTwoDrones()
    {
        Console.WriteLine("Two drones using TaskCompletionSource to fly");

        var totalTsc = new TaskCompletionSource();

        var drone1 = new DroneModel("MQ-9_Reaper", 5, 110 );
        var drone2 = new DroneModel("RQ-4_Global",7, 250);

        var flight1 = DronesFlyingWithTcs(drone1);
        var flight2 = DronesFlyingWithTcs(drone2);

        Task.WhenAll(flight1, flight2).ContinueWith(allFlights =>
        {
            if (allFlights.IsFaulted)
            {
                totalTsc.SetException(allFlights.Exception);
            }
            else
            {
                Console.WriteLine("All drones successfully completed their journeys");
                totalTsc.SetResult();
            }
        });

        return totalTsc.Task;
    }

    public static Task DronesFlyingWithTcs(DroneModel drone)
    {
        var tcs = new TaskCompletionSource();
        Task.Run(() =>
        {
            try
            {
                Console.WriteLine($"{drone.DroneName} is starting the journey....");
                DroneFlyingWithAwaiter(drone, tcs);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{drone.DroneName} has malfunctioned..");
                tcs.SetException(ex);
            }

        });
        return tcs.Task;
    }

    public static void DroneFlyingWithAwaiter(DroneModel drone, TaskCompletionSource source)
    {
        var currentCheckPoint = 1;

        void CountingFlight()
        {
            try
            {
                
            
                if (currentCheckPoint <= drone.MaxCheckPoint)
                {
                    Console.WriteLine($"{drone.DroneName} has reached checkpoint {currentCheckPoint} of {drone.MaxCheckPoint} checkpoints.");
                    
                    var delayTask = Task.Delay(drone.WaitTime);
                    var awaiter = delayTask.GetAwaiter();
                    
                    awaiter.OnCompleted(() =>
                    {
                     currentCheckPoint++;
                     CountingFlight();

                    });
                }
                else
                {

                    source.SetResult();
                }
            }
            
            catch(Exception ex)
            {
                Console.WriteLine($"{drone.DroneName} encountered an error!");
                source.SetException(ex);
            }
            
        } 
        CountingFlight();   
       
    }
}
