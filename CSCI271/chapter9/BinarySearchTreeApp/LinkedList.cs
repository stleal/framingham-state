/************************
 * Name: Mr. Sam Leal
 * Date: 04/10/2024
 ***********************/
public class LinkedList
{
  public Node head { get; set; }
  public Node tail { get; set; }
  public Node? cursor { get; set; }
  public Node prev { get; set; }
  public int size { get; set; }

  public LinkedList()
  {
    head = new Node();
    tail = new Node();
    cursor = head;
    prev = new Node();
    size = 0;
  }

  public void Insert(object o)
  {
    Node n = new Node(o);
    cursor?.SetNext(n);
    n.SetPrevious(cursor);
    n.SetNext(tail);
    tail.SetPrevious(n);
    cursor = n;
    size++;
  }

  public void InsertAtIndex(int index, object o)
  {
    if (index != 0 && size != 0 && index > size-1)
      throw new Exception("Index out of bounds exception.");
    cursor = head;
    if (cursor.GetNext() == null)
    {
      Node n = new Node(o);
      cursor.SetNext(n);
      n.SetPrevious(cursor);
      n.SetNext(tail);
      tail.SetPrevious(n);
      cursor = n;
    }
    else
    {
      for (int i = 0; i <= index; i++)
      {
        cursor = cursor?.GetNext();
        if (i == index-1)
        {
          Node n = new Node(o);
          Node prevNext = cursor?.GetNext()!;
          cursor?.SetNext(n);
          n.SetPrevious(cursor);
          n.SetNext(prevNext);
        }
      }
    }
    size++;
  }

  public LinkedList Reverse()
  {
    LinkedList result = new LinkedList();
    this.SetCursor(this.GetTail());
    for (int i = 0; i < this.GetSize(); i++)
    {
      this.SetCursor(this.GetCursor().GetPrevious()!);
      result.Insert(this.GetCursor().GetValue()!);
    }
    return result;
  }

  public void Remove(Node? n)
  {
    n?.GetPrevious()!.SetNext(n.GetNext());
    n?.GetNext()!.SetPrevious(n.GetPrevious());
    n = null;
    size--;
  }

  public LinkedList RemoveNthItems(int n)
  {
    var counter = 0;
    var size = this.GetSize();
    LinkedList l2 = new LinkedList();
    LinkedList result = new LinkedList();
    l2 = this.Copy();
    l2.SetCursor(l2.GetHead());
    for (int i = 0; i < size; i++)
    {
      l2.SetCursor(l2.GetCursor().GetNext()!);
      if (counter < n-1)
      {
        result.Insert(l2.GetCursor().GetValue()!);
        counter++;
      }
      else
      {
        l2.Remove(l2.GetCursor());
        counter = 0;
      }
    }
    return result;
  }

  public void Print()
  {
    cursor = head.GetNext();
    Console.Write("HEAD-->");
    for (int i = 0; i < size; i++)
    {
      Console.Write(cursor?.GetValue() + "-->");
      cursor = cursor?.GetNext();
    }
    Console.WriteLine("TAIL");
    cursor = this.tail.GetPrevious();
  }

  public LinkedList Copy()
  {
    LinkedList l = new LinkedList();
    this.SetCursor(this.GetHead());
    for (int i = 0; i < size; i++)
    {
      this.SetCursor(this.GetCursor().GetNext()!);
      l.Insert(this.GetCursor().GetValue()!);
    }
    return l;
  }

  public int GetSize() => size;

  public Node GetCursor() => cursor!;

  public void SetCursor(Node n) => cursor = n;

  public Node GetHead() => head;

  public Node GetTail() => tail;

}