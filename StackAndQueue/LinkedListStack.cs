using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class LinkedListStack
    {
        Node top;
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine($"New Node {newData} is added to the top");
        }

        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("No values to display");
                return;
            }
            Console.WriteLine("Top -> "+temp.data );
            temp = temp.next;
            while (temp != null)
            {
                Console.WriteLine("       "+temp.data);
                temp = temp.next;
            }
            Console.WriteLine();

        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("No element is present to pop");
                return;
            }
            Console.WriteLine("The element to be popped is " + top.data);
            top = top.next;
        }

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("No element is present to peek");
                return;
            }
            Console.WriteLine("Peeked Element is :" + top.data);
        }

        public void peekAndPopTillEmpty()
        {
            while (top != null)
            {
                this.Peek();
                this.Pop();
                Console.WriteLine("-----------------");
                Console.WriteLine("Displaying stack:");
                this.Display();
                Console.WriteLine("-----------------");
            }


        }
    }
}
