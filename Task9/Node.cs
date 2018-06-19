using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node()
        {

        }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }

        public Node(int data, Node next)
        {
            Data = data;
            Next = next;
        }

        public static Node CreateList(Node p, int number, int maxNumber)
        {
            if (p == null || p.Data == 0)
                p = new Node(number);

            if (maxNumber != number)
                p.Next = CreateList(p.Next, number + 1, maxNumber);

            return p;
        }

        public static Node Search(Node p, int number)
        {
            if (p != null)
            {
                if (p.Data == number)
                    return p;
                else
                    return Search(p.Next, number);
            }

            return null;
        }

        public static Node Remove(Node p, int number)
        {
            if (p == null)
                return null;
            if (p.Data == number)
                return p.Next;

            return new Node(p.Data, Remove(p.Next, number));
        }

        public static void PrintList(Node root)
        {
            if (root == null)
                Console.Write("Список пуст.");
            else
            {
                Node p = root;
                while (p != null)
                {
                    Console.Write($"{p.Data} ");
                    p = p.Next;
                }
            }

            Console.WriteLine();
        }
    }
}
