using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
	[TestFixture]
	public class InsertStringCommandTest
	{
	    [TestFixture]
        public class Execute : InsertStringCommandTest
	    {
            private const string OriginalText = "my original string";

            [Test]
	        public void WhenOriginalStringIsEmpty_ShouldntInsert()
	        {
                var classUnderTest = new InsertStringCommand(3, OriginalText);

	            classUnderTest.Execute(string.Empty);

                Assert.That(classUnderTest.Result, Is.EqualTo(OriginalText));
	        }

	        [Test]
            public void WhenPositionWithinBounds_ShouldInsert()
            {
                var classUnderTest = new InsertStringCommand(3, "first ");

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("my first original string"));
            }

	        [Test]
            public void WhenPosIsGreaterThanLengthOfString_ShouldInsertAtEnd()
            {
                var classUnderTest = new InsertStringCommand(OriginalText.Length + 1, " was best");

                classUnderTest.Execute(OriginalText);

                Assert.That(classUnderTest.Result, Is.EqualTo("my original string was best"));
            }

	        [Test]
            public void WhenPosIsLessThanZero_ShouldInsertAtPositionZero()
            {
                var classUnderTest = new InsertStringCommand(-1, "first ");

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("first my original string"));
            }
	    }
	}
}
