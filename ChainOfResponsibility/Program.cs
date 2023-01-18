using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chain<Competency> soldier    = new Soldier();
            Chain<Competency> lieutenant = new Lieutenant();
            Chain<Competency> captain    = new Captain();
            Chain<Competency> general    = new General();

            soldier.SetNext(lieutenant);
            lieutenant.SetNext(captain);
            captain.SetNext(general);

            soldier.Handle(Competency.Captain);

            Console.ReadLine();
        }
    }
}
