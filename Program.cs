using System;
using System.Collections.Generic;
using RefactoredRiddles.Models;

namespace RefactoredRiddles
{

  public class Program
  {
    public static void Main()
    {
      Riddles question1 = new Riddles("What kind of goose fights with snakes?", "mongoose");
      Riddles question2 = new Riddles("I am wet when drying. What am I?", "towel");
      Riddles question3 = new Riddles("What word is always pronounced wrong?", "wrong");

      List<Riddles> Questions = new List<Riddles>() { question1, question2, question3 };

      AskAnotherQuestion();

      void AskAnotherQuestion()
      {
        Random rnd = new Random();
        int intRiddle = rnd.Next(Questions.Count);

        Console.WriteLine(Questions[intRiddle].GetQuestion());
        string userInput = Console.ReadLine();

        if (userInput.Contains(Questions[intRiddle].GetAnswer()))
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
}