/************************
 * Name: Mr. Sam Leal
 * Date: 04/10/2024
 ***********************/
public class Node
{
  public object? value { get; set; }
  public Node? prev { get; set; }
  public Node? next { get; set; }

  public Node()
  {
    value = null;
  }

  public Node(object n)
  {
    value = n;
  }

  public void SetPrevious(Node? n) => prev = n;

  public void SetNext(Node? n) => next = n;

  public object? GetValue() => value;

  public Node? GetPrevious() => prev;

  public Node? GetNext() => next;

}