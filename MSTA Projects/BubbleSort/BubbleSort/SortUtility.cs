using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortUtility
{
    public class BubbleSort
    {
        public int[] Sort(int[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        //swap
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return numbers;
        }
        public int[] Reverse(int[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = numbers.Length - 1; i > 0; i--)
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        //swap
                        int temp = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return numbers;
        }

        public void DisplayBubbles(int[] numbers)
        {
            Console.WriteLine("----------------------------");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
