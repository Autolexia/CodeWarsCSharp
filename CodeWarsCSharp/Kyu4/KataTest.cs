namespace CodeWarsCSharp.Kyu4
{
    internal class KataTest
    {
        [TestCase("8", new[] { "5", "7", "8", "9", "0" })]
        [TestCase("11", new[] { "11", "22", "44", "12", "21", "14", "41", "24", "42" })]
        [TestCase("369", new[] { "339", "366", "399", "658", "636", "258", "268", "669", "668", "266", "369", "398", "256", "296", "259", "368", "638", "396", "238", "356", "659", "639", "666", "359", "336", "299", "338", "696", "269", "358", "656", "698", "699", "298", "236", "239" })]
        [Test]
        public void TestBasic(string observedPin, string[] expectedVariationArr)
        {
            // Act
            var pinResult = Kata.GetPINs(observedPin);

            // Assert
            CollectionAssert.AreEquivalent(expectedVariationArr, pinResult);
        }

        [TestCase("one", 1)]
        [TestCase("twenty", 20)]
        [TestCase("two hundred forty-six", 246)]
        [Test]
        public void FixedTests(string numberWord, int value)
        {
            // Act
            int returnedNumber = Kata.ParseInt(numberWord);

            // Assert
            Assert.That(value, Is.EqualTo(returnedNumber));
        }
    }
}
