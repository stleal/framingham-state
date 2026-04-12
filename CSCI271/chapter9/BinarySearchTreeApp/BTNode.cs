public class BTNode
{
  public BTNode left;
  public BTNode right;
  public object value;
  public BTNode parent;

  public BTNode()
  {
    left = null;
    right = null;
  }

  public BTNode(object o)
  {
    value = o;
    left = null;
    right = null;
  }

  public BTNode GetLeft() => left;
  public void SetLeft(object o) => left = new BTNode(o);
  public BTNode GetRight() => right;
  public void SetRight(object o) => right = new BTNode(o);
  public BTNode GetParent() => parent;
  public void SetParent(BTNode n) => parent = n;
  public bool IsLeaf()
  {
    return (left == null) && (right == null);
  }
}