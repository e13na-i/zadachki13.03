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

            RemoveNumber(numbers, 42);


            LinkedList<int> list1 = new LinkedList<int>(new int[] { 1, 5, 10 });
            LinkedList<int> list2 = new LinkedList<int>(new int[] { 2, 6, 12 });


            LinkedList<int> mergedList = MergeSortedLists(list1, list2);

            Console.WriteLine("Обединен сортиран списък:");
            PrintLinkedList(mergedList);
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

        static void RemoveNumber(LinkedList<int> list, int num)
        {
            if (list.Remove(num))
            {
                Console.WriteLine($"Item {num} has been removed successfully.");
            }
            else
            {
                Console.WriteLine($"Item {num} has failed to be removed.");
            }
        }

        static LinkedList<int> MergeSortedLists(LinkedList<int> list1, LinkedList<int> list2)
        {
            LinkedList<int> mergedList = new LinkedList<int>();
            LinkedListNode<int> node1 = list1.First;
            LinkedListNode<int> node2 = list2.First;


            while (node1 != null && node2 != null)
            {
                if (node1.Value < node2.Value)
                {
                    mergedList.AddLast(node1.Value);
                    node1 = node1.Next;
                }
                else
                {
                    mergedList.AddLast(node2.Value);
                    node2 = node2.Next;
                }
            }

            while (node1 != null)
            {
                mergedList.AddLast(node1.Value);
                node1 = node1.Next;
            }

            while (node2 != null)
            {
                mergedList.AddLast(node2.Value);
                node2 = node2.Next;
            }

            return mergedList;
        }

    }
}

