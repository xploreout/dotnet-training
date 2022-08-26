public class PersonTests {
  [Fact]
  public void create_person_using_parameterless_constructor()
  {
    var p = new Person("Marcus", 2000);

    Assert.NotNull(p);
    Assert.Equal("Marcus", p.Name);
  }

  [Fact]
  public void a_person_born_1972_is_50_2022()
  {
    var p = new Person("Tom", 1972);

    var age = p.GetAge(2022);

    Assert.Equal(50, age);

    var p1982 = new Person("Sammy", 1982);
    Assert.Equal("Sammy", p1982.Name);
  }
  [Fact]
  public void a_person_born_1982()
  {
    var p1982 = new Person("Sammy", 1982);
    Assert.Equal("Sammy", p1982.Name);
    Assert.Equal(p1982.Age, 40);
    Assert.Equal(p1982.BirthYear, 1982);
  }
}