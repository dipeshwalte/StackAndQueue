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

        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("No element is present to pop");
                return;
            }
            Console.WriteLine("The element to be popped is " + top.data);

        }

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("No element is present to pop");
                return;
            }
        }

        public void IsEmpty()
        {



        }
    }
}
