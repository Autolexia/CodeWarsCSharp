namespace CodeWarsCSharp.Kyu8
{
    internal class Kata
    {
        public static int[] Between(int a, int b) => Enumerable.Range(a, b - a + 1).ToArray();
    }
}
