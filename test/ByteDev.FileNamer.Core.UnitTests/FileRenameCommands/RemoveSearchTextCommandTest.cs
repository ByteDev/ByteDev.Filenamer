using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
	[TestFixture]
	public class RemoveSearchTextCommandTest
	{
	    [TestFixture]
	    public class Execute : RemoveSearchTextCommandTest
	    {
            private const string OriginalText = "my original string";

            [Test]
            public void WhenSearchTextIsEmpty_ShouldRemoveNothing()
	        {
	            var classUnderTest = new RemoveSearchTextCommand(string.Empty);

	            classUnderTest.Execute(OriginalText);

	            Assert.That(classUnderTest.Result, Is.EqualTo(OriginalText));
	        }

	        [Test]
            public void WhenOriginalTextIsEmpty_ShouldRemoveNothing()
	        {
	            var classUnderTest = new RemoveSearchTextCommand(" original");

	            classUnderTest.Execute(string.Empty);

	            Assert.That(classUnderTest.Result, Is.EqualTo(string.Empty));
	        }

	        [Test]
            public void WhenSearchTextExists_ShouldRemoveSearchText()
            {
                var classUnderTest = new RemoveSearchTextCommand(" original");

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("my string"));
            }
	    }
	}
}
