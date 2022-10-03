namespace Command.Commands
{
    public class MultiplicationCalculatorCommand : ICommand, IUndoCommand
    {
        private readonly Calculator calculator;
        private readonly CommandHistory commandHistory;
        private readonly decimal value;

        public MultiplicationCalculatorCommand(Calculator calculator, CommandHistory commandHistory, decimal value)
        {
            this.calculator     = calculator;
            this.commandHistory = commandHistory;
            this.value          = value;
        }

        public static MultiplicationCalculatorCommand Create(Calculator calculator, CommandHistory commandHistory, decimal value)
        {
            return new MultiplicationCalculatorCommand(calculator, commandHistory, value);
        }

        public void Execute()
        {
            this.calculator.Compute('*', this.value);

            this.commandHistory.Push(this.Clone());
        }

        public void Undo()
        {
            this.calculator.Compute('/', this.value);
        }

        public MultiplicationCalculatorCommand Clone()
        {
            return new MultiplicationCalculatorCommand(this.calculator, this.commandHistory, this.value);
        }
    }
}
