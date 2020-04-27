using System;

namespace lab10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the text");
            string t = Console.ReadLine();
            Console.WriteLine("enter theme of the text");
            string theme = Console.ReadLine();
            Text text = new Text(t, theme);
            
            Console.WriteLine($"Count of letter = {text.cntOfLttrs()}");
            Console.WriteLine($"Count of letter = {text.cntOfSpaces()}");
        
            Console.Write("Enter the letter you want to change   ");
            char from = Convert.ToChar(Console.ReadLine());
            Console.Write("Which letter will replace it?     ");
            char to = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Changed text:{text.Replacelttrs(from, to)}");

            Console.Write("Enter the index of word you wamt to delete   ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your corrected text:{text.DelWord(index)}");
        }
    }
}
