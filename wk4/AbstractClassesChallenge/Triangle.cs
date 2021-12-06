using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
            // Implement your Triangle class here.
        public int sideA = 0;
        public int sideB = 0;
        public int sideC = 0;
        public int s = sideC + sideB + sideA;
        public Triangle(int SideA, int SideB, int SideC)
        {
            this.sideA = SideA;
            this.sideB = SideB;
            this.sideC = SideC;
        }
        public override double Area
        {
            get
            {
                return sideA;
            }
        }
            // HINT: Use Herons Formula to calculate and set the area.
    }
}
