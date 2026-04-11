/************************
 * Name: Mr. Sam Leal
 * Date: 04/10/2024
 ***********************/
public class Program
{
  public static void Main(string[] args)
  {
    var index = 4;
    var value = 64;
    LinkedList l = CreateLinkedList();
    LinkedList answer = new LinkedList();

    // print the original list
    Console.WriteLine("Original List:");
    l.Print();

    // remove every nth item from the list and print the resulting list
    answer = RemoveNthItems(l, 3);
    Console.WriteLine("List after removing every 3rd item:");
    answer.Print();

    // reverse the list and print the resulting list
    answer = ReverseLinkedList(l);
    Console.WriteLine("Reversed List:");
    answer.Print();

    // insert a new value at a specific index and print the resulting list
    InsertAtSpecificIndex(l, index, value);
    Console.WriteLine("List after inserting " + value + " at index " + index + ":");
    l.Print();
  }

  public static void InsertAtSpecificIndex(LinkedList l, int index, object o)
  {
    l.InsertAtIndex(index, o);
  }

  public static LinkedList ReverseLinkedList(LinkedList l)
  {
    return l.Reverse();
  }

  public static LinkedList RemoveNthItems(LinkedList l, int n)
  {
    return l.RemoveNthItems(n);
  }

  public static LinkedList CreateLinkedList()
  {
    LinkedList l = new LinkedList();
    // create a new linked list with integer values from 0-15
    for (int i = 1; i < 17; i++)
    {
      l.Insert(i);
    }
    return l;
  }
}