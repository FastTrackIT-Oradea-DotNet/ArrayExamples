using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExamples.Library
{
    public static class ConsoleHelper
    {
        public static int ReadNumber(string message, int maxAttempts, int defaultValue)
        {
            int attemptsCount = 1;
            bool isNumber = false;

            while (!isNumber)
            {
                Console.Write(message);
                string text = Console.ReadLine();

                isNumber = int.TryParse(text, out int number);

                if (isNumber)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"'{text}' is not a number, try again ({maxAttempts - attemptsCount} attempts remaining) ...");
                }

                attemptsCount++;

                if (attemptsCount > maxAttempts)
                {
                    Console.WriteLine($"Max attempts count exceeded, asuming {defaultValue} as default value ...");
                    return defaultValue;
                }
            }

            return defaultValue;
        }

        public static int[] ReadArrayFromConsole(string arrayName)
        {
            int length = ReadNumber($"{arrayName} Length=", 3, 0);

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = ReadNumber($"{arrayName} Element[{i}]=", 3, 0);
            }

            return array;
        }

        public static void PrintArray(string arrayName, int[] array)
        {
            string arrayElements = string.Join(", ", array ?? new int[] { });

            Console.WriteLine($"{arrayName} = [{arrayElements}]");
        }
    }
}
