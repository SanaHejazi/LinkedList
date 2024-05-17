using System;

namespace LInkedList
{
 internal class Program
 {
  static void Main(string[] args)
  {

   MyLinkedList list = new MyLinkedList();
   //Test Other Function In MyLinkedLIST Class...
   list.AddDataToTheLast(3);
   list.AddDataToTheLast(4);
   list.AddDataToTheLast(5);
   list.AddDataToTheFirst(7);
   list.AddDataToTheFirst(8);
   list.AddDataToTheFirst(9);
   list.PrintForward();
   Console.WriteLine();
   list.PrinBackward();
   Console.WriteLine();
   list.reverse_Nonrecursive();
   Console.WriteLine();
   list.reverse_recursive(list.ReturnHead());
   Console.WriteLine();
   list.Search(9);
   Console.WriteLine();
   Console.WriteLine("----------Doubly Linked List-----------");
   //Test Other Function In MyDoublyLinkedLIST Class...
   MyDoublyLinkedList doublyLinkedList = new MyDoublyLinkedList();
   doublyLinkedList.AddToFirst(1);
   doublyLinkedList.AddToFirst(2);
   doublyLinkedList.AddToFirst(3);
   doublyLinkedList.AddToFirst(4);
   doublyLinkedList.dsiaplay();
   Console.WriteLine();
   doublyLinkedList.Shift(-3);
   doublyLinkedList.dsiaplay();
   //doublyLinkedList.ToDoublyLinkedList(list);       //uncomment this line to see this function...

   Console.ReadKey();
  }
 }
}
