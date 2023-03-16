using System;
namespace Shapes
{
	public class Circle : AShape
	{
        private double r;

		public Circle(int x, int y, double r)
            : base(x, y)
		{
            this.r = r;
		}

        public override double GetArea()
        {
            return r * r * 3.14;
        }

        public override string GetSpecifics()
        {
            return $"radius={this.r}";
        }

        public override string Type()
        {
            return "Circle";
        }
    }
}

