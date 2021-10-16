using System;

namespace FruitBurstBackend
{
    public class FruitGrid
    {
        private IFruit[,] grid;
        public int Height{get;}
        public int Width {get;}

        public IFruit this[int i, int j]
        {
            get {return grid[i,j];}
            set {this.grid[i,j] = value;}
        }

        //parameterized constructor, takes the height and width for the grid then call populateGrid to fill it
        public FruitGrid(int height, int width) 
        {   
            Height = height;
            Width = width;
            grid = new IFruit[height, width];
            PopulateGrid();
        }

        //Populate the grid with fruit
        private void PopulateGrid() 
        {   
            //insert the decorated fruits first
            InsertDecoratedFruit();
            
            //For all the place left in grid place normal fruit
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++) 
                {
                    if (grid[i,j] != null) {
                        grid[i,j] = new Fruit();
                    }
                }
            }
        }
        
        //Return the fruit at [i,j]'s visibility 
        public bool GetVisibility(int i, int j)
        {
            return grid[i,j].IsVisible;
        }

        //Insert the decorated fruits at random positions in the grid | doing so exploding fruit has different points
        private void InsertDecoratedFruit() {
            int num;
            int counter = 0;
            Random random = new Random();
            int rand1;
            int rand2;
            do
            {
                //at counter = 0 chose the number of  magic fruit I want according to the height and width
                if (counter == 0)
                {
                    if (Height < 20 && Width < 20)
                    {
                        num = 3;
                    } else {
                        num = 5;
                    }
                } else {
                    //If counter is not  zero (can only be 1 here) chose the number of exploding fruits
                    if (Height < 20 && Width < 20)
                    {
                        num = 1;
                    } else {
                        num = 3;
                    }
                }
                //for the number chosen
                for (int i = 1; i <= num; i++)
                {
                    //get random number for the position
                    rand1 = random.Next(Height);
                    rand2 = random.Next(Width);
                    //if that position isn't null decrement i so it randomly choose another position 
                    if (grid[rand1, rand2] != null)
                    {
                        i--;
                    } else {
                        //using the counter place the decorated fruit
                        if (counter == 0)
                        {
                            grid[rand1, rand2] = new MagicFruit(new Fruit());
                        } else {
                            grid[rand1, rand2] = new ExplodingFruit(new Fruit());
                        }
                    }
                }
                counter++;
            } while (counter < 2);
        }
    }
}