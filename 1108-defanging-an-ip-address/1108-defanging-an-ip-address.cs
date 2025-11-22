public class Solution {
    public string DefangIPaddr(string address) {
        char[] chars = new char[address.Length + 3 * 2];
int charsIndex = 0;
for (int i = 0 ; i < address.Length ; i++, charsIndex++)
{
    if (address[i] == '.')
    {
        chars[charsIndex] = '[';
        chars[charsIndex + 1] = '.';
        chars[charsIndex + 2] = ']';
        charsIndex += 2;
    }
    else
    {
        chars[charsIndex] = address[i];
    }

}
return new string(chars);
    }
}