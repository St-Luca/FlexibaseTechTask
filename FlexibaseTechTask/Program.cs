using System.Text;
using System.Collections.Generic;

public class Solution
{
    /// <summary>
    ///  Метод, выполняющий задания 1 и 2 ТЗ
    /// </summary>
    private static List<object> ReplaceDigits(List<object> digits)
    {
        for (int i = 0; i < digits.Count; i++)
        {
            int num = Convert.ToInt32(digits[i]);
            StringBuilder stringBuilder = new StringBuilder();

            if (num % 3 == 0)
            {
                stringBuilder.Append("fizz");
                if (num % 5 == 0)
                {
                    stringBuilder.Append("-buzz");
                }
            }

            if (num % 4 == 0)
            {
                AppendWithHyphen(stringBuilder, "muzz");

                if (Convert.ToInt32(digits[i]) % 7 == 0)
                {
                    stringBuilder.Append("-guzz");
                }
            }

            if (num % 5 == 0 && !stringBuilder.ToString().Contains("buzz"))
            {
                AppendWithHyphen(stringBuilder, "buzz");
            }

            if (num % 7 == 0 && !stringBuilder.ToString().Contains("guzz"))
            {
                AppendWithHyphen(stringBuilder, "guzz");
            }

            if (stringBuilder.Length > 0)
            {
                digits[i] = stringBuilder.ToString();
            }
        }

        return digits;
    }

    /// <summary>
    ///  Метод, выполняющий задание 3 ТЗ
    /// </summary>
    private static List<Object> ReplaceDigits2(List<Object> digits)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < digits.Count; i++)
        {
            int num = Convert.ToInt32(digits[i]);
            stringBuilder.Clear();

            if (num % 3 == 0)
            {
                if (num % 5 == 0)
                {
                    stringBuilder.Append("good-boy");
                }
                else stringBuilder.Append("dog");
            }
            if (num % 4 == 0)
            {
                AppendWithHyphen(stringBuilder, "muzz");

                if (num % 7 == 0)
                {
                    stringBuilder.Append("-guzz");
                }
            }
            if (num % 5 == 0 && !stringBuilder.ToString().Contains("good-boy"))
            {
                AppendWithHyphen(stringBuilder, "cat");
            }
            if (num % 7 == 0 && !stringBuilder.ToString().Contains("guzz"))
            {
                AppendWithHyphen(stringBuilder, "guzz");
            }

            if (stringBuilder.Length > 0)
            {
                digits[i] = stringBuilder.ToString();
            }
        }
        return digits;
    }

    /// <summary>
    /// Метод для добавления в StringBuilder
    /// </summary>
    private static void AppendWithHyphen(StringBuilder stringBuilder, string value)
    {
        if (stringBuilder.Length > 0)
        {
            stringBuilder.Append("-");
        }
        stringBuilder.Append(value);
    }

    /// <summary>
    ///  Метод для вывода как в сообщении
    /// </summary>
    private static void PrintList(List<Object> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (i < list.Count - 1)
            {
                Console.Write(list[i] + ", ");
            }
            else Console.Write(list[i] + " ");
        }
    }


    static void Main(string[] args)
    {
        List<Object> example1 = ReplaceDigits(new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 });
        PrintList(example1);

        Console.WriteLine();

        List<Object> example2 = ReplaceDigits2(new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 });
        PrintList(example2);
    }
}