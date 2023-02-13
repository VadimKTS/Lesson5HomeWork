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

            //string myStringForTask3 = "«Мы находимся здесь, чтобы внести bbbbbb свой вклад в этот мир. Иначе зачем мы здесь?» Стив Джобс ffffff ab f 978345 fghj  ";
            //myStringForTask3 = myStringForTask3.Trim();
            //char[] charArrayFromString = myStringForTask3.ToArray();
            //int spacesInString = 0;

            //for (int i = 0; i < myStringForTask3.Length; i++)
            //{
            //    if (char.IsWhiteSpace(charArrayFromString[i]))
            //    {
            //        spacesInString++;
            //    }
            //}

            //int[] lettersInWordsArrary = new int[spacesInString + 1];
            //int b = 0;
            //int lettersInWords = 0;
            //for (int i = 0; i < myStringForTask3.Length; i++)
            //{
            //    if (char.IsWhiteSpace(charArrayFromString[i]))
            //    {
            //        lettersInWordsArrary[b] = lettersInWords;
            //        lettersInWords = 0;
            //        b++;
            //    }
            //    else if (i == myStringForTask3.Length - 1)
            //    {
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
            //    if (char.IsLetter(charArrayFromString[n]) || char.IsDigit(charArrayFromString[n]))
            //    {
            //        arrayOfWordsFromChars[j][k] = charArrayFromString[n];
            //        //Console.Write($"{arrayOfWordsFromChars[j][k]} ");
            //        k++;
            //    }
            //    else if (char.IsWhiteSpace(charArrayFromString[n]))
            //    {
            //        //Console.Write("\t");
            //        j++;
            //        k = 0;
            //    }
            //}
            //// Решение

            //int[] equalChars = new int[arrayOfWordsFromChars.Length];
            //for (int i = 0; i < arrayOfWordsFromChars.Length; i++)
            //{
            //    k = 0;
            //    for (j = 0; j < arrayOfWordsFromChars[i].Length; j++)
            //    {
            //        for (int n = 0; n < arrayOfWordsFromChars[i].Length; n++)
            //        {
            //            if (arrayOfWordsFromChars[i][j].Equals(arrayOfWordsFromChars[i][n]) && j == (arrayOfWordsFromChars[i].Length - 1))
            //            {
            //                k++;
            //                equalChars[i] = k;
            //            }
            //            else if (j == (arrayOfWordsFromChars[i].Length - 1) && i == (arrayOfWordsFromChars[i].Length - 1))
            //            {
            //                equalChars[i] = k;
            //            }
            //            else if (arrayOfWordsFromChars[i][j].Equals(arrayOfWordsFromChars[i][n]))
            //            {
            //                k++;
            //            }
            //        }
            //    }
            //}
            //int maxEquals = 0;
            //int itemWithmaxEquals = 0;
            //for (int i = 0; i < equalChars.Length; i++)
            //{
            //    if (equalChars[i] > maxEquals)
            //    {
            //        maxEquals = equalChars[i];
            //        itemWithmaxEquals = i;
            //    }
            //}

            //Console.Write("\nСлово, в котором число различных символов минимально: ");
            //for (int i = 0; i < arrayOfWordsFromChars[itemWithmaxEquals].Length; i++)
            //{
            //    Console.Write(arrayOfWordsFromChars[itemWithmaxEquals][i]);
            //}


            // task 4*                    --------------------------------------

        //    string myStringForTask4 = "«Если тебе тяжело, значит ты поднимаешься в гору. Если тебе легко, значит ты летишь в пропасть». Ololo Генри Форд";
        //    myStringForTask4 = myStringForTask4.Trim();
        //    Console.WriteLine(myStringForTask4 + "\n");
        //    int spacesInString = 0;

        //    for (int i = 0; i < myStringForTask4.Length; i++)
        //    {
        //        if (char.IsWhiteSpace(myStringForTask4[i]))
        //        {
        //            spacesInString++;
        //        }
        //    }
        //    string[] arrayOfWords = new string[spacesInString + 1];
        //    int n = 0;

        //    for (int i = 0; i < myStringForTask4.Length; i++)
        //    {
        //        if (char.IsWhiteSpace(myStringForTask4[i]))
        //        {
        //            n++;
        //        }
        //        else if (char.IsPunctuation(myStringForTask4[i]))
        //        {

        //        }
        //        else
        //        {
        //            arrayOfWords[n] += myStringForTask4[i];
        //        }
        //    }

        //inputAgain:
        //    Console.WriteLine($"Введите порядковый номер слова в строке:");
        //    int inputNumber = Convert.ToInt32(Console.ReadLine()) - 1;
        //    string palindrom = "";
        //    StringBuilder reverseString = new StringBuilder();
        //    if (inputNumber >= arrayOfWords.Length)
        //    {
        //        Console.WriteLine($"В строке всего {arrayOfWords.Length} слов.");
        //        goto inputAgain;
        //    }

        //    for (int j = arrayOfWords[inputNumber].Length - 1; j >= 0; j--)
        //    {
        //        reverseString.Append(arrayOfWords[inputNumber][j]);
        //    }

        //    if (arrayOfWords[inputNumber].ToLower().Equals(reverseString.ToString().ToLower()) && arrayOfWords[inputNumber].Length > 1)
        //    {
        //        palindrom = arrayOfWords[inputNumber];
        //        Console.WriteLine($"Слово  \"{arrayOfWords[inputNumber]}\" палиндром.\n" +
        //        $"Введите 1 чтобы проверить другое слово. 0 - закончить");
        //        int continueOrNot = Convert.ToInt32(Console.ReadLine());
        //        if (continueOrNot == 1) { goto inputAgain; }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Слово  \"{arrayOfWords[inputNumber]}\" не является палиндромом.\n" +
        //        $"Введите 1 чтобы проверить другое слово. 0 - закончить");
        //        int continueOrNot = Convert.ToInt32(Console.ReadLine());
        //        if ( continueOrNot == 1 ) { goto inputAgain; }
        //    }


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