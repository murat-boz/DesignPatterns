namespace Command.Commands
{
    public class DivisionCalculatorCommand : ICommand, IUndoCommand
    {
        private readonly Calculator calculator;
        private readonly CommandHistory commandHistory;
        private readonly decimal value;

        public DivisionCalculatorCommand(Calculator calculator, CommandHistory commandHistory, decimal value)
        {
            this.calculator     = calculator;
            this.commandHistory = commandHistory;
            this.value          = value;
        }

        public static DivisionCalculatorCommand Create(Calculator calculator, CommandHistory commandHistory, decimal value)
        {
            return new DivisionCalculatorCommand(calculator, commandHistory, value);
        }

        public void Execute()
        {
            this.calculator.Compute('/', this.value);

            this.commandHistory.Push(this.Clone());
        }

        public void Undo()
        {
            this.calculator.Compute('*', this.value);
        }

        public DivisionCalculatorCommand Clone()
        {
            return new DivisionCalculatorCommand(this.calculator, this.commandHistory, this.value);
        }
    }
}
