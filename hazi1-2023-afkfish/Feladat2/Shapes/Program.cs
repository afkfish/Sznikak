namespace Shapes;

public class Program
{
    public static void Main(string[] args)
    {
        ShapeContainer container = new ShapeContainer();

        container.addShape(new Square(20, 10, 2));
        container.addShape(new Circle(10, 10, 5));
        container.addShape(new TextArea(30, 20, 5, 10, "Alma"));

        container.listAll();
    }
}
