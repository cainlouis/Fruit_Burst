using System;

namespace FruitBurstBackend
{
    public class FruitGrid
    {
        public IFruit[,] Grid{get;set;}
        public int Length{get;}
        public int Width {get;}

        public IFruit this[int i, int j]
        {
            get {return Grid[i,j];}
            set {this.Grid[i,j] = value;}
        }
        public FruitGrid(int length, int width) 
        {   
            Length = length;
            Width = width;
            Grid = new IFruit[length, width];
            PopulateGrid();
        }

        private void PopulateGrid() 
        {
            int numMagic;
            int numExplosive;
            IFruit ordinaryFruit = new Fruit();
            FruitDecorator explosive = new ExplodingFruit(ordinaryFruit);
            FruitDecorator magic = new MagicFruit(ordinaryFruit);
            if (Length < 20) {
                numMagic = 3;
                numExplosive = 1;
            }
            else
            {
                numMagic = 5;
                numExplosive = 3;
            }
            insertDecoratedFruit(numMagic, magic);
            insertDecoratedFruit(numExplosive, explosive);
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Width; j++) 
                {
                    if (Grid[i,j] != null) {
                        Grid[i,j] = ordinaryFruit;
                    }
                }
            }
        }

        public bool GetVisibility(int i, int j)
        {
            return Grid[i,j].IsVisible;
        }

        private void insertDecoratedFruit(int num, FruitDecorator fruit) {
            Random random = new Random();
            int rand1;
            int rand2;
            for (int i = 0; i <= num; i++) {
                rand1 = random.Next(Width);
                rand2 = random.Next(Length);
                if (Grid[rand1, rand2] != null) {
                    i--;
                } else{
                    Grid[rand1, rand2] = fruit;
                }
            }
        }
    }
}