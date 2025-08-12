public class Solution {
 public string ReverseWords(string s)
{
    if (string.IsNullOrWhiteSpace(s))
    {
        return string.Empty;
    }

    string[] words = s.Split(' ');
    if (words.Length == 1)
    {
        return reverse(s);
    }

    StringBuilder stringBuilder = new();
    foreach (var word in words)
    {
        stringBuilder.Append(reverse(word) + " ");
    }
    return stringBuilder.ToString().Trim();
}

 private string reverse(string word)
{
    char[] chars = word.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}
}