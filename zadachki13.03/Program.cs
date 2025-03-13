using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachki13._03
{
    internal class Program
    {
        static void Main()
        {
            LinkedList<int> numbers = new LinkedList<int>();

            int[] values = { 42, 7, 19, 3, 88, 56 };
            foreach (int val in values)
            {
                numbers.AddLast(val);
            }

            List<int> sortedList = new List<int>(numbers);
            sortedList.Sort();
            numbers = new LinkedList<int>(sortedList);

               
            Console.WriteLine("Sorted Linked List:");
            PrintLinkedList(numbers);

            Console.WriteLine(SearchNumber(numbers, 19));
            Console.WriteLine(SearchNumber(numbers, 100));

            LinkedList<int> reversedList = ReverseLinkedList(numbers);
            Console.WriteLine("Reversed Linked List:");
            PrintLinkedList(reversedList);
        }

        static void PrintLinkedList(LinkedList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");
        }
        static string SearchNumber(LinkedList<int> list, int num)
        {
            return list.Contains(num) ? $"Числото {num} е в списъка!" : $"Числото {num} не е в списъка!";
        }

        static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversed = new LinkedList<int>();
            foreach (var item in list)
            {
                reversed.AddFirst(item);
            }
            return reversed;
        }

    }
}
