using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        private string name = "";
        private int sides = 0;
        public int[] lengths;

        static void Main(string[] args)
        {
           
            Shape S = new Shape(name,sides);
            S.Rectangle(5,5);
            S.GetInfo();
        }
    }
}
