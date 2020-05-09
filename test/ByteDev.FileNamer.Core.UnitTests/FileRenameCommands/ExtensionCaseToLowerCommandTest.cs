using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
    public class ExtensionCaseToLowerCommandTest
    {
        private ExtensionCaseToLowerCommand _classUnderTest;

        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new ExtensionCaseToLowerCommand();
        }

        [TestFixture]
        public class Execute : ExtensionCaseToLowerCommandTest
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
            public void WhenNameIsInUpperCase_ShouldNotAlterName()
            {
                _classUnderTest.Execute("TEST.txt");

                Assert.That(_classUnderTest.Result, Is.EqualTo("TEST.txt"));
            }

            [Test]
            public void WhenExtensionIsInUpperCase_ShouldSetResultWithLowerCaseExtension()
            {
                _classUnderTest.Execute("test.TXT");

                Assert.That(_classUnderTest.Result, Is.EqualTo("test.txt"));
            }
        }
    }
}