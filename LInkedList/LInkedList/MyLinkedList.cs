using System;
using System.Collections.Generic;

namespace LInkedList
{
 internal class MyLinkedList
 {
  private Node Head;
  public MyLinkedList() { Head = null; }
  public void AddDataToTheFirst(int data)
  {
   Node node = new Node(data);
   node.next = Head;
   Head = node;
  }

  public void AddDataToTheLast(int data)
  {
   Node node = new Node(data);

   if (Head == null)
   {
    node.next = Head;
    Head = node;
   }
   else
   {
    Node index = Head;
    while (index.next != null)
    {
     index = index.next;
    }
    index.next = node;

   }
  }

  public void RemoveDataFromFirst()
  {
   Head = Head.next;
  }

  public void RemoveDataFromLast()
  {
   if (Head == null)
   {
    Console.WriteLine("List Is Empty");
   }
   else
   {
    Node index = Head;
    while (index.next.next != null)
    {
     index = index.next;
    }
    index.next = index.next.next;

   }
  }

  public void Search(int value)
  {
   Node index = Head;
   int counter = 0;
   try
   {
    while (index.data != value)
    {
     index = index.next;
     counter++;
    }
    Console.WriteLine(counter);
   }
   catch
   {

    Console.WriteLine("This Value Is Not In Your List");
   }
  }

  public void Clear()
  {
   while (Head.next != null)
   {
    Head = Head.next;
   }
   Head = Head.next;
  }
  public void Size()
  {
   Node index = Head;
   int counter = 0;

   while (index != null)
   {
    index = index.next;
    counter++;
   }

   Console.WriteLine(counter);
  }

  public void PrintForward()
  {
   if (Head == null)
   {
    Console.WriteLine("List Is Empty");
   }
   else
   {
    Node index = Head;
    while (index != null)
    {
     Console.Write(index.data + " ");
     index = index.next;
    }
   }
  }

  public void PrinBackward()
  {
   List<int> Temp = new List<int>();
   Node index = Head;
   while (index != null)
   {
    Temp.Add(index.data);
    index = index.next;
   }

   for (int i = Temp.Count - 1; i >= 0; i--)
   {
    Console.Write(Temp[i] + " ");
   }
  }


  public void dsiaplay()
  {
   if (Head == null)
   {
    Console.WriteLine("List Is Empty");
   }
   else
   {
    Node index = Head;
    while (index != null)
    {
     Console.Write(index.data + " ");
     index = index.next;
    }
   }
  }
 }
}
