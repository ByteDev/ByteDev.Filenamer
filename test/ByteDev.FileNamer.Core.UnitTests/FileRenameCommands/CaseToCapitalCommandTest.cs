using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
	[TestFixture]
	public class CaseToCapitalCommandTest
	{
        private CaseToCapitalCommand _classUnderTest;

        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new CaseToCapitalCommand();
        }

        [TestFixture]
        public class Execute : CaseToCapitalCommandTest
	    {
            [Test]
            public void WhenFileNameIsValid_ShouldSetResultWithCapitalisedFileName()
            {
                _classUnderTest.Execute("beastie boys - GET IT TOGETHER.mp3");

                Assert.That(_classUnderTest.Result, Is.EqualTo("Beastie Boys - Get It Together.mp3"));
            }
	    }
	}
}
