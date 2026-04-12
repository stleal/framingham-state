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
    data = new BTNode[objs.Length];
    for (int i = 0; i < objs.Length-1; i++)
    {
      BTNode root = new BTNode(objs[i/2]);
      if (i == 0)
        data[0] = root;
      BTNode child = new BTNode(objs[2*i/2]);
        data[i] = child;
      root.SetLeft(child);
      child = new BTNode(objs[2*(i+1)/2]);
        data[i+1] = child;
      root.SetRight(child);
    }
  }

  public void CreateTree(string s)
  {
    data = new BTNode[s.Length];
    for (int i = 0; i < s.Length-1; i++)
    {
      BTNode root = new BTNode(s[i/2]);
      if (i == 0)
        data[0] = root;
      BTNode child = new BTNode(s[2*i/2]);
        data[i] = child;
      root.SetLeft(child);
      child = new BTNode(s[2*(i+1)/2]);
        data[i+1] = child;
      root.SetRight(child);
    }
  }
}