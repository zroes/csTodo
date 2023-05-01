namespace csTodo.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ChoresController : ControllerBase
{
  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> Get()
  {
    try
    {
      List<Chore> chores = _choresService.Get();
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  [HttpGet("{choreId}")]

  public ActionResult<Chore> GetOne(int choreId)
  {
    try
    {
      Chore gotChore = _choresService.GetOne(choreId);
      return Ok(gotChore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}