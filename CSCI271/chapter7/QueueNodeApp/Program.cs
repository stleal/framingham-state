public class Program
{
  public static void Main(string[] args)
  {
    FilteringEvenAndOddDigitsDriver filterDriver = new FilteringEvenAndOddDigitsDriver();
    IntQueue q = new IntQueue();
    for (int i = 0; i <= 255; i++)
    {
      q.Enqueue(i);
    }
    filterDriver.Filter(q);
  }

  public static void Sample()
  {
    IntQueue q = new IntQueue();
    q.Enqueue(1);
    q.Enqueue(2);
    q.Enqueue(3);
    q.Enqueue(4);
    var result = q.Dequeue();
    Console.WriteLine(result);
    result = q.Dequeue();
    Console.WriteLine(result);
    result = q.Dequeue();
    Console.WriteLine(result);
    result = q.Dequeue();
    Console.WriteLine(result);
  }
}