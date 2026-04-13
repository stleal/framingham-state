public class Tree
{
  public BTNode? root;
  public BTNode[] data;
  public int count;

  public Tree()
  {
    root = null;
    data = Array.Empty<BTNode>();
  }

  public Tree(object[] objs)
  {
    data = Array.Empty<BTNode>();
    count = 0;
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
    return (count == data.Length) ? height : height-1;
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

  public int GetIndexOfFirstEmptyNode()
  {
    // search through the existing tree looking for the first null left or right child
    var leftIndex = 0;
    var parent = root;
    for (int i = 0; i < data.Length; i++)
    {
      if (i > 0)
        parent = (i % 2 == 0) ? data[(i/2)-1] : data[(i/2)];
      leftIndex = 2*i;
      if (parent!.GetLeft()!.GetValue() == null)
        return i;
      if (parent.GetRight()!.GetValue() == null)
        return leftIndex;
    }
    return -1;
  }

  public void Insert(object o)
  {
    var index = GetIndexOfFirstEmptyNode();
    var parentIndex = (index % 2 == 0) ? (index/2)-1 : (index/2);
    // resize the tree by copying the data into a tree with +1 depth/height
    if (index != -1)
    {
      // child index
      data[index] = new BTNode(o);
      // parent index
      BTNode parent = data[parentIndex];
      if (index % 2 == 1)
        parent.SetLeft(data[index]);
      if (index % 2 == 0)
        parent.SetRight(data[index]);
      count++;
    }
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
        Console.Write(current.GetValue() + " ");
        if (i < data.Length-1)
          current = data[i+1];
        if (i >= data.Length-1)
          break;
      }
      depth++;
    }
    Console.WriteLine();
  }

  public void CreateTree(object[] objs)
  {
    data = new BTNode[objs.Length];
    for (int i = 0; i < data.Length; i++)
    {
      data[i] = new BTNode(objs[i]);
      count++;
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