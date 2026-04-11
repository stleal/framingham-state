public class FilteringEvenAndOddDigitsDriver
{
  public void Filter(IntQueue q)
  {
    var count = 0;
    IntQueue evenQueue = new IntQueue();
    IntQueue oddQueue = new IntQueue();
    while (!q.IsEmpty())
    {
      var value = q.Dequeue();
      if (value % 2 == 0)
      {
        evenQueue.Enqueue(value);
      }
      else
      {
        oddQueue.Enqueue(value);
      }
    }
    Console.WriteLine("Even Queue:");
    while (!evenQueue.IsEmpty())
    {
      Console.WriteLine(evenQueue.Dequeue());
      count++;
    }
    Console.WriteLine("Even Queue Size: " + count);
    count = 0;
    Console.WriteLine("Odd Queue:");
    while (!oddQueue.IsEmpty())
    {
      Console.WriteLine(oddQueue.Dequeue());
      count++;
    }
    Console.WriteLine("Odd Queue Size: " + count);
  }
}