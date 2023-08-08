namespace task3;

public class Rectange:Shape
{
    protected double width=1.0;
    protected double length=1.0;

    public Rectange(){}
    public Rectange(double width, double length)
    {
        this.width=width;
        this.length=length;
    }
    public Rectange(double width, double length, Color color, bool filled)
    {
        this.width=width;
        this.length=length;
        this.color=color;
        this.filled=filled;
    }
    public double GetWidth()=> this.width;
    public void SetWidth(double width)=> this.width=width;
    public double GetLength()=> this.length;
    public void SetLenght(double length)=> this.length=length;
    public override double GetArea()=> width*length;
    public override double GetPerimeter()=> 2*(width+length);
    public override string ToString()=> $"Circle[Shape [color={this.color}, filled={this.filled}],length={this.length}, width={this.width}]";
}

