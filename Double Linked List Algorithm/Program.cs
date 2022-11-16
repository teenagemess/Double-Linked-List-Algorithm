using System;
using System.Collections.Generic;
using System.Linq;
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
}
