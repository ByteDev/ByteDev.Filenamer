using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
    [TestFixture]
    public class CaseToUpperCommandTest
    {
        private CaseToUpperCommand _classUnderTest;

        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new CaseToUpperCommand();
        }

        [TestFixture]
        public class Execute : CaseToUpperCommandTest
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
            public void WhenNameIsInLowerCase_ShouldSetResultToUpperCase()
            {
                _classUnderTest.Execute("test.txt");

                Assert.That(_classUnderTest.Result, Is.EqualTo("TEST.txt"));
            }

            [Test]
            public void WhenExtensionIsInLowerCase_ShouldNotAlterExtension()
            {
                _classUnderTest.Execute("TEST.txt");

                Assert.That(_classUnderTest.Result, Is.EqualTo("TEST.txt"));
            } 
        }
    }
}