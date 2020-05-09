using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
    [TestFixture]
    public class CaseToLowerCommandTest
    {
        private CaseToLowerCommand _classUnderTest;

        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new CaseToLowerCommand();
        }

        [TestFixture]
        public class Execute : CaseToLowerCommandTest
        {
            [Test]
            public void WhenIsNull_ShouldThrowException()
            {
                Assert.Throws<FileRenameCommandException>(() => _classUnderTest.Execute(null));
            }

            [Test]
            public void WhenIsEmpty_ShouldSetResultToEmpty()
            {
                _classUnderTest.Execute(string.Empty);

                Assert.That(_classUnderTest.Result, Is.Empty);
            }

            [Test]
            public void WhenNameIsInUpperCase_ShouldSetResultToLowerCase()
            {
                _classUnderTest.Execute("TEST.txt");

                Assert.That(_classUnderTest.Result, Is.EqualTo("test.txt"));
            }

            [Test]
            public void WhenExtensionIsInUpperCase_ShouldNotAlterExtension()
            {
                _classUnderTest.Execute("test.TXT");

                Assert.That(_classUnderTest.Result, Is.EqualTo("test.TXT"));
            }
        }
    }
}