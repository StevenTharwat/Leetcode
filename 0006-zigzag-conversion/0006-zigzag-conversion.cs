public class Solution {
    public string Convert(string s, int numRows) {
        if (s.Length <= 2 || numRows < 2 || s.Length <= numRows)
    return s;
var arrayLength = Math.Min(numRows, s.Length);      
StringBuilder[] rows = new StringBuilder[arrayLength];
var currentRow = -1;
var goingDown = true;
foreach (char c in s)
{
    if(goingDown)
        currentRow++;
    else
        currentRow--;

    rows[currentRow] ??= new StringBuilder();
    rows[currentRow].Append(c);

    if (currentRow == arrayLength-1)
        goingDown = false;
    else if (currentRow == 0)
        goingDown = true;
}
return string.Concat(rows.Select(r => r.ToString()));
    }
}