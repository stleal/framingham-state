public class Program
{
  public static void Main(string[] args)
  {
    Tree t = new Tree();
    Tree t2 = new Tree();
    string s = "ALGORITHMS ARE FUN";
    t.CreateTree(s);
    object[] objs = new object[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
      objs[i] = s[i];
    }
    t2 = new Tree(objs);
  }
}