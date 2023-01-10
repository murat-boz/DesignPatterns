using System;

namespace State
{
    public class SettingsPrinterNameState : PrinterNameState
    {
        public override string GetName(PrinterNameContext printerNameContext)
        {
            Console.WriteLine("Get printer name from Settings: (Y) / (N)");

            if (Console.ReadKey().KeyChar == 'n')
            {
                return "Empty";
            }

            return "Settings";
        }
    }
}
