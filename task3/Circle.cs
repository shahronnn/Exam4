namespace task3;

public class Circle:Shape
{
    protected double radius=1.0;

    public Circle(){}
    public Circle(double radius)=> this.radius=radius;
    public Circle(double radius, Color color, bool filled)
    {
        this.radius=radius;
        this.color=color;
        this.filled=filled;
    }
    public double GetRadius()=> this.radius;
    public override double GetArea()=> 3.14*this.radius*this.radius;
    public override double GetPerimeter()=> 2*3.14*radius;
    public override string ToString()=> $"Circle[Shape [color={this.color}, filled={this.filled}],radius={this.radius}]";
}
