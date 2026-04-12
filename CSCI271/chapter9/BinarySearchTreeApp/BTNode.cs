public class BTNode
{
  public BTNode? left;
  public BTNode? right;
  public object? value;
  public BTNode? parent;

  public BTNode()
  {
    left = null;
    right = null;
    value = null;
    parent = null;
  }

  public BTNode(object o)
  {
    value = o;
    left = null;
    right = null;
    parent = null;
  }

  public override string ToString()
  {
    return value?.ToString() ?? string.Empty;
  }

  public BTNode? GetLeft() => left;
  public void SetLeft(object o) => SetLeft(new BTNode(o));
  public void SetLeft(BTNode? n)
  {
    left = n;
    if (n != null)
      n.parent = this;
  }
  public BTNode? GetRight() => right;
  public void SetRight(object o) => SetRight(new BTNode(o));
  public void SetRight(BTNode? n)
  {
    right = n;
    if (n != null)
      n.parent = this;
  }
  public BTNode? GetParent() => parent;
  public void SetParent(BTNode? n) => parent = n;
  public object? GetValue() => value;
  public bool IsLeaf()
  {
    return (left == null) && (right == null);
  }
}