using oopconcepts;
using System;
namespace OopConcepts
{
    public class Program
    {
        public static void Main()
        {
            Dice dice1 = new Dice("NormalDice", 6, 3, "blue", "iron");
            Dice dice2 = new Dice("SuperDice", 100, 10, "black", "wood");
            dice1.ShowInfo();
            dice2.ShowInfo();
            dice1.Throw();
            dice1.Throw();
            dice2.Throw();
            dice2.Throw();
        }
    }
}