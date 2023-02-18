using System.Globalization;
using System.Text;

namespace Lesson5HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// task 2                     --------------------------------------

            //string myStringForTask2 = "«Никогда не ошибается тот, кто ничего нЕ делает». Теодор Рузвельт";
            //string[] myStringArrayForTask2 = myStringForTask2.Split(" ");


            //string shortestWordInString = myStringArrayForTask2[0];
            //string longestWordInString = myStringArrayForTask2[0];
            //for (int j = 0; j < myStringArrayForTask2.Length; j++)
            //{
            //    if (myStringArrayForTask2[j].Length >= longestWordInString.Length)
            //    {
            //        longestWordInString = myStringArrayForTask2[j];
            //    }
            //    else if (myStringArrayForTask2[j].Length <= shortestWordInString.Length)
            //    {
            //        shortestWordInString = myStringArrayForTask2[j];
            //    }
            //}

            //Console.WriteLine(myStringForTask2);
            //Console.WriteLine($"Самое короткое слово: {shortestWordInString}\nСамое длинное слово: {longestWordInString}");


            //// task 3                     --------------------------------------

            string myStringForTask3 = "«Мы находимся здесь, чтобы внести bbbbbb свой вклад в этот мир. Иначе зачем мы здесь?» Стив Джобс ffffff ab f 978345 fghj";
            string[] myStringArrayForTask3 = myStringForTask3.Split(" ");

            // Решение (вторая попытка)

            string wordForTask3 = myStringArrayForTask3[0];

            for (int i = 1; i < myStringArrayForTask3.Length; i++)
            {
                if (myStringArrayForTask3[i].Distinct().Count() < wordForTask3.Distinct().Count())
                {
                    wordForTask3 = myStringArrayForTask3[i];
                }
            }
            Console.WriteLine($"Слово, в котором число различных символов минимально: {wordForTask3}");


            // task 4*                    --------------------------------------

            //    string myStringForTask4 = "«Если тебе тяжело, значит ты поднимаешься в гору. Если тебе легко, значит ты летишь в пропасть». Ololo Генри Форд";
            //    string[] myStringArrayForTask4 = myStringForTask4.Split(" ");
            //    Console.WriteLine(myStringForTask4 + "\n");

            //inputAgain:
            //    Console.WriteLine($"Введите порядковый номер слова в строке:");
            //    int inputNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            //    string palindrom = "";
            //    StringBuilder reverseString = new StringBuilder();
            //    if (inputNumber >= myStringArrayForTask4.Length)
            //    {
            //        Console.WriteLine($"В строке всего {myStringArrayForTask4.Length} слов.");
            //        goto inputAgain;
            //    }

            //    for (int j = myStringArrayForTask4[inputNumber].Length - 1; j >= 0; j--)
            //    {
            //        reverseString.Append(myStringArrayForTask4[inputNumber][j]);
            //    }

            //    if (myStringArrayForTask4[inputNumber].ToLower().Equals(reverseString.ToString().ToLower()) && myStringArrayForTask4[inputNumber].Length > 1)
            //    {
            //        palindrom = myStringArrayForTask4[inputNumber];
            //        Console.WriteLine($"Слово  \"{myStringArrayForTask4[inputNumber]}\" палиндром.\n" +
            //        $"Введите 1 чтобы проверить другое слово. 0 - закончить");
            //        int continueOrNot = Convert.ToInt32(Console.ReadLine());
            //        if (continueOrNot == 1) { goto inputAgain; }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Слово  \"{myStringArrayForTask4[inputNumber]}\" не является палиндромом.\n" +
            //        $"Введите 1 чтобы проверить другое слово. 0 - закончить");
            //        int continueOrNot = Convert.ToInt32(Console.ReadLine());
            //        if (continueOrNot == 1) { goto inputAgain; }
            //    }


            // task 5                     --------------------------------------

            //Console.WriteLine("Введите строку для задачи №5:");
            //string myStringForTask5 = Console.ReadLine();
            //StringBuilder resultString = new StringBuilder(myStringForTask5);
            //for (int i = 0; i < myStringForTask5.Length; i++)
            //{
            //    resultString.Insert(i + i, myStringForTask5.Substring(i, 1));
            //}
            //Console.WriteLine(resultString);


        }
    }
}