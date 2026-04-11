public class IntQueue
{

  public int size { get; set; }
  public int[] data { get; set; }
  public IntQueueNode? next { get; set; }
  public IntQueueNode? first { get; set; }
  public IntQueueNode? last { get; set; }

  public IntQueue()
  {
    size = 256;
    data = new int[size];
    next = null;
    first = null;
    last = null;
  }

  public void Enqueue(int n)
  {
    IntQueueNode t = new IntQueueNode(n);
    if (last != null)
      last.SetNext(t);
    last = t;
    if (first == null)
      first = last;
  }

  public int Dequeue()
  {
    if (first == null)
      throw new Exception("Queue is empty");
      int data = first.data;
      first = first.GetNext();
    if (first == null)
      last = null;
    return data;
  }

  public int Peek()
  {
    if (first == null)
      throw new Exception("Queue is empty");
    return first.data;
  }

  public bool IsEmpty() => first == null;

}