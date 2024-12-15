using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = digits.Length;

            do
            {
                long number = 0;
                for (int i = 0; i < n; i++)
                {
                    number = number * 10 + digits[i];
                }

                // Provjera svih uvjeta djeljivosti
                if (number % 9 == 0)
                {
                    int temp = number;
                    for (int j = 8; j >= 1; j--)
                    {
                        temp /= 10;
                        if (temp % j != 0)
                        {
                            break;
                        }
                        if (j == 1)
                        {
                            Console.WriteLine(number);
                            break;
                        }
                    }
                }

                // Generiranje sljedeće permutacije
                int i = n - 2;
                while (i >= 0 && digits[i] >= digits[i + 1])
                {
                    i--;
                }

                if (i >= 0)
                {
                    int j = n - 1;
                    while (digits[j] <= digits[i])
                    {
                        j--;
                    }

                    int temp = digits[i];
                    digits[i] = digits[j];
                    digits[j] = temp;

                    Array.Sort(digits, i + 1, n - i - 1);
                }
            } while (i >= 0);
        }
    }
}
