namespace Command.Commands
{
    public class SumCalculatorCommand : ICommand, IUndoCommand
    {
        private readonly Calculator calculator;
        private readonly CommandHistory commandHistory;
        private readonly decimal value;

        public SumCalculatorCommand(Calculator calculator, CommandHistory commandHistory, decimal value)
        {
            this.calculator     = calculator;
            this.commandHistory = commandHistory;
            this.value          = value;
        }

        public static SumCalculatorCommand Create(Calculator calculator, CommandHistory commandHistory, decimal value)
        {
            return new SumCalculatorCommand(calculator, commandHistory, value);
        }

        public void Execute()
        {
            this.calculator.Compute('+', this.value);

            this.commandHistory.Push(this.Clone());
        }

        public void Undo()
        {
            this.calculator.Compute('-', this.value);
        }

        public SumCalculatorCommand Clone()
        {
            return new SumCalculatorCommand(this.calculator, this.commandHistory, this.value);
        }
    }
}
