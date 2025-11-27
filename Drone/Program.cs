using Drone.Enum;
using Drone.Models;
using Drone.Services;
using System.Threading;

namespace Drone;

public class Program
{
    public static void Main(string[] args)
    {
        //Part A
        var service = new ThreadFlightService();
        service.TwoDronesFlying();

        //Part B
        TaskCompletionSourceService.FlyTwoDrones().Wait();

        //Part C
        AsyncFlightService.FlyTwoDronesWithAsync().Wait();  
    }
    
     
}