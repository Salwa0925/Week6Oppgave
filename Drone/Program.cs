using Drone.Enum;
using Drone.Models;
using Drone.Services;
using System.Diagnostics;
using System.Threading;

namespace Drone;

public class Program
{
    public static void Main(string[] args)
    {
        string input;
        do
        {


            //Console.Clear();
            Console.WriteLine("Async Drone Dash Simulator");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("A: Two Drones with Threads");
            Console.WriteLine("B: Two Drones with TaskCompletionSource");
            Console.WriteLine("C: Two Drones with async/await");
            Console.WriteLine("E: Exit");
            Console.Write("Your choice: "); 

            input = Console.ReadLine().ToUpper();


            switch(input)
            {
                case "A": RunPartA();
                break;

                case "B": RunPartB();
                break;

                case "C": RunPartC();
                break;
                                    
                                    
                case "E":
                    Console.WriteLine("Exiting program...");
                return;

                default:

                    Console.WriteLine("Invalid choice. Try again.");
                break;
            }    


        }
        while (input != "E");


    }        
    public static void RunPartA()
    {
        //Part A
        var service = new ThreadFlightService();
        service.TwoDronesFlying();        
    }

    public static void RunPartB()
    {
        //Part B
        TaskCompletionSourceService.FlyTwoDrones().Wait();        
    }

    public static void RunPartC()
    {
        //Part C
        AsyncFlightService.FlyTwoDronesWithAsync().Wait();          
    } 

}