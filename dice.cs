using System;
namespace OopConcepts
{
    public class Dice : GeometricShape, IObject
    {
        public int Size {  get; set; }
        public string Colour {  get; set; }
        public string Material {  get; set; }
        public static int DiceCount = 0;
        public Dice(string name, int faces, int size, string colour, string material) : base(name, faces)
        {
            Size = size;
            Colour = colour;
            Material = material;
            DiceCount++;
        }
        public Dice() : this("Dice", 6, 3, "white", "plastic") { }
        public Dice(int faces, string colour, string material) : this("Dice", faces, 3, colour, material) { }
        public Dice(int faces) : this("Dice", faces, 3, "white", "plastic") { }
        public void Throw()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(1, Faces+1));
        }
        public void Rotate()
        {
            Console.WriteLine("Rotating Dice");
        }
        public void Fall()
        {
            Console.WriteLine("Dice Falling");
        }
        public override void ShowInfo()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", Name, Faces, Size, Colour, Material);
        }
    }
}