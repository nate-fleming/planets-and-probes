using System;
using System.Collections.Generic;

namespace planets_and_probes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            Dictionary<string, string> probeDestinations = new Dictionary<string, string>()
            {
                {"Mariner 10", "Mercury"},
                {"Messenger", "Mercury"},
                {"Vanera 1", "Venus"},
                {"Mars 1", "Mars"},
                {"Mariner 3", "Mars"},
                {"Voyager 1", "Jupiter"},
                {"Voyager 2", "Jupiter"},
                {"Cassini", "Saturn"}
            };

            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> probe in probeDestinations)
                {
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */
                    if (probe.Value == planet)
                    {
                        matchingProbes.Add(probe.Key);
                    }
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */


                string probes = String.Join(", ", matchingProbes);

                Console.WriteLine($"{planet}: {probes}");
            }

        }
    }
}
