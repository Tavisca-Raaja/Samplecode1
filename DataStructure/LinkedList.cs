using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Node
    {
       public string Data;
        Node Next;
       public Node()
        {
            this.Data ="";
            this.Next = null;
        }
    }
    class LinkedList : IFunctionality
    {
        Node node=null;
        public void AddElements()
        {
            if(node==null)
            {
                node = new Node();
                node.Data=co
            }

        }

        public void DisplayElements()
        {
            throw new NotImplementedException();
        }

        public void RemoveElements()
        {
            throw new NotImplementedException();
        }

        public void SortElements()
        {
            throw new NotImplementedException();
        }
        public void InsertAtSpecific()
        {

        }
        public void RemoveAtSpecific()
        {

        }
    }
}
