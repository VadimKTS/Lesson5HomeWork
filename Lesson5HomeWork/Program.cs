using System.Globalization;
using System.Text;

namespace Lesson5HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 2                     --------------------------------------

            //string myStringForTask2 = "«Никогда не ошибается тот, кто ничего нЕ делает». Теодор Рузвельт";
            //myStringForTask2 = myStringForTask2.Trim();
            //char[] charArrayFromString = myStringForTask2.ToArray();
            //int spacesInString = 0;

            //for (int i = 0; i < myStringForTask2.Length; i++)
            //{
            //    if ( char.IsWhiteSpace(charArrayFromString[i]) )
            //    {
            //        spacesInString++;
            //    }
            //}
            //string[] arrayOfWords = new string[spacesInString+1];
            //int n = 0;

            //for (int i = 0; i < charArrayFromString.Length; i++)
            //{
            //    if ( char.IsWhiteSpace(charArrayFromString[i]) )
            //    {
            //        n++;
            //    }
            //    else if (char.IsPunctuation(charArrayFromString[i]))
            //    {
                    
            //    }
            //    else
            //    {
            //        arrayOfWords[n] += charArrayFromString[i];
            //    }
            //}

            //string shortestWordInString = arrayOfWords[0];
            //string longestWordInString = arrayOfWords[0];
            //for (int j = 0; j < arrayOfWords.Length; j++)
            //{
            //    if (arrayOfWords[j].Length >= longestWordInString.Length)
            //    {
            //        longestWordInString = arrayOfWords[j];
            //    }
            //    else if (arrayOfWords[j].Length <= shortestWordInString.Length)
            //    {
            //        shortestWordInString = arrayOfWords[j];
            //    }
            //}

            //Console.WriteLine(myStringForTask2);
            //Console.WriteLine($"Самое короткое слово: {shortestWordInString}\nСамое длинное слово: {longestWordInString}");


            // task 3                     --------------------------------------

            //string myStringForTask3 = "«Мы находимся здесь, чтобы внести свой вклад в этот мир. Иначе зачем мы здесь?» Стив Джобс 978345 fghj ffffff  ";
            //myStringForTask3 = myStringForTask3.Trim();
            //char[] charArrayFromString = myStringForTask3.ToArray();
            //int spacesInString = 0;

            //for ( int i = 0; i < myStringForTask3.Length; i++ )
            //{
            //    if ( char.IsWhiteSpace(charArrayFromString[i]) )
            //    {
            //        spacesInString++;
            //    }
            //}

            //int[] lettersInWordsArrary = new int[spacesInString + 1];
            //int b = 0;
            //int lettersInWords = 0;
            //for ( int i = 0; i < myStringForTask3.Length; i++ )
            //{
            //    if (char.IsWhiteSpace(charArrayFromString[i]) )
            //    {
            //        //Console.Write(lettersInWords);
            //        lettersInWordsArrary[b] = lettersInWords;
            //        lettersInWords = 0;
            //        b++;
            //    }
            //    else if (i == myStringForTask3.Length - 1)
            //    {
            //        //Console.Write(lettersInWords);
            //        lettersInWordsArrary[b] = lettersInWords + 1;
            //    }
            //    else if (char.IsPunctuation(charArrayFromString[i]))
            //    {
                    
            //    }
            //    else
            //    {
            //        lettersInWords++;
            //    }
            //}

            //char[][] arrayOfWordsFromChars = new char[spacesInString + 1][];    //зубчатый массив
            //for (int i = 0; i < lettersInWordsArrary.Length; i++)
            //{
            //    arrayOfWordsFromChars[i] = new char[lettersInWordsArrary[i]];
            //}

            //int j = 0;
            //int k = 0;
            //for (int n = 0; n < charArrayFromString.Length; n++)
            //{
            //    if ( char.IsLetter(charArrayFromString[n]) || char.IsDigit(charArrayFromString[n]) )
            //    {
            //        arrayOfWordsFromChars[j][k] = charArrayFromString[n];
            //        Console.Write($"{arrayOfWordsFromChars[j][k]} ");
            //        k++;
            //    }
            //    else if ( char.IsWhiteSpace(charArrayFromString[n]) )
            //    {
            //        Console.WriteLine();
            //        j++;
            //        k = 0;
            //    }
            //}


            // task 4*                    --------------------------------------




            // task 5                     --------------------------------------

            //string myStringForTask5 = "«Успех – паршивый учитель. Он заставляет умных людей думать, что они не могут проиграть». Билл Гейтс";
            //StringBuilder resultString = new StringBuilder(myStringForTask5);
            //for (int i = 0; i < myStringForTask5.Length; i++)
            //{
            //    resultString.Insert(i + i, myStringForTask5.Substring(i, 1));
            //}
            //Console.WriteLine(resultString);


        }
    }
}