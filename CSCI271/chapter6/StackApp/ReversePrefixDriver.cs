public class ReversePrefixDriver
{

  public string ReversePrefix(string word, char ch)
  {
    var index = 0;
    var found = false;
    Stack s = new Stack();
    string prefixReversed = string.Empty;

    // loop through the word and find the first occurence of ch
    for (int i = 0; i < word.Length; i++)
    {
      s.Push(word[i]);
      if (word[i] == ch)
      {
        index = i;
        found = true;
        break;
      }
    }

    // if not found, then return the word
    if (!found)
      return word;

    // repeatedly pop the stack until it's empty storing the values in prefixReversed
    while (!s.IsEmpty())
    {
      prefixReversed += s.Pop();
    }

    // return the prefixReversed concatenated with the remainder of the string
    return prefixReversed + word.Substring(index+1, word.Length-(index+1));
  }

  public void Sample()
  {
    Stack s = new Stack();
    s.Push('a');
    s.Push('b');
    s.Push('c');
    s.Push('d');
    s.Push('e');
    s.Push('f');
    s.Push('d');
    var result = s.Pop();
    Console.WriteLine("Result: " + result);
    result = s.Pop();
    Console.WriteLine("Result: " + result);
    result = s.Peek();
    Console.WriteLine("Result: " + result);
  }

}