using System.Collections.Generic;

internal static class ProgramHelpers
{

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