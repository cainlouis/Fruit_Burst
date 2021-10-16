using System;

namespace FruitBurstBackend
{
    //Concrete component for the interface IFruit 
    public class Fruit : IFruit
    {
        //Property that returns a int, represent how much the fruit is worth
        public int Points{get;}

        //Property that returns and sets a boolean, represent the state of the fruit
        public bool IsVisible{get; set;}

        //Field for random object
        private Random random = new Random();

        //Constructor that set IsVisible default to false and give a random number between 1 and 5 to points
        public Fruit() {
            IsVisible = false;
            int rand = random.Next(1, 6);
            Points = rand;
        }

        //Set IsVisible to false
        public void MakeVisible() {
            IsVisible = true;
        }

        //Set IsVisible to false
        public void MakeInvisible() {
            IsVisible = false;
        }

    }
}