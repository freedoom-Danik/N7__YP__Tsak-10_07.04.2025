namespace N7__YP__Tsak_10_07._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("input string: ");
            string input = Console.ReadLine();

            string[] words = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            string rusult = string.Join(" ", words);
            Console.WriteLine(rusult);
        }
    }
}
