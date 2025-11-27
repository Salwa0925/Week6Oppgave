using System;
using Drone.Enum;
using Drone.Models;
using Drone.Services;
using System.Threading;

namespace Drone.Services;

public class ThreadFlightService
{
    public void TwoDronesFlying() 
    {
        var drone1 = new DroneModel("DJI_Mini_3", 5, 200 );
        var thread1 = new Thread(drone1.StartFlight);
        thread1.Start();
        thread1.Join();

        var drone2 = new DroneModel("Potensic_Atom_2",7,500);
        var thread2 = new Thread(drone2.StartFlight );
        thread2.Start();
        thread2.Join();

        Console.WriteLine("Succssesfully landed");
    }
}
