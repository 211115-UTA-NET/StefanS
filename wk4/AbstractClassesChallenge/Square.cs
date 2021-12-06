using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        public int side;

        public Square(int Side)
        {
            this.side = Side;
        }
        public override double Area
        {
            get
            {
                return side * side;
            }
        }
    }
}
