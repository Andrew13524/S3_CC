using System;

namespace S3
{
    class Card
    {
        public string Suit;
        public string Value;

        public Card()
        {

        }
        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            //Setup();

            //Card card2 = new Card();
            //Card card = new Card("Clubs", "King");

            //int num = 1;
            //int num2 = 3;

            //int result = AddNum(num, num2);
            //Console.WriteLine(result);

            Tile tile = new Tile();
            Tile tile2 = new Tile();

            Tile[] array = new Tile[16];

            Tile[,] tiles = new Tile[4, 4];

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    tiles[i, j] = new Tile();
                }
            }

            tiles[0, 2].Value = 2;
        }

        
        

        /// <summary>
        /// Adds to numbers together.
        /// </summary>
        /// <param name="a">First number to be added</param>
        /// <param name="b">Second number to be added</param>
        private static int AddNum(int a, int b)
        {
            return a + b;
        }
        private static int AddNum(int a)
        {
            return a + 1;
        }

        private static void Setup()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Welcome |");
            Console.WriteLine("-----------");
        }
    }
}
