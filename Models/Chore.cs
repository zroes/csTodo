namespace csTodo.Models;

public class Chore
{
  public Chore(int id, string description, bool isDone)
  {
    Id = id;
    Description = description;
    IsDone = isDone;
  }

  public int Id { get; set; }
  public string Description { get; set; }

  public bool IsDone { get; set; }

}