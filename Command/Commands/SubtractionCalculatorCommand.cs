namespace Command.Commands
{
    public class SubtractionCalculatorCommand : ICommand, IUndoCommand
    {
        private readonly Calculator calculator;
        private readonly CommandHistory commandHistory;
        private readonly decimal value;

        public SubtractionCalculatorCommand(Calculator calculator, CommandHistory commandHistory, decimal value)
        {
            this.calculator     = calculator;
            this.commandHistory = commandHistory;
            this.value          = value;
        }

        public static SubtractionCalculatorCommand Create(Calculator calculator, CommandHistory commandHistory, decimal value)
        {
            return new SubtractionCalculatorCommand(calculator, commandHistory, value);
        }

        public void Execute()
        {
            this.calculator.Compute('-', this.value);

            this.commandHistory.Push(this.Clone());
        }

        public void Undo()
        {
            this.calculator.Compute('+', this.value);
        }

        public SubtractionCalculatorCommand Clone()
        {
            return new SubtractionCalculatorCommand(this.calculator, this.commandHistory, this.value);
        }
    }
}
