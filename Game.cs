using System;
using System.Collections.Generic;

public class HigherLowerGame

{
  public static void Main()
  {
    Console.WriteLine("Would you like to play the higher/lower game with me? (Yes/No)");
    string firstQuestion = Console.ReadLine();
    Console.WriteLine("Okay, is your number higher or lower than 50? (Higher/Lower/Correct)");
    string secondQuestion = Console.ReadLine();

    if (secondQuestion == Higher)
      {
        Console.WriteLine("Is it higher or lower than 75? (Higher/Lower/Correct)");
        string thirdQuestion = Console.ReadLine();
          if (thirdQuestion == Higher)
          {
            Random random = new Random();
            int firstRandomNum = random.Next(76, 101);
            Console.WriteLine("Is your number higher or lower than this number? Higher/Lower/Correct");
            string fourthQuestion = Console.ReadLine();
            while (fourthQuestion == Higher)
            {
              random.Next(firstRandomNum, 101);
              Console.WriteLine("Is your number higher or lower than this number? Higher/Lower/Correct");
              string fifthQuestion = Console.ReadLine();
              if (fifthQuestion == Lower)
              {
                random.Next(firstRandomNum, 101);
              }
          }
      }

      if (secondQuestion == Lower)
      {
        Console.WriteLine("Is it higher or lower than 25? (Higher/Lower/Correct)")
      }
      }
    }
  }
}
