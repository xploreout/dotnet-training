public class Person {
  public double LengthInMeters;
  // public int Age;
  
  //----------------
  private string? _name;
  public string? Name
  {
    get { return _name; }
    set { this._name = value; }
  }
  //-------end  name------------

  //---making birthYear public get and private set
  private int? _birthYear;
  public int? BirthYear 
  {
    get { return _birthYear;}
    set { _birthYear = value; }
  }
  //---end birthYear---

  //default..but as soon as we created Person w arg, we need to specific the fields
  public Person() {
    _name = "John";
    _birthYear = 2000;
  }
  public Person(string name, int birthYear)
  {
    Name = name;
    BirthYear = birthYear;
    // Age = GetAge(2022)
  }

  public object GetAge(int currentYear)
  {

    return currentYear - BirthYear;
  }
}



