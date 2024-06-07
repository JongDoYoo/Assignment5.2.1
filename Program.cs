using System.ComponentModel.Design;

namespace Assignment5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a short sentence");
            string userSentence = Console.ReadLine();
            Console.WriteLine($"Last word has the length of {LastWordCount(userSentence)}");
        }
        static int LastWordCount (string count)
        {
            int lengthOfLastWord = 0;
            for (int i = count.Length-1; i >=0; i--)                
            {
                if (count[i] == ' ') 
                {
                    break;
                }
                lengthOfLastWord += 1;              
            }
            return lengthOfLastWord;
        }
    }
}
