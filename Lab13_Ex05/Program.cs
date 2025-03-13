class Shape
{
    private int? NumOfSide;

    // เปลี่ยนจาก private เป็น protected
    protected Shape()
    {
    }

    public Shape(int NumOfSide) : this()
    {
        this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base(0)
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4)
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
   public Triangle() : base(3) // แก้ไขให้มีการส่งค่าเป็น 3
    {
        System.Console.WriteLine("This is a triangle");
    }
}

class Program
{
    static void Main()
    {
        var circle = new Circle();
        var rectangle = new Rectangle();
        var triangle = new Triangle();
    }
}
