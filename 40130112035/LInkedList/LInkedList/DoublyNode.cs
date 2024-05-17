namespace LInkedList
{
 internal class DoublyNode
 {
  public int data { get; set; }
  public DoublyNode next { get; set; }
  public DoublyNode previous { get; set; }

  public DoublyNode(int data)
  {
   this.data = data;
   next = null;
   previous = null;
  }

 }
}
