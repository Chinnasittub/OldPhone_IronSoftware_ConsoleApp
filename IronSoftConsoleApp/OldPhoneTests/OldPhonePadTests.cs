using IronSoftConsoleApp;
using NUnit.Framework;

namespace OldPhoneTests
{
    [TestFixture]
    public class OldPhonePadTests
    {

        [Test]
        public void OldPhone_MissingSharp_ReturnDash()
        {
            string input = "4433555 555666";
            var expected = "-";

            var actual = OldPhonePadClass.OldPhonePadConverter(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SplitDigit_SplitCorrectlyGroup1()
        {
            string input = "4433555 555666#";
            var expected = new List<string> {"44", "33", "555", "555", "666"};

            var actual = OldPhonePadClass.SplitIntoDigitGroups(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SplitDigit_SplitCorrectlyGroup2()
        {
            string input = "8 88777444666*664#";
            var expected = new List<string> { "8", "88", "777", "444", "666", "*", "66", "4"};

            var actual = OldPhonePadClass.SplitIntoDigitGroups(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MapCharacter_MapToCorrectCharacter1()
        {
            var input = new List<string> { "44", "33", "555", "555", "666" };
            var expected = "HELLO";

            var actual = OldPhonePadClass.MapCharacter(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MapCharacter_MapToCorrectCharacter2()
        {
            var input = new List<string> { "8", "88", "777", "444", "666", "*", "66", "4" };
            var expected = "TURING";

            var actual = OldPhonePadClass.MapCharacter(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OldPhonePad_Convert_Input_ReturnsCorrectOutput1()
        {
            string input = "4433555 555666#";
            string expected = "HELLO";

            string actual = OldPhonePadClass.OldPhonePadConverter(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OldPhonePad_Convert_Input_ReturnsCorrectOutput2()
        {
            string input = "8 88777444666*664#";
            string expected = "TURING";

            string actual = OldPhonePadClass.OldPhonePadConverter(input);

            Assert.AreEqual(expected, actual);
        }
    }
}