using System;

namespace FruitBurstBackend
{
    //Concrete component of the decorator pattern, implement the FruitDecorator
    public class ExplodingFruit: FruitDecorator
    {
        //Parameterized constructor, implement the FruitDecorator constructor
        public ExplodingFruit(IFruit fruit): base(fruit)
        {
        }

        //Property that returns the negative value of the Fruit the constructor gets as input
        public override int Points{get {return -base.Points;}}

        //Set IsVisible to true
        public override void MakeVisible()  {
            this.Ifruit.IsVisible = true;
        }

        //Set IsVisible to false
        public override void MakeInvisible() {
            this.Ifruit.IsVisible = false;
        }
    }
}