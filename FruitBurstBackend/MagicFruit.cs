using System;
 namespace FruitBurstBackend
 {
     public class MagicFruit: FruitDecorator
     {
         public int HP{get{return this.HP;} set{this.HP = 20;}}
         public MagicFruit(IFruit fruit): base(fruit)
         {
         }

        public override void MakeInvisible() {
            if (this.HP <= 0) {
                base.IsVisible = false;
            }
            this.HP--;
        }
     }
 }