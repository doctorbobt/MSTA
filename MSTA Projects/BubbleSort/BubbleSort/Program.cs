using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortUtility;
namespace BubbleSortFun
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bs = new BubbleSort();
            int[] unSortedNumbers = {9,8,7,6,5,4,3,2,1};
            bs.DisplayBubbles(unSortedNumbers);
            int[] sortedNumbers = bs.Sort(unSortedNumbers);
            bs.DisplayBubbles(sortedNumbers);
            int[] reSortedNumbers = bs.Reverse(sortedNumbers);
            bs.DisplayBubbles(reSortedNumbers);
            Console.Read();
        }
        
    }
}
