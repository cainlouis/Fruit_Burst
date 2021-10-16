using System;
 namespace FruitBurstBackend
 {
     public class MagicFruit: FruitDecorator
     {
         public int HP{get;set;}
         public MagicFruit(IFruit fruit): base(fruit)
         {
            this.HP = 20;
         }

        public override void MakeVisible()  {
            base.IsVisible = true;
        }

        public override void MakeInvisible() {
            if (this.HP <= 0) {
                base.IsVisible = false;
            }
            else{
                this.HP--;
            }
        }
     }
 }