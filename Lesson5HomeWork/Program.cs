namespace Lesson5HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 2                     --------------------------------------

            string myStringForTask2 = "«Никогда не ошибается тот, кто ничего нЕ делает». Теодор Рузвельт";
            myStringForTask2 = myStringForTask2.Trim();
            char[] charArrayFromString = myStringForTask2.ToArray();


            
            int spacesInString = 0;

            for (int i = 0; i < myStringForTask2.Length; i++)
            {
                if ( char.IsWhiteSpace(charArrayFromString[i]) )
                {
                    spacesInString++;
                }
            }
            string[] arrayOfWords = new string[spacesInString+1];
            int n = 0;

            for (int i = 0; i < charArrayFromString.Length; i++)
            {
                if ( char.IsWhiteSpace(charArrayFromString[i]) )
                {
                    n++;
                }
                else if (char.IsPunctuation(charArrayFromString[i]))
                {
                    
                }
                else
                {
                    arrayOfWords[n] += charArrayFromString[i];
                }
            }

            string shortestWordInString = arrayOfWords[0];
            string longestWordInString = arrayOfWords[0];
            for (int j = 0; j < arrayOfWords.Length; j++)
            {
                if (arrayOfWords[j].Length >= longestWordInString.Length)
                {
                    longestWordInString = arrayOfWords[j];
                }
                else if (arrayOfWords[j].Length <= shortestWordInString.Length)
                {
                    shortestWordInString = arrayOfWords[j];
                }
            }

            Console.WriteLine(myStringForTask2);
            Console.WriteLine($"Самое короткое слово: {shortestWordInString}\nСамое длинное слово: {longestWordInString}");

            
            // task 3                     --------------------------------------




            // task 4*                    --------------------------------------




            // task 5                     --------------------------------------




        }
    }
}