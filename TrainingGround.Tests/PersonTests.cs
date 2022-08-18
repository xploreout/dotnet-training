public class PersonTests {
  [Fact]
  public void create_person_using_parameterless_constructor()
  {
    var p = new Person("Marcus");

    Assert.NotNull(p);
    Assert.Equal("Marcus", p.Name);
  }
}