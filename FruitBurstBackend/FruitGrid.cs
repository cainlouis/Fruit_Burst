using System;

namespace FruitBurstBackend
{
    public class FruitGrid
    {
        private IFruit[,] grid;
        public int Length{get;}
        public int Width {get;}

        public IFruit this[int i, int j]
        {
            get {return grid[i,j];}
            set {this.grid[i,j] = value;}
        }
        public FruitGrid(int length, int width) 
        {   
            Length = length;
            Width = width;
            grid = new IFruit[length, width];
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
                    if (grid[i,j] != null) {
                        grid[i,j] = ordinaryFruit;
                    }
                }
            }
        }

        public bool GetVisibility(int i, int j)
        {
            return grid[i,j].IsVisible;
        }

        private void insertDecoratedFruit(int num, FruitDecorator fruit) {
            Random random = new Random();
            int rand1;
            int rand2;
            for (int i = 1; i <= num; i++) {
                rand1 = random.Next(Width);
                rand2 = random.Next(Length);
                if (grid[rand1, rand2] != null) {
                    i--;
                } else{
                    grid[rand1, rand2] = fruit;
                }
            }
        }
    }
}