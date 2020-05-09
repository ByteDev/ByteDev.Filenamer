using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests.FileRenameCommands
{
	[TestFixture]
	public class CutCopyPasteCommandTest
	{
	    [TestFixture]
        public class Execute : CutCopyPasteCommandTest
	    {
            [Test]
            public void WhenCopyLengthLessThanOne_ShouldThrowException()
            {
                const int copyLength = 0;

                var classUnderTest = new CutCopyPasteCommand(3, copyLength, 18, false);

                Assert.Throws<FileRenameCommandValidationException>(() => classUnderTest.Execute("my original string"));
            }

            [Test]
	        public void WhenCopyLengthIsLongerThanTextLength_ShouldThrowException()
	        {
                const int copyLength = 5;

                var classUnderTest = new CutCopyPasteCommand(0, copyLength, 0, false);

                Assert.Throws<FileRenameCommandValidationException>(() => classUnderTest.Execute("test.txt"));
	        }

            [Test]
            public void ShouldCopyPaste()
            {
                var classUnderTest = new CutCopyPasteCommand(3, 8, 18, false);

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("my original stringoriginal"));
            }

            [Test]
            public void WhenCopyPosLessThanZero_ShouldCopyPaste()
            {
                var classUnderTest = new CutCopyPasteCommand(-1, 2, 18, false);

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("my original stringmy"));
            }

            [Test]
            public void WhenEndPosIsGreaterThanLength_ShouldCopyPaste()
            {
                var classUnderTest = new CutCopyPasteCommand(3, 8, 19, false);

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("my original stringoriginal"));
            }

            [Test]
            public void WhenIsCutTrue_ShouldCutPaste()
            {
                var classUnderTest = new CutCopyPasteCommand(3, 8, 18, true);

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("my  stringoriginal"));
            }

            [Test]
            public void WhenEndPosIsGreaterThanLength_ShouldCutPaste()
            {
                var classUnderTest = new CutCopyPasteCommand(3, 8, 19, true);

                classUnderTest.Execute("my original string");

                Assert.That(classUnderTest.Result, Is.EqualTo("my  stringoriginal"));
            }
	    }
	}
}
