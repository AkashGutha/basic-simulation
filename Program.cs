using Basic.Gates;

using static System.Console;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("starting program .... ");

            var a = new Or();
            a.setInputs(0x01,0x00);
            a.calculate();
            WriteLine(a.output[0]);
        }
    }
}
