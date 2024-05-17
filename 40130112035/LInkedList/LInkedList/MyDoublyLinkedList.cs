using System;

namespace LInkedList
{
 internal class MyDoublyLinkedList
 {
  private DoublyNode Head;

  public MyDoublyLinkedList() { Head = null; }
  public void AddToFirst(int data)
  {
   DoublyNode node = new DoublyNode(data);

   if (Head == null)
   {
    node.next = Head;
    Head = node;
   }
   else
   {
    Head.previous = node;
    node.next = Head;
    Head = node;
   }

  }

  public void Shift(int m)
  {
   if (Head == null)
    return;


   DoublyNode current = Head;
   int length = 1;
   while (current.next != null)
   {
    current = current.next;
    length++;
   }
   int k = Math.Abs(m);
   // If k is greater than the length, we should use k % length
   k = k % length;
   if (k == 0)
    return;

   current.next = Head;
   Head.previous = current;


   if (m > 0)
   {
    current = Head;
    for (int i = 0; i < length - k - 1; i++)
    {
     current = current.next;
    }

   }
   else
   {
    for (int i = 0; i < length - k; i++)
    {
     current = current.previous;
    }

   }


   Head = current.next;
   current.next = null;

  }

  public void ToDoublyLinkedList(MyLinkedList list)
  {
   Node index = list.ReturnHead();
   while (index != null)
   {
    AddToFirst(index.data);
    index = index.next;
   }
  }   //go to Debug > Windows > Autos To See its Doubly LinkedList...(in visual studio...)


  public void dsiaplay()
  {
   if (Head == null)
   {
    Console.WriteLine("List Is Empty");
   }
   else
   {
    DoublyNode index = Head;
    while (index != null)
    {
     Console.Write(index.data + " ");
     index = index.next;
    }
   }
  }


 }
}
