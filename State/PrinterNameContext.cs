namespace State
{
    public class PrinterNameContext
    {
        private PrinterNameState printerNameState;

        public PrinterNameContext()
        {
            this.SetPrinterNameState(new DatabasePrinterNameState());
        }

        public void SetPrinterNameState(PrinterNameState printerNameState)
        {
            this.printerNameState = printerNameState;
        }

        public string GetName()
        {
            return this.printerNameState.GetName(this);
        }
    }
}
