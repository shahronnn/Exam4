namespace task3;

public abstract class Shape
{
    protected  Color color;
    protected bool filled=true;
    public Shape(){}
    public Shape(Color color, bool filled)
    {
      this.color = color;
      this.filled=filled;
    }
    public Color GetColor()=> this.color;
    public void SetColor(Color color)=> this.color=color;
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()=> $"Shape [color={this.color}, filled={this.filled}]";
}
public enum Color
{
    Red=1,
    Black=2
}
