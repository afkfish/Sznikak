using System;
namespace Shapes
{
	public abstract class AShape : IShape 
	{
        private int x, y;

        public AShape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double GetArea();

        public abstract string GetSpecifics();

        public abstract string Type();

        public override string ToString()
        {
            return $"{this.Type()}: X={x}, Y={y}, {this.GetSpecifics()}, area={this.GetArea()}";
        }
    }
}

