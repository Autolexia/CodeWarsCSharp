namespace CodeWarsCSharp.Kyu4
{
    internal class Kata
    {
        public static List<string> GetPINs(string observed)
        {
            Dictionary<char, string> adjacentDigits = new Dictionary<char, string>
            {
                ['1'] = "124",
                ['2'] = "1235",
                ['3'] = "236",
                ['4'] = "1457",
                ['5'] = "24568",
                ['6'] = "3569",
                ['7'] = "478",
                ['8'] = "57890",
                ['9'] = "689",
                ['0'] = "08"
            };

            return observed
                .Select(digit => adjacentDigits[digit])
                .Aggregate(Enumerable.Empty<string>(), (acc, next) =>
                    from a in acc.DefaultIfEmpty("") from n in next select a + n)
                .ToList();
        }
    }
}
