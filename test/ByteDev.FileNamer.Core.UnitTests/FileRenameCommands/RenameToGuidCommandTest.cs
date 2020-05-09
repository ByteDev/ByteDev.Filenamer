using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
    public class RenameToGuidCommandTest
    {
        private RenameToGuidCommand _classUnderTest;

        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new RenameToGuidCommand();
        }

        [TestFixture]
        public class Execute : RenameToGuidCommandTest
        {
            [Test]
            public void WhenNotNull_ShouldReturnResultAsGuidWithoutHypen()
            {
                _classUnderTest.Execute("example.txt");

                Assert.IsFalse(_classUnderTest.Result.Contains("-"));
                Assert.AreEqual(36, _classUnderTest.Result.Length);
            }
        } 
    }
}