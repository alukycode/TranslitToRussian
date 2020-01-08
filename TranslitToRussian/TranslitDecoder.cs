using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TranslitToRussian
{
    public static class TranslitDecoder
    {
        public static List<DictionaryEntry> ParseDictionary(string[] dictionaryLines)
        {
            var dictionary = new List<DictionaryEntry>();

            foreach (var line in dictionaryLines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var lineParts = line.Split("-");

                if (lineParts.Length != 2)
                {
                    throw new ApplicationException($"Wrong dictionary format here: \"${line}\"");
                }

                var latin = lineParts[0].Trim();
                var russian = lineParts[1].Trim();

                if (latin == string.Empty || russian == string.Empty)
                {
                    throw new ApplicationException($"Translation cannot be empty: \"${line}\"");
                }

                var entry = new DictionaryEntry()
                {
                    Russian = russian,
                    Latin = latin,
                };

                dictionary.Add(entry);
            }

            dictionary = dictionary.OrderByDescending(x => x.Latin.Length).ToList();

            return dictionary;
        }

        public static string Decode(string encodedText, List<DictionaryEntry> dictionary)
        {
            if (encodedText == null)
            {
                throw new NullReferenceException(nameof(encodedText) + "must not be null");
            }

            var decodedText = new StringBuilder(encodedText);

            foreach (var entry in dictionary)
            {
                decodedText.Replace(entry.Latin.ToLower(), entry.Russian.ToLower());
                decodedText.Replace(entry.Latin.FirstCharToUpper(), entry.Russian.FirstCharToUpper());
                decodedText.Replace(entry.Latin.ToUpper(), entry.Russian.ToUpper());
            }

            return decodedText.ToString();
        }
    }
}
