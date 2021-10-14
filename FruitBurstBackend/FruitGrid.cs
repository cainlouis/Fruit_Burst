using System;

namespace FruitBurstBackend
{
    public class FruitGrid
    {
        public IFruit[,] Grid{get;set;}
        public IFruit this[int i, int j]
        {
            get {return Grid[i,j];}
            set {this.Grid[i,j] = value;}
        }
        public FruitGrid(int length, int width) 
        {
            Grid = new IFruit[length, width];
            PopulateGrid();
        }

        private void PopulateGrid() 
        {
            IFruit ordinaryFruit = new Fruit();
            FruitDecorator explosive = new ExplodingFruit(ordinaryFruit);
            FruitDecorator magic = new MagicFruit(ordinaryFruit);
            IFruit[] fruits = {ordinaryFruit, explosive, magic};
            Random random = new Random();
            int rand;
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++) 
                {
                    rand = random.Next();
                    Grid[i,j] = fruits[rand];
                }
            }
        }

        public bool GetVisibility(int i, int j)
        {
            return Grid[i,j].IsVisible;
        }
    }
}