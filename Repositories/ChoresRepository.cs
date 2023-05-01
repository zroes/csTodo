namespace csTodo.Repositories;

public class ChoresRepository
{
  // NOTE this will work similar when we have a real db but will change a little
  private readonly FakeDB _db;

  public ChoresRepository(FakeDB db)
  {
    _db = db;
  }

  internal List<Chore> Get()
  {
    return _db.Chores;
  }

  internal Chore GetOne(int choreId)
  {
    Chore foundChore = _db.Chores.Find(chore => chore.Id == choreId);
    return foundChore;
  }
}
