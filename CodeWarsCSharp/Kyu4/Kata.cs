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

        public static int ParseInt(string s)
        {
            var WordToNumber = new Dictionary<string, int>
            {
                {"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4},
                {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9},
                {"ten", 10}, {"eleven", 11}, {"twelve", 12}, {"thirteen", 13}, {"fourteen", 14},
                {"fifteen", 15}, {"sixteen", 16}, {"seventeen", 17}, {"eighteen", 18}, {"nineteen", 19},
                {"twenty", 20}, {"thirty", 30}, {"forty", 40}, {"fifty", 50}, {"sixty", 60},
                {"seventy", 70}, {"eighty", 80}, {"ninety", 90},
            };

            var wordList = s.ToLower().Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

            int total = 0;
            int currentNumber = 0;

            foreach (var word in wordList)
            {
                if (WordToNumber.TryGetValue(word, out int number))
                {
                    currentNumber += number;
                }
                else if (word == "hundred")
                {
                    currentNumber *= 100;
                }
                else if (word == "thousand")
                {
                    total += currentNumber * 1000;
                    currentNumber = 0;
                }
                else if (word == "million")
                {
                    total += currentNumber * 1000000;
                    currentNumber = 0;
                }
                else if (word == "and")
                {
                    continue;
                }
                else
                {
                    throw new ArgumentException("Invalid input: " + s);
                }
            }

            return total + currentNumber;
        }
    }
}
