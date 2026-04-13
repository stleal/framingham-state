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

  public List<LinkedList> CreateListOfDepths()
  {
    var depth = 0;
    var height = GetHeight();
    List<LinkedList> lists = new List<LinkedList>();
    while (depth < height)
    {
      lists.Add(new LinkedList());
      var count = (int)Math.Pow(2, depth);
      var startIndex = (int)Math.Pow(2, depth)-1;
      var endIndex = startIndex + count;
      BTNode current = data[startIndex];
      for (int i = startIndex; i <= endIndex-1; i++)
      {
        lists[depth].Insert(current.GetValue()!);
        if (i < data.Length-1)
          current = data[i+1];
        if (i >= data.Length-1)
          break;
      }
      depth++;
    }
    return lists;
  }

  public void Print()
  {
    var depth = 0;
    var height = GetHeight();
    while (depth < height)
    {
      var count = (int)Math.Pow(2, depth);
      var startIndex = (int)Math.Pow(2, depth)-1;
      var endIndex = startIndex + count;
      BTNode current = data[startIndex];
      for (int i = startIndex; i <= endIndex-1; i++)
      {
        Console.Write(current.GetValue());
        if (i < data.Length-1)
          current = data[i+1];
        if (i >= data.Length-1)
          break;
      }
      depth++;
    }
  }

  public void CreateTree(object[] objs)
  {
    data = new BTNode[objs.Length];
    for (int i = 0; i < data.Length; i++)
    {
      data[i] = new BTNode(objs[i]);
    }
    for (int i = 0; i < objs.Length; i++)
    {
      var leftIndex = 2*i+1;
      var rightIndex = leftIndex + 1;
      if (leftIndex < data.Length)
        data[i].SetLeft(data[leftIndex]);
      if (rightIndex < data.Length)
        data[i].SetRight(data[rightIndex]);
    }
    root = data[0];
  }
}