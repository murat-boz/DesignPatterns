using System;

namespace State
{
    public class DatabasePrinterNameState : PrinterNameState
    {
        public override string GetName(PrinterNameContext printerNameContext)
        {
            Console.WriteLine("Get printer name from Database: (Y) / (N)");

            if (Console.ReadKey().KeyChar == 'n')
            {
                printerNameContext.SetPrinterNameState(new CharacteristicPrinterNameState());

                return printerNameContext.GetName();
            }

            return "Database";
        }
    }
}
