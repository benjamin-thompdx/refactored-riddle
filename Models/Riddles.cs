namespace RefactoredRiddles.Models {
  public class Riddles
  {
    private string _question;
    private string _answer;

    public Riddles(string question, string answer)
    {
      _question = question;
      _answer = answer;
    } 

    public string GetQuestion()
    {
      return _question;
    }

    public string GetAnswer()
    {
      return _answer;
    }
  }
}

