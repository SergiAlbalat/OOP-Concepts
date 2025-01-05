using System;
namespace OopConcepts
{
    public class Program
    {
        public static void Main()
        {
            Dice dice1 = new Dice(6, 3, "blue", "iron");
            Dice dice2 = new Dice(100, 10, "black", "wood");
            Console.WriteLine("Faces: {0}, Diameter: {1}, Colour: {2}, Material: {3}", dice1.Faces, dice1.Size, dice1.Colour, dice1.Material);
            Console.WriteLine("Faces: {0}, Diameter: {1}, Colour: {2}, Material: {3}", dice2.Faces, dice2.Size, dice2.Colour, dice2.Material);
            dice1.Throw();
            dice1.Throw();
            dice2.Throw();
            dice2.Throw();
        }
    }
}