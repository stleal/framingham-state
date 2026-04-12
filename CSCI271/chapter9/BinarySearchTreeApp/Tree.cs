public class Tree
{
  public BTNode root;
  public BTNode[] data;

  public Tree()
  {
    root = null;
    data = null;
  }

  public Tree(object[] objs)
  {
    CreateTree(objs);
  }

  public BTNode GetRoot() => root;

  public void CreateTree(object[] objs)
  {
    BTNode child = new BTNode();
    BTNode parent = new BTNode();
    data = new BTNode[objs.Length];
    for (int i = 1; i < objs.Length-1; i+=2)
    {
      data[i/2] = new BTNode(objs[i/2]);
      parent = data[i/2];
      child = new BTNode(objs[2*i/2]);
        data[i] = child;
      parent.SetLeft(child);
      child = new BTNode(objs[2*(i+1)/2]);
        data[i+1] = child;
      parent.SetRight(child);
    }
  }
}