using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
	[TestFixture]
	public class ReplaceStringCommandTest
	{
	    [TestFixture]
	    public class Execute : ReplaceStringCommandTest
	    {
            private const string OriginalString = "my original string";

            [Test]
            public void WhenFindTextExists_ShouldReplace()
            {
                var classUnderTest = new ReplaceStringCommand("my ", "johns ");

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("johns original string"));
            }

            [Test]
            public void WhenFindTextExists_AndReplacementTextIsEmpty_ShouldReplace()
            {
                var classUnderTest = new ReplaceStringCommand("my ", string.Empty);

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("original string"));
            }

            [Test]
            public void WhenFindTextDoesNotExist_ShouldReplaceNothing()
            {
                var classUnderTest = new ReplaceStringCommand("johns ", "my ");

                classUnderTest.Execute(OriginalString);

                Assert.That(classUnderTest.Result, Is.EqualTo(OriginalString));
            }

            [Test]
            public void WhenFindTextIsEmpty_ShouldReplaceNothing()
            {
                var command = new ReplaceStringCommand(string.Empty, "my ");

                command.Execute(OriginalString);

                Assert.That(command.Result, Is.EqualTo(OriginalString));
            }    
	    }
	}
}
