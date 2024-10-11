using FizzBuzzReflection;

namespace FizzBuzzConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz!");

            var fizzBuzz = new FizzBuzz();

            List<Tuple<string, string>> outputList = fizzBuzz.GenerateList(100);

            foreach (Tuple<string, string> item in outputList)
            {
                Console.WriteLine(item.Item1 + " = " + item.Item2);
            }
            Console.ReadKey();
        }
    }
}
