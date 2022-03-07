using System;

namespace SpaceSim
{
    public class SpaceObject
    {
        protected String name;

        public SpaceObject(String _name)
        {
            name = _name;
        }

        public virtual void Draw()
        {
            Console.WriteLine(name);
        }
    }
    public class Star : SpaceObject
    {
        public Star(String _name) : base(_name) { }
        public override void Draw()
        {
            Console.Write("Star : ");
            base.Draw();
        }
    }

    public class Planet : SpaceObject
    {
        public Planet(String _name) : base(_name) { }

        public override void Draw()
        {
            Console.Write("Planet : ");
            base.Draw();
        }
    }

    public class Moon : SpaceObject
    {
        public Moon(String _name) : base(_name) { }
        public override void Draw()
        {
            Console.Write("Moon : ");
            base.Draw();
        }
    }

    public class Comet : SpaceObject
    {
        public Comet(String _name) : base(_name) { }
        public override void Draw()
        {
            Console.Write("Comet : ");
            base.Draw();
        }
    }

    public class Asteroid : SpaceObject
    {
        public Asteroid(String _name) : base(_name) { }
        public override void Draw()
        {
            Console.Write("Asteroid : ");
            base.Draw();
        }
    }

    public class DwarfPlanet : SpaceObject
    {
        public DwarfPlanet(String _name) : base(_name) { }
        public override void Draw()
        {
            Console.Write("Dwarf Planet : ");
            base.Draw();
        }
    }
}