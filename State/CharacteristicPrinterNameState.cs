using System;

namespace State
{
    public class CharacteristicPrinterNameState : PrinterNameState
    {
        public override string GetName(PrinterNameContext printerNameContext)
        {
            Console.WriteLine("Get printer name from Characteristic: (Y) / (N)");

            if (Console.ReadKey().KeyChar == 'n')
            {
                printerNameContext.SetPrinterNameState(new SettingsPrinterNameState());

                return printerNameContext.GetName();
            }

            return "Characteristic";
        }
    }
}
