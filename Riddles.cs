using System;
using System.Collections.Generic;

public class Riddle
{
  public string Question;
  public string Answer;
}

public class Program
{
  public static void Main()
  {
    Riddle question1 = new Riddle();
    question1.Question = "What kind of goose fights with snakes?";
    question1.Answer = "mongoose";

    Riddle question2 = new Riddle();
    question2.Question = "I am wet when drying. What am I?";
    question2.Answer = "towel";

    Riddle question3 = new Riddle();
    question3.Question = "What word is always pronounced wrong?";
    question3.Answer = "wrong";

    List<Riddle> Riddles = new List<Riddle>() { question1, question2, question3 };

    AskAnotherQuestion();


    void AskAnotherQuestion()
    {
      Random rnd = new Random();
      int intRiddle = rnd.Next(Riddles.Count);

      Console.WriteLine(Riddles[intRiddle].Question);
      string userInput = Console.ReadLine();

      if (userInput.Contains(Riddles[intRiddle].Answer))
      {
          Console.WriteLine("Correct!");
          Console.WriteLine("Would you like to answer another question? If yes, type 'y', if no, type 'n'");
          string anotherQuestion = Console.ReadLine().ToLower();
          if (anotherQuestion == "y")
          {
            AskAnotherQuestion();
          }
          else
          {
            Console.WriteLine("Thanks for playing!");
          }
      }
      else
      {
          Console.WriteLine("You've been eaten by the Sphinx!");
      }
    }

  }
}