using System;

namespace FruitBurstBackend
{
    public class Fruit : IFruit
    {
        public int Points{get;}
        public bool IsVisible{get; set;}

        private Random random = new Random();

        public Fruit() {
            IsVisible = false;
            int rand = random.Next(1, 5);
            Points = rand;
        }

        public void MakeVisible() {
            IsVisible = true;
        }

        public void MakeInvisible() {
            IsVisible = false;
        }

    }
}