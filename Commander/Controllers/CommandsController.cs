namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumeralbe<Command>> GetAllCommands()
        {
            var commendItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }

        //GET api/commands/5
        [HttpGet("{id}")]
        public ActionResults <Command> GetComandById(int id)
        {
            var commandItems = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}