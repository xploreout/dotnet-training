public class Employee : Person {
  [Fact]
public void an_employee_is_a_person()
{
  // act
  var emp = new Employee("test", "id-123");
  emp.LengthInMeters = 1.95;

  // assert
  Assert.IsType(typeof(Employee), emp);
  // Assert.Equal(1.95, emp.LengthInMeters);
}
[Fact]
public void an_employee_has_an_employeeId()
{
  // act
  var emp = new Employee("Marcus", "234-BDAS");

  // // assert
  Assert.IsType(typeof(Employee), emp);
  Assert.Equal("Marcus", emp.Name);
  Assert.Equal("234-BDAS", emp.EmployeeId);
}
}