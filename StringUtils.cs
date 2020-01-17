using System;

namespace _30DaysTDD
{
    public class StringUtils
    {
        internal int FindNumberOfOccurences(string sentenceToScan, string characterToScanFor)
        {
            if (characterToScanFor.Length != 1)
            {
                throw new ArgumentException();
            }

            var stringToCheckAsCharArray = sentenceToScan.ToCharArray();

            var characterToCheckFor = Char.Parse(characterToScanFor);

            var numberofOccurences = 0;


            for (var charIndx = 0; charIndx < stringToCheckAsCharArray.GetUpperBound(0); charIndx++)
            {
                if (stringToCheckAsCharArray[charIndx] == characterToCheckFor)
                {
                    numberofOccurences++;
                }
            }

            return numberofOccurences;
        }
    }
}