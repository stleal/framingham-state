public class IntQueueNode
{
  public int data { get; set; }
  public IntQueueNode? next { get; set; }

  public IntQueueNode(int n)
  {
    this.data = n;
    this.next = null;
  }

  public void SetNext(IntQueueNode n) => this.next = n;

  public IntQueueNode? GetNext() => this.next;

}