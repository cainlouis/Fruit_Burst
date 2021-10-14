using System;

namespace FruitBurstBackend
{
    public interface IFruit
    {
        int Points{get;}
        bool IsVisible{get;}

        void MakeVisible();

        void MakeInvisible();

    }
}