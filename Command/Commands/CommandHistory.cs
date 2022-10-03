using System.Collections.Generic;

namespace Command.Commands
{
    public class CommandHistory
    {
        private Stack<IUndoCommand> commands = new Stack<IUndoCommand>();

        public void Push(IUndoCommand command)
        {
            this.commands.Push(command);
        }

        public IUndoCommand Pop()
        {
            if (this.commands.Count == 0)
            {
                return null;
            }

            return this.commands?.Pop();
        }
    }
}
