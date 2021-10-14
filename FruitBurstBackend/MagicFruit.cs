using System;
 namespace FruitBurstBackend
 {
     public class MagicBurst: FruitDecorator
     {
         public int HP{get{return this.HP;} set{this.HP = 20;}}
         public MagicBurst(IFruit fruit): base(fruit)
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