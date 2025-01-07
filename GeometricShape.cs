using System;
namespace OopConcepts
{
    public abstract class GeometricShape
    {
        protected string Name { get; set; }
        protected int Faces { get; set; }
        public GeometricShape(string name, int faces)
        {
            Name = name;
            Faces = faces;
        }
        public abstract void ShowInfo();
    }
    
}