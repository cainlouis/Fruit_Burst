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

        public virtual int Points {get;}

        public virtual bool IsVisible{get;set;}
        public virtual void MakeVisible()  {
            Console.Write("MakeVisible");
        }

        public virtual void MakeInvisible() {
            Console.Write("MakeInvisible");
        }

    }
}