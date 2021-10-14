using System;

namespace FruitBurstBackend
{
    public class ExplodingFruit: FruitDecorator
    {
        public ExplodingFruit(IFruit fruit): base(fruit)
        {
        }
        
        public override int Points{get {return -base.Points;}}
        
        public override void MakeVisible()
        {
            Console.Write("exploding fruit");
        }

        public override void MakeInvisible()
        {
            Console.Write("exploding fruit");
        }

    }
}