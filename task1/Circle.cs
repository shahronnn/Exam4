namespace task1;

public class Circle
{
    protected double radius;
    protected const double pi=3.14;

    public Circle(){}
    public Circle(double radius)=> this.radius=radius;
    public double GetRadius()=> this.radius;
    public void SetRadius(double radius)=> this.radius=radius;
    public void GetArea()
    {
        System.Console.WriteLine($"{pi*radius*radius}");
    }
    public double GetCircumference()
    {
        return 2*pi*radius;
    }
    public override string ToString()
    {
        return $"Circle[radius={radius}]";
    }
}
