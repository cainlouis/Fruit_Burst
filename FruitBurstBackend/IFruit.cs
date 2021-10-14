using System;

namespace FruitBurstBackend
{
    public interface IFruit
    {
        int Points{get;}
        bool IsVisible{get;set;}

        void MakeVisible();

        void MakeInvisible();

    }
}