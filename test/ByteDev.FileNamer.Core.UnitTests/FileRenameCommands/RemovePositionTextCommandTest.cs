using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
	[TestFixture]
	public class RemovePositionTextCommandTest
	{
	    [TestFixture]
	    public class Execute : RemovePositionTextCommandTest
	    {
            private const string OriginalText = "my original string";

            [Test]
            public void WhenPositionAndLengthWithinString_ShouldRemoveText()
            {
                var classUnderTest = new RemovePositionTextCommand(3, 9);

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("my string"));
            }

            [Test]
            public void WhenPositionIsLessThanZero_ShouldRemoveFromPositionZero()
            {
                var classUnderTest = new RemovePositionTextCommand(-1, 3);

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("original string"));
            }

            [Test]
            public void WhenPositionIsGreaterThanOriginalStringLength_ShouldRemoveNoText()
            {
                var classUnderTest = new RemovePositionTextCommand(OriginalText.Length + 1, 3);

                classUnderTest.Execute(OriginalText);

                Assert.That(classUnderTest.Result, Is.EqualTo(OriginalText));
            }

            [Test]
            public void WhenLengthIsZero_ShouldRemoveNoText()
            {
                var classUnderTest = new RemovePositionTextCommand(3, 0);

                classUnderTest.Execute(OriginalText);

                Assert.That(classUnderTest.Result, Is.EqualTo(OriginalText));
            }

            [Test]
            public void WhenLengthIsLessThanZero_ShouldRemoveNoText()
            {
                var classUnderTest = new RemovePositionTextCommand(3, -1);

                classUnderTest.Execute(OriginalText);

                Assert.That(classUnderTest.Result, Is.EqualTo(OriginalText));
            }    
	    }
	}
}
