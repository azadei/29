using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        List<string> cities = new List<string>
        {
            "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI",
            "AMSTERDAM", "ABU DHABI", "PARIS", "NEW YORK"
        };

       
        var groupedCities = cities.Select((value, index) => new { Value = value, Index = index })
                                  .GroupBy(item => item.Index / 3)
                                  .Select(group => string.Join("; ", group.Select(item => item.Value)));

        
        Console.WriteLine("Here is the group of cities:");
        foreach (var group in groupedCities)
        {
            Console.WriteLine(group);
            Console.WriteLine("-- here is a group of cities --");
        }

    }
}