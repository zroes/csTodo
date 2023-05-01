namespace csTodo.Services;

public class ChoresService
{

  private readonly ChoresRepository _repo;

  public ChoresService(ChoresRepository repo)
  {
    _repo = repo;
  }


  internal List<Chore> Get()
  {
    List<Chore> chores = _repo.Get();
    return chores;
  }

  internal Chore GetOne(int choreId)
  {
    Chore gotChore = _repo.GetOne(choreId);
    return gotChore;
  }
}


