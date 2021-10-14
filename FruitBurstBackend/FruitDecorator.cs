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

        public virtual int Points {get { return Ifruit.Points; }}

        public virtual bool IsVisible{get { return Ifruit.IsVisible; }}
        public abstract void MakeVisible();

        public abstract void MakeInvisible();

    }
}