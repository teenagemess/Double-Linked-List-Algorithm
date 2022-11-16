using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List_Algorithm
{
    class Node
    {
        /*Node class represent the node of doubly linked list.
         * It consists of the information part and links to
         * its succeeding and preceeding nodes
         * in terms of the next and previous nodes. */
        public int rollNumber;
        public string name;
        public Node next; //points to the succeeding node
        public Node prev; //points to the preceeding node
    }
    class DoubleLinkedLists
    {
        Node START;
        public DoubleLinkedLists()
        {
            START = null;
        }
        public void addNode() //adds a new node
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEenter the name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            //checks if the list is empty
            if(START == null || rollNo <= START.rollNumber)
            {
               if((START != null) && (rollNo == START.rollNumber))
               {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
               }
                newnode.next = START;
                if (START != null)
                    START.prev = newnode;
                newnode.prev = null;
                START = newnode;
                return;
            }
            Node previous, current;
            for (current = previous = START; current != null && rollNo >= current.rollNumber; previous = current, current = current.next);
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
            }
        }
    }
}
