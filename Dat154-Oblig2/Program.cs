using System;
using System.Collections.Generic;
using SpaceSim;

class Astronomy
{
    public static void Main()
    {
        List<SpaceObject> space = new List<SpaceObject>();

        space.Add(new Star("Sun", 5000, "Yellow", 0, 0, 0));
        //space.Add(new Planet("Earth"));
        //space.Add(new Planet("Mars"));
        //space.Add(new Planet("Mercury"));
        //space.Add(new Planet("Venus"));
        //space.Add(new Planet("Jupiter"));
        //space.Add(new Moon("Moon"));

        //space.Add(new Comet("Halley's "));
        //space.Add(new Asteroid("Vesta"));
        //space.Add(new DwarfPlanet("Pluto"));

        foreach (SpaceObject obj in space)
        {
            obj.Draw();
        }
        Console.ReadLine();
    }
}