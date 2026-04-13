public class Program
{
  public static void Main(string[] args)
  {
    Tree t = new Tree();
    List<LinkedList> lists = new List<LinkedList>();
    string s = "ALGORITHMS ARE FUN";
    object[] objs = new object[s.Length];
    object[] nums = new object[16];
    for (int i = 0; i < nums.Length-1; i++)
    {
      nums[i] = i+1;
    }
    t.CreateTree(nums);
    t.Print();
    t.Insert(16);
    t.Print();
    for (int i = 0; i < s.Length; i++)
    {
      objs[i] = s[i];
    }
    t = new Tree(objs);
    t.Print();
    lists = t.CreateListOfDepths();
    foreach (var list in lists)
    {
      Console.Write("List of Depth " + lists.IndexOf(list) + ": ");
      list.Print();
    }
  }
}