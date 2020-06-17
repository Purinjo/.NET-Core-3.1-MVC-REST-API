using System.Collections.Generic;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Commander> GetAppCommands();
        Commander GetCommandById(int id)
    }
}