public class BTNode
{
  public BTNode left;
  public BTNode right;
  public object value;
  public BTNode sibling;
  public bool hasSibling;
  public BTNode parent;

  public BTNode()
  {
    left = null;
    right = null;
    sibling = null;
    hasSibling = false;
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

  public BTNode GetSibling() => sibling;

  public void SetSibling(BTNode sibling)
  {
    this.sibling = sibling;
    hasSibling = true;
  }

  public bool HasSibling() => hasSibling;

  public bool IsLeaf()
  {
    return (left == null) && (right == null);
  }
}