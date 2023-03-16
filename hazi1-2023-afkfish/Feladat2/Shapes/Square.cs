using System;
namespace Shapes
{
	public class Square : AShape
	{
        public double sideLenght;

		public Square(int x, int y, double side)
            : base(x, y)
		{
            this.sideLenght = side;
		}

		public override string Type()
		{
			return "Square";
		}

        public override double GetArea()
        {
            return this.sideLenght * this.sideLenght;
        }

        public override string GetSpecifics()
        {
            return $"side={this.sideLenght}";
        }
    }
}

