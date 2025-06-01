public class Solution {
    public int Divide(int dividend, int divisor) {
    if (dividend == int.MinValue && divisor == -1)
    return int.MaxValue;

if (divisor == 1)
    return dividend;
if (divisor == -1)
    return -dividend;

var isNegative = dividend < 0 ^ divisor < 0;

long absDividend = Math.Abs((long) dividend);
long absDivisor = Math.Abs((long) divisor);


if (absDividend == absDivisor)
    return isNegative ? -1 : 1;

int couter = 0;
while (absDividend - absDivisor >= 0)
{
    absDividend -= absDivisor;
    couter++;
}
return isNegative ? -couter : couter;
    }
}