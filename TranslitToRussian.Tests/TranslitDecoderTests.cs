using NUnit.Framework;

namespace TranslitToRussian.Tests
{
    public class TranslitDecoderTests
    {
        [TestCase("Privet", "Привет")]
        [TestCase("Русский", "Русский")]
        [TestCase("Mixed Текст", "Миксед Текст")]
        public void Decode_WorksCorrectly(string encodedText, string expected)
        {
            var actual = TranslitDecoder.Decode(encodedText);

            Assert.AreEqual(expected, actual);
        }
    }
}