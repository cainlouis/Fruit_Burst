using System;

namespace FruitBurstBackend
{
    public abstract class FruitDecorator: IFruit
    {
        protected IFruit Ifruit;

        public FruitDecorator(IFruit ifruit) 
        {
            this.Ifruit = ifruit;
        }

        public virtual int Points {get {return this.Ifruit.Points;}}

        public virtual bool IsVisible{get {return this.Ifruit.IsVisible;}set {this.Ifruit.IsVisible = value;}}
        public abstract void MakeVisible();

        public abstract void MakeInvisible();

    }
}