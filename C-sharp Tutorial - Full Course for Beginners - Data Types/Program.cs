using System;

namespace C_sharp_Tutorial___Full_Course_for_Beginners___Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Get Academy";
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase.IndexOf('c'));
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Substring(4, 3) );
            Console.WriteLine(phrase.Substring(4));
        }
    }
}
