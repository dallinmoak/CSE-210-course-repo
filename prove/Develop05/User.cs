using System.IO;

class User
{
  public User(){
    this.LoadCurrentData();
  }

  private int _currentScore;

  private void LoadCurrentData()
  {
    string[] goalLines = File.ReadAllLines("goals.txt");
    // each line is a goal definition
    // comma separated list of values:
    //    type (single or repeating)
    //    name
    //    description
    //    completion point value
    //    completion status (true or false)
    //    repeating point value
    //    target repetitions
    //
  }

} 
