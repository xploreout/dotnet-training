namespace TrainingGround
{
  public class Employee :  Person
  {
    public Employee() {}
    public Employee(string Name, string aEmployeeId) : base(Name)
    {
      this.EmployeeId = aEmployeeId;
    
    }

    public string? EmployeeId { get; set; }
  }
}