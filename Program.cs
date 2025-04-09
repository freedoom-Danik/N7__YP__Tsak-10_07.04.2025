namespace N7__YP__Task_10_07._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string result = string.Join(" ", input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
            Console.WriteLine(result);
        }
    }
}
