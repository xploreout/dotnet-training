public class Person {
  public double LengthInMeters;
  public int Age;
  
  private string? _name;  //field
  public string? Name //property
  {
    get { return _name; }
    set { this._name = value; }
  }

  private int? _birthYear;
  public int? BirthYear 
  {
    get { return _birthYear;}
    set { _birthYear = value; }
  }
// shorthand way ---- other way to write it -----
// public int? BirthYear
// { get;set; }

  //default..but as soon as we created Person w arg, we need to specific the fields
  public Person() {
  }
  public Person(string aName)
  {
    Name = aName;
  }
  public Person(string aName, int aBirthYear)
  {
    Name = aName;
    BirthYear = aBirthYear;
    setAge(aBirthYear, 2022);
  }

 
  void setAge(int aBirthYear, int aCurrentYear){
    Age = aCurrentYear - aBirthYear;
  }


  public object GetAge(int currentYear)
  {
    return currentYear - BirthYear;
  }
}



