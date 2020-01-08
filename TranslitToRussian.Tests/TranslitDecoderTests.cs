using NUnit.Framework;

namespace TranslitToRussian.Tests
{
    public class TranslitDecoderTests
    {
        [TestCase("Privet", "������")]
        [TestCase("�������", "�������")]
        [TestCase("Mixed �����", "������ �����")]
        public void Decode_WorksCorrectly(string encodedText, string expected)
        {
            var actual = TranslitDecoder.Decode(encodedText);

            Assert.AreEqual(expected, actual);
        }
    }
}