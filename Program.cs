using Basic.Gates;

using static System.Console;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("starting program .... ");

            var a = new and(2,1);
            a.setInputs();
            a.calculate();
            WriteLine(a.output[0]);
        }
    }
}
