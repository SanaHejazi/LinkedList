using System;

namespace LInkedList
{
 internal class Program
 {
  static void Main(string[] args)
  {
   MyLinkedList linkedList = new MyLinkedList();
   linkedList.AddDataToTheLast(1);
   linkedList.AddDataToTheLast(2);
   linkedList.AddDataToTheLast(3);
   linkedList.AddDataToTheLast(4);
   linkedList.PrinBackward();
   Console.ReadKey();
  }
 }
}
