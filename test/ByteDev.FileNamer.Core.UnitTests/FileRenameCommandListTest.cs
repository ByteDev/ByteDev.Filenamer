using System.Linq;
using ByteDev.FileNamer.Core.FileRenameCommands;
using NUnit.Framework;

namespace ByteDev.FileNamer.Core.UnitTests
{
	[TestFixture]
	public class FileRenameCommandListTest
	{
		private FileRenameCommandList _classUnderTest;

		[SetUp]
		public void Setup()
		{
			_classUnderTest = new FileRenameCommandList();
		}

	    [TestFixture]
        public class Add : FileRenameCommandListTest
	    {
            [Test]
            public void ShouldAddOp()
            {
                _classUnderTest.Add(new RenameToGuidCommand());

                Assert.That(_classUnderTest.Count, Is.EqualTo(1));
            }

            [Test]
            public void ShouldIncrementCountWhenAdd()
            {
                _classUnderTest.Add(new RenameToGuidCommand());
                _classUnderTest.Add(new InsertStringCommand(0, "prefix-"));

                Assert.That(_classUnderTest.Count, Is.EqualTo(2));
            }	         
	    }

	    [TestFixture]
        public class Fill : FileRenameCommandListTest
	    {
            private const int NumberOfCommands = 12;

            [Test]
            public void ShouldFillOpList()
            {
                _classUnderTest.Fill();

                Assert.That(_classUnderTest.Count, Is.EqualTo(NumberOfCommands));
            }

            [Test]
            public void ShouldClearBeforeFillOpList()
            {
                _classUnderTest.Fill();
                _classUnderTest.Fill();

                Assert.That(_classUnderTest.Count, Is.EqualTo(NumberOfCommands));
            }	         
	    }

	    [TestFixture]
        public class Clear : FileRenameCommandListTest
	    {
            [Test]
            public void WhenListHasCommands_ShouldClearList()
            {
                _classUnderTest.Add(new RenameToGuidCommand());
                _classUnderTest.Add(new InsertStringCommand(0, "prefix-"));

                _classUnderTest.Clear();

                Assert.That(_classUnderTest.Count, Is.EqualTo(0));
            }
	    }

	    [TestFixture]
        public class Index : FileRenameCommandListTest
	    {
            [Test]
            public void WhenCommandExistsAtIndexPosition_ShouldGetCommand()
            {
                _classUnderTest.Add(new RenameToGuidCommand());
                _classUnderTest.Add(new InsertStringCommand(0, "prefix-"));
                _classUnderTest.Add(new RenameToGuidCommand());

                Assert.IsInstanceOf<InsertStringCommand>(_classUnderTest[1]);
            }

            [Test]
            public void WhenCommandExistsAtIndexPosition_ShouldSetCommandAtIndex()
            {
                _classUnderTest.Add(new RenameToGuidCommand());
                _classUnderTest.Add(new InsertStringCommand(0, "prefix-"));

                _classUnderTest[1] = new RenameToGuidCommand();

                Assert.IsInstanceOf<RenameToGuidCommand>(_classUnderTest[1]);
            }
	    }

	    [TestFixture]
        public class GetEnumerator : FileRenameCommandListTest
	    {
            [Test]
            public void WhenListHasCommands_ShouldBeEnumerable()
            {
                _classUnderTest.Add(new RenameToGuidCommand());
                _classUnderTest.Add(new RenameToGuidCommand());

                foreach (var command in _classUnderTest)
                {
                    Assert.IsInstanceOf<RenameToGuidCommand>(command);
                }
                Assert.That(_classUnderTest.Count(), Is.EqualTo(2));
            }         
	    }
	}
}
