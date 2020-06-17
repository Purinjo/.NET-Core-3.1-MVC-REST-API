namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public System.Collections.Generic.IEnumerable<Commander> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command(id=0, How to="Boil an egg", Line="Boil water", Platform="Kettle & Pan";)
                new Command(id=1, How to="Cut bread", Line="Get a knife", Platform="Kife & chopping board";)
                new Command(id=2, How to="Make a cup of tea", Line="Place teabag in cup", Platform="Kettle & cup";)
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command(id=0, How to="Boil an egg", Line="Boil water", Platform="Kettle & Pan";)
        }
    }
}