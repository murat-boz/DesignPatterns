namespace Command.Commands
{
    public interface IUndoCommand : ICommand
    {
        void Undo();
    }
}
