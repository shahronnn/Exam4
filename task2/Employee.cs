namespace task2;

public class Employee
{
    protected int id;
    protected string firstname;
    protected string lastname;
    protected int salary;

    public Employee(int id, string firstname, string lastname, int salary)
    {
        this.id=id;
        this.firstname=firstname;
        this.lastname=lastname;
        this.salary=salary;
    }
    public int GetId()=> this.id;
    public string GetFirstName()=> this.firstname;
    public string GetLasttName()=> this.lastname;
    public string GetName()=> $"{this.firstname} {this.lastname}";
    public int GetSalary()=> this.salary;
    public void SetSalary(int salary)=> this.salary=salary;
    public int GetAnualSalary()=> this.salary*12;
    public int RaiseSalary(int percent)=> this.salary+(this.salary*percent/100);
    public override string ToString()=> $"Emloyee [id={this.id}, name={this.firstname} {this.lastname}, salary={this.salary}]";
}
