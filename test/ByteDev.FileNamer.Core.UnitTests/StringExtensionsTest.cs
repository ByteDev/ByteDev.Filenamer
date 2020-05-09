using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests
{
    [TestFixture]
    public class StringExtensionsTest
    {
        [TestFixture]
        public class ToCapital : StringExtensionsTest
        {
            [Test]
            public void WithEmpty_ShouldReturnEmpty()
            {
                var result = string.Empty.ToCapitalCase();

                Assert.That(result, Is.EqualTo(string.Empty));
            }

            [Test]
            public void WithSingleLetterWord_ShouldReturnAsCapital()
            {
                var result = "a".ToCapitalCase();

                Assert.That(result, Is.EqualTo("A"));
            }

            [Test]
            public void WithSingleWord_ShouldReturnFirstLetterAsCapital()
            {
                var result = "word".ToCapitalCase();

                Assert.That(result, Is.EqualTo("Word"));
            }

            [Test]
            public void With4Words_ShouldReturnFirstLettersAsCapital()
            {
                Assert.That("my name is john".ToCapitalCase(), Is.EqualTo("My Name Is John"));
            }

            [Test]
            public void WithUpperCaseWord_ShouldReturnAsLowerCaseWithCapital()
            {
                var result = "TEST".ToCapitalCase();

                Assert.That(result, Is.EqualTo("Test"));
            }

            [Test]
            public void WithTabSpacedWords_ShouldReturnFirstLettersAsCapital()
            {
                var result = "my\tname\tis\tjohn".ToCapitalCase();

                Assert.That(result, Is.EqualTo("My\tName\tIs\tJohn"));
            }

            [Test]
            public void WithBracketsAroundWords_ShouldReturnFirstLettersAsCapital()
            {
                var result = "my(name)is(john)".ToCapitalCase();

                Assert.That(result, Is.EqualTo("My(Name)Is(John)"));
            }

            [Test]
            public void WithSqBracketsAroundWords_ShouldReturnFirstLettersAsCapital()
            {
                var result = "my[name]is[john]".ToCapitalCase();

                Assert.That(result, Is.EqualTo("My[Name]Is[John]"));
            }

            [Test]
            public void WithPeriodDelimitedWords_ShouldReturnFirstLettersAsCapital()
            {
                var result = "my.name.is.john".ToCapitalCase();

                Assert.That(result, Is.EqualTo("My.Name.Is.John"));
            }

            [Test]
            public void WithAcronymText_ShouldReturnFirstLettersAsCapital()
            {
                var result = "something R.I.P something".ToCapitalCase();

                Assert.That(result, Is.EqualTo("Something R.I.P Something"));
            }
        }
    }
}
