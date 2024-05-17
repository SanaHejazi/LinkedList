using System;

namespace LInkedList
{
 internal class Program
 {
  static void Main(string[] args)
  {

   MyLinkedList list = new MyLinkedList();
   list.AddDataToTheLast(1);
   list.AddDataToTheLast(2);
   list.AddDataToTheLast(3);
   list.AddDataToTheFirst(4);
   list.PrintForward();
   Console.WriteLine();
   list.PrinBackward();
   Console.WriteLine();
   list.reverse_Nonrecursive();
   Console.WriteLine();
   list.reverse_recursive(list.ReturnHead());
   Console.WriteLine();
   Console.WriteLine("----------Doubly Linked List-----------");

   MyDoublyLinkedList doublyLinkedList = new MyDoublyLinkedList();
   doublyLinkedList.AddToFirst(1);
   doublyLinkedList.AddToFirst(2);
   doublyLinkedList.AddToFirst(3);
   doublyLinkedList.AddToFirst(4);
   doublyLinkedList.dsiaplay();
   Console.WriteLine();
   doublyLinkedList.Shift(-3);
   doublyLinkedList.dsiaplay();
   //doublyLinkedList.ToDoublyLinkedList(list);

   Console.ReadKey();
  }
 }
}
