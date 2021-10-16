using System;

namespace FruitBurstBackend
{
    //Abstract class that implements IFruit and base of the Decorator pattern
    public abstract class FruitDecorator: IFruit
    {
        protected IFruit Ifruit;

        //parameterized constructor that set the field to the input
        public FruitDecorator(IFruit ifruit) 
        {
            this.Ifruit = ifruit;
        }

        //Property that return the IFruit Points
        public virtual int Points {get {return this.Ifruit.Points;}}

        //Preperty that set Ifruit.IsVisible to a value and return that same value
        public virtual bool IsVisible{get {return this.Ifruit.IsVisible;}set {this.Ifruit.IsVisible = value;}}
        
        //Both abstract methods to be implemented by concrete component
        public abstract void MakeVisible();

        public abstract void MakeInvisible();

    }
}