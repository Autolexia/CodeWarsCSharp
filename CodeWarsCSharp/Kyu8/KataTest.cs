namespace CodeWarsCSharp.Kyu8
{
    internal class KataTest
    {
        [TestCase(new int[] { 0, 1, 2, 3 }, 0, 3)]
        [TestCase(new int[] { -2, -1, 0, 1, 2 }, -2, 2)]
        [TestCase(new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, -10, 10)]
        [Test]
        public void BetweenMethodTest(int[] betweenValuesArr, int rangeStart, int rangeEnd)
        {
            // Act
            var betweenValuesResult = Kata.Between(rangeStart, rangeEnd);

            // Assert
            Assert.That(actual: betweenValuesArr, Is.EqualTo(expected: betweenValuesResult));
        }
    }
}