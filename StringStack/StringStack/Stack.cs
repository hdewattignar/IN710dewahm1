using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStack
{
    public class Stack
    {
        StringNode head = null;
        StringNode tail = null;

        public Stack()
        {
            
        }

        public void Push(string newString)
        {
            StringNode newNode = new StringNode(newString);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public String Pop()
        {
            if (tail != null)
            {
                String returnString = tail.nodeString; 

                //get the string from the last added node on stack
                StringNode nodeWalker = head;

                //remove the last node from the stack
                while (nodeWalker != null)
                {
                    //if there is only one node on the stack
                    if (head == tail)
                    {
                        head = null;
                        tail = null;
                    }

                    //
                    else if (nodeWalker.Next == tail)
                    {
                        tail = nodeWalker;
                    }

                    nodeWalker = nodeWalker.Next;
                }                

                return returnString;                
            }
            else
                return "";
        }

        public String Peek()
        {
            if (tail != null)
            {
                return tail.nodeString;
            }
            else
                return "";
        }

        public int Count()
        {
            int count = 0;

            StringNode nodeWalker = head;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }

            return count;
        }

        public bool IsEmpty()
        {
            if (head == null && tail == null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
