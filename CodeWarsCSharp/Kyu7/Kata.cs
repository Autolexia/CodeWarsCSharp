namespace CodeWarsCSharp.Kyu7
{
    internal class Kata
    {
        public static int Divisors(int n) => Enumerable.Range(1, n).Count(i => n % i == 0);
    }
}
