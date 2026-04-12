public class Tree
{
  public BTNode? root;
  public BTNode[] data;

  public Tree()
  {
    root = null;
    data = Array.Empty<BTNode>();
  }

  public Tree(object[] objs)
  {
    data = Array.Empty<BTNode>();
    CreateTree(objs);
  }

  public BTNode? GetRoot() => root;

  public void Print()
  {
    if (root == null)
      return;

    Queue<BTNode> nodes = new Queue<BTNode>();
    nodes.Enqueue(root);

    while (nodes.Count > 0)
    {
      BTNode current = nodes.Dequeue();
      Console.WriteLine(current.GetValue());

      if (current.GetLeft() != null)
        nodes.Enqueue(current.GetLeft()!);

      if (current.GetRight() != null)
        nodes.Enqueue(current.GetRight()!);
    }
  }

  public int GetHeight()
  {
    var height = 0;
    var count = 0;
    var counter = 0;
    while (count < data.Length)
    {
      count = (int)Math.Pow(2, counter++);
      height++;
    }
    return height-1;
  }

  public void CreateTree(object[] objs)
  {
    if (objs == null || objs.Length == 0)
    {
      data = Array.Empty<BTNode>();
      root = null;
      return;
    }

    data = new BTNode[objs.Length];
    for (int i = 0; i < objs.Length; i++)
    {
      data[i] = new BTNode(objs[i]);
    }

    for (int i = 0; i < objs.Length; i++)
    {
      int leftIndex = (2 * i) + 1;
      int rightIndex = leftIndex + 1;

      if (leftIndex < objs.Length)
        data[i].SetLeft(data[leftIndex]);

      if (rightIndex < objs.Length)
        data[i].SetRight(data[rightIndex]);
    }

    root = data[0];
  }
}