using System;
using System.Collections.Generic;
using System.Text;

namespace S3
{
    class Tile
    {
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
        private int value;

        public Tile()
        {

        }
        public Tile(int value)
        {
            this.value = value;
        }
    }
}
