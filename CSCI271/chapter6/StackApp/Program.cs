public static class Program
{

  public static void Main(string[] args)
  {
    string word = "abcdefd";
    char ch = 'd';
    ReversePrefixDriver driver = new ReversePrefixDriver();
    string answer = driver.ReversePrefix(word, ch);
    Console.WriteLine("Reversed prefix: " + answer);
  }
}