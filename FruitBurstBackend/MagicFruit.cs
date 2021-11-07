using System;

namespace FruitBurstBackend
{
    //Concrete component of the decorator pattern, implement the FruitDecorator
    public class MagicFruit : FruitDecorator
    {
        //Property that set and return an int represent the HP of the player
        public int HP { get; set; }

        //Parameterized constructor, implement the FruitDecorator constructor and set HP to 20 as default value
        public MagicFruit(IFruit fruit) : base(fruit)
        {
            this.HP = 20;
        }

        //Set the IsVisible to true
        public override void MakeVisible()
        {
            base.IsVisible = true;
        }

        //Set IsVisible if the HP smaller or equal to 0 or decrement the HP by 1
        public override void MakeInvisible()
        {
            if (this.HP <= 0)
            {
                base.IsVisible = false;
            }
            else
            {
                this.HP--;
            }
        }
    }
}