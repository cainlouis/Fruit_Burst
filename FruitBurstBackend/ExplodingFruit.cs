using System;

namespace FruitBurstBackend
{
    public class ExplodingFruit: FruitDecorator
    {
        public ExplodingFruit(IFruit fruit): base(fruit)
        {
        }
        public override int Points{get {return -base.Points;}}

        public override void MakeVisible()  {
            this.Ifruit.IsVisible = true;
        }

        public override void MakeInvisible() {
            this.Ifruit.IsVisible = false;
        }
    }
}