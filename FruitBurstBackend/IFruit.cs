using System;

namespace FruitBurstBackend
{
    //Interface that is implement by concrete class Fruit and the base of the decorator pattern 
    public interface IFruit
    {
        int Points{get;}
        bool IsVisible{get;set;}

        void MakeVisible();

        void MakeInvisible();

    }
}