using System.Collections.Generic;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            if (list == null || list.Count <= 1)
            {
                return list;
            }

            for (LinkedListNode<int> i = list.First; i != null; i = i.Next)
            {
                LinkedListNode<int> minNode = i;

                for (LinkedListNode<int> j = i.Next; j != null; j = j.Next)
                {
                    if (j.Value < minNode.Value)
                    {
                        minNode = j;
                    }
                }

                if (minNode != i)
                {
                    int temp = i.Value;
                    i.Value = minNode.Value;
                    minNode.Value = temp;
                }
            }

            return list;
        }

        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            if (list == null || list.Count <= 1)
            {
                return list;
            }

            for (LinkedListNode<int> i = list.First; i != null; i = i.Next)
            {
                LinkedListNode<int> maxNode = i;

                for (LinkedListNode<int> j = i.Next; j != null; j = j.Next)
                {
                    if (j.Value > maxNode.Value)
                    {
                        maxNode = j;
                    }
                }

                if (maxNode != i)
                {
                    int temp = i.Value;
                    i.Value = maxNode.Value;
                    maxNode.Value = temp;
                }
            }

            return list;
        }
    }
}

