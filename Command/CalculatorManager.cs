using Command.Commands;

namespace Command
{
    /// <summary>
    /// Invoker class
    /// </summary>
    public class CalculatorManager
    {
        private Calculator calculator         = new Calculator();
        private CommandHistory commandHistory = new CommandHistory();

        public void Compute(char @operator, decimal value)
        {
            switch (@operator)
            {
                case '+':
                    SumCalculatorCommand.Create(this.calculator, this.commandHistory, value).Execute();
                    break;
                case '-':
                    SubtractionCalculatorCommand.Create(this.calculator, this.commandHistory, value).Execute();
                    break;
                case '/':
                    DivisionCalculatorCommand.Create(this.calculator, this.commandHistory, value).Execute();
                    break;
                case '*':
                    MultiplicationCalculatorCommand.Create(this.calculator, this.commandHistory, value).Execute();
                    break;
                default:
                    break;
            }
        }

        public void Undo()
        {
            UndoCommand.Create(this.commandHistory).Execute();
        }
    }
}
