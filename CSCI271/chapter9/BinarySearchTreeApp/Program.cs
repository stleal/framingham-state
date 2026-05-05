public class Program
{
  public static void Main(string[] args)
  {
    Tree tree = new Tree();
    List<LinkedList> lists = new List<LinkedList>();
    string s = "ALGORITHMS ARE FUN";
    object[] objs = new object[32];
    object[] nums = new object[16];
    for (int i = 0; i < nums.Length-1; i++)
    {
      nums[i] = i+1;
    }
    tree.CreateTree(nums);
    tree.Print();
    //tree.Insert(16);
    tree.Print();
    for (int i = 0; i < 32; i++)
    {
      if (i <= s.Length-1)
      {
        objs[i] = s[i];
      }
      else
      {
        break;
      }
    }
    tree = new Tree(objs);
    tree.Print();
    lists = tree.CreateListOfDepths();
    foreach (var list in lists)
    {
      Console.Write("List of Depth " + lists.IndexOf(list) + ": ");
      list.Print();
    }
    tree.Insert(" ");
    tree.Insert("X");
    tree.Insert("Y");
    tree.Insert("Z");
    tree.Print();
  }
}