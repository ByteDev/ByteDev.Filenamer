using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
	[TestFixture]
	public class ReplaceCharSpaceCommandTest
	{
	    [TestFixture]
        public class Execute : ReplaceCharSpaceCommandTest
	    {
            [Test]
            public void WhenCharExists_ShouldReplaceWithSpace()
            {
                var classUnderTest = new ReplaceCharSpaceCommand('-');

                classUnderTest.Execute("my-original-string");

                Assert.That(classUnderTest.Result, Is.EqualTo("my original string"));
            }

	        [Test]
	        public void WhenCharDoesNotExist_ShouldNotChangeString()
	        {
                var classUnderTest = new ReplaceCharSpaceCommand('-');

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("my original string"));
	        }
	    }
	}
}
