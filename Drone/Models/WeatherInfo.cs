using System;

namespace Drone.Models;

public class WeatherInfo()
{
    
    public class Node<WeatherInfo>(WeatherInfo? data, Node<WeatherInfo>? next = null) 
    {
        public WeatherInfo? Data {get;set;} = data;
        public Node<WeatherInfo>? Next {get;set;} = next;
    }
    
}


