namespace TrainingGround;
public class AgeCalculator
{
  // --- comment out to test following w static method
  // public int GetAge(int birthYear, int currentYear)
  // {
  //   return currentYear - birthYear;
  // }

// static method  belongs to the class, not to the instance., test will fail
//error CS0176: Member 'AgeCalculator.GetAge(int, int)' cannot be accessed with an instance referen


    public static int GetAge(int birthYear, int currentYear)
  {
    return currentYear - birthYear;
  }
 
}
