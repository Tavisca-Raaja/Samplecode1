using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the DataStructure you want to work With:");
            Console.WriteLine("1. LinkedList");
            Console.WriteLine("2. Stack");
            Console.WriteLine("3. Queue");
            int Choice = Convert.ToInt32(Console.ReadLine());
            int ContinueProcess = 1;
            switch(Choice)
            {
                case 1:
                    LinkedList Lst = new LinkedList();
                    Console.WriteLine("Linked List Functionalities:");
                    do
                    {
                        
                        Console.WriteLine("1. AddElement  2.DisplayELement  3.RemoveElement  4.SortElement 5.InsertAtSpecific 6.RemoveAtSpecific");
                        int FunctionChoice = Convert.ToInt32(Console.ReadLine());
                        if (FunctionChoice == 1)
                            Lst.AddElements();
                        else if (FunctionChoice == 2)
                            Lst.DisplayElements();
                        else if (FunctionChoice == 3)
                            Lst.RemoveElements();
                        else if (FunctionChoice == 4)
                            Lst.SortElements();
                        else if (FunctionChoice == 5)
                            Lst.InsertAtSpecific();
                        else
                            Lst.RemoveElements();
                    } while (ContinueProcess == 1);
                    break;
            }

        }
    }
}
