using System;
namespace OopConcepts
{
    public class Dice
    {
        public int Faces {  get; set; }
        public int Size {  get; set; }
        public string Colour {  get; set; }
        public string Material {  get; set; }
        public static int DiceCount = 0;
        public Dice(int faces, int size, string colour, string material)
        {
            Faces = faces;
            Size = size;
            Colour = colour;
            Material = material;
            DiceCount++;
        }
        public void Throw()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(1, Faces+1));
        }
    }
}