using System;
namespace Shapes
{
	public class ShapeContainer
	{
		private List<IShape> shapes;

		public ShapeContainer()
		{
			shapes = new List<IShape>();
		}

		public void addShape(IShape shape)
		{
			this.shapes.Add(shape);
		}

		public IShape removeShape(int i)
		{
			if (shapes.Count >= i + 1)
			{
				IShape temp = shapes[i];
				shapes.RemoveAt(i);
				return temp;
            }
			return null;
		}

		public IShape getShape(int i)
		{
			if (shapes.Count >= i + 1)
			{
                return shapes[i];
            }
			return null;
		}

		public void listAll()
		{
			foreach (IShape shape in shapes)
			{
				Console.WriteLine(shape.ToString());
			}
		}
	}
}

