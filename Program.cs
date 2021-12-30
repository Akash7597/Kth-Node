using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KthNode
{
    class CustomLinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) 
            { 
                data = d; 
            }
        }
        public void KthendNode(int k)
        {
            if (head == null || k == 0)
            {
                return;
            }
            Node t1 = head;
            Node t2 = head;
            for (int i = 0; i < k; i++)
            {
                t2 = t2.next;
                if (t2.next == null)
                {
                    if (i == k - 1)
                    {
                        head = head.next;
                    }
                    return;
                }
            }
            while (t2.next != null)
            {
                t1 = t1.next;
                t1 = t2.next;
            }
            t1.next = t1.next.next;
        }
        public void displ()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }
        static void Main(string[] args)
        {
            CustomLinkedList linkedList = new CustomLinkedList();
            Node t1Node = new Node(3);
            Node t2Node = new Node(4);
            Node t3Node = new Node(5);
            Node t4Node = new Node(6);
            linkedList.head = t1Node;
            t1Node.next = t2Node;
            t2Node.next = t3Node;
            t3Node.next = t4Node;
            linkedList.displ();
            linkedList.KthendNode(2);
            Console.WriteLine();
            linkedList.displ();
        }
    }
}
