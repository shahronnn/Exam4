namespace task3;

public class Square:Rectange
{
    protected double side=1.0;

    public Square(){}
    public Square(double side)
    {
        this.side=side;
    }
    public Square(double side, Color color, bool filled)
    {
        this.side=side;
        this.color=color;
        this.filled=filled;
    }
    public double GetSide()=> this.side;
    public void SetSide(double side)=> this.side=side;
}
