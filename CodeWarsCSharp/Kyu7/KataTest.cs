namespace CodeWarsCSharp.Kyu7
{
    internal class KataTest
    {
        [TestCase(1, 1)]
        [TestCase(4, 10)]
        [TestCase(2, 11)]
        [TestCase(8, 54)]
        [Test]
        public void SampleTest(int expectedResult, int inputValue)
        {
            // Act
            int result = Kata.Divisors(inputValue);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}
