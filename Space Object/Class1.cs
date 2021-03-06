using System;

namespace SpaceSim
{
    public class SpaceObject
    {
        public String name          { get; set; }
        public int radius           { get; set; }         // Size of object 
        public String color         { get; set; }         // Simple description of objects color
        public int orbital_Radius   { get; set; }         // Circular orbit radius for sake of simplicity
        public int orbital_Period   { get; set; }         // Length of year
        public int rotation         { get; set; }         // Length of day


        public SpaceObject(String _name, int _radius, String _color, int _orbital_Radius, int _orbital_Period, int _rotation)
        {
            name = _name;
            radius = _radius;
            color = _color;
            orbital_Radius = _orbital_Radius;
            orbital_Period = _orbital_Period;
            rotation = _rotation;
        }

        public int position(int time)
        {

            return time * orbital_Period;
        }

        public virtual void Draw()
        {
            Console.Write(name);
            Console.Write(" : " + radius);
            Console.Write(" : " + color);
            Console.Write(" : " + orbital_Radius);
            Console.Write(" : " + orbital_Period);
            Console.WriteLine(" : " + rotation);
        }
    }
    public class Star : SpaceObject
    {
        public Star(String _name, int _radius, String _color, int _orbital_Radius, int _orbital_Period, int _rotation) 
            : base(_name, _radius, _color, _orbital_Radius, _orbital_Period, _rotation) { }
        public override void Draw()
        {
            Console.WriteLine("Star : Radius : Color : Orbital Radius : Oribital Period : Rotation");
            base.Draw();
        }
    }

    public class Planet : SpaceObject
    {
        public Planet(String _name, int _radius, String _color, int _orbital_Radius, int _orbital_Period, int _rotation)
            : base(_name, _radius, _color, _orbital_Radius, _orbital_Period, _rotation) { }
        public override void Draw()
        {
            Console.Write("Planet : ");
            base.Draw();
        }
    }

    public class Moon : SpaceObject
    {
        public Moon(String _name, int _radius, String _color, int _orbital_Radius, int _orbital_Period, int _rotation)
            : base(_name, _radius, _color, _orbital_Radius, _orbital_Period, _rotation) { }
        public override void Draw()
        {
            Console.Write("Moon : ");
            base.Draw();
        }
    }

    public class Comet : SpaceObject
    {
        public Comet(String _name, int _radius, String _color, int _orbital_Radius, int _orbital_Period, int _rotation)
            : base(_name, _radius, _color, _orbital_Radius, _orbital_Period, _rotation) { }
        public override void Draw()
        {
            Console.Write("Comet : ");
            base.Draw();
        }
    }

    public class Asteroid : SpaceObject
    {
        public Asteroid(String _name, int _radius, String _color, int _orbital_Radius, int _orbital_Period, int _rotation)
            : base(_name, _radius, _color, _orbital_Radius, _orbital_Period, _rotation) { }
        public override void Draw()
        {
            Console.Write("Asteroid : ");
            base.Draw();
        }
    }

    public class DwarfPlanet : SpaceObject
    {
        public DwarfPlanet(String _name, int _radius, String _color, int _orbital_Radius, int _orbital_Period, int _rotation)
            : base(_name, _radius, _color, _orbital_Radius, _orbital_Period, _rotation) { }
        public override void Draw()
        {
            Console.Write("Dwarf Planet : ");
            base.Draw();
        }
    }
}