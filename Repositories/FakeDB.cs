namespace csTodo.Repositories;

public class FakeDB
{
  public List<Chore> Chores;

  public FakeDB()
  {
    Chores = new List<Chore>();
    Chores.Add(new Chore(1, "watch some c# videos", false));
    Chores.Add(new Chore(2, "go to sleep before 10 but after 8", false));
    Chores.Add(new Chore(3, "create some more chores", false));
    Chores.Add(new Chore(4, "delete chores", false));
    Chores.Add(new Chore(5, "get by id", true));
  }
}
