public class Program
{
  public static void Main(string[] args)
  {
    Tree t = new Tree();
    string s = "ALGORITHMS ARE FUN";
    object[] objs = new object[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
      objs[i] = s[i];
    }
    t = new Tree(objs);
    t.Print();
  }
}