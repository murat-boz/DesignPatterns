namespace Command.Commands
{
    public class UndoCommand : ICommand
    {
        private readonly CommandHistory commandHistory;

        public UndoCommand(CommandHistory commandHistory)
        {
            this.commandHistory = commandHistory;
        }

        public static UndoCommand Create(CommandHistory commandHistory)
        {
            return new UndoCommand(commandHistory);
        }

        public void Execute()
        {
            IUndoCommand command = this.commandHistory.Pop();

            command?.Undo();
        }
    }
}
