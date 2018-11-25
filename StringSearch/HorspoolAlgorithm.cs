using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearch
{
    class HorspoolAlgorithm
    {
        public static List<int> Find(string myString, string stringPattern)
        {
            List<int> res = new List<int>();
            int textLength = myString.Length;
            int patternLength = stringPattern.Length;
            
            if (patternLength > textLength)
                return res;
            
            if (stringPattern.Except(myString).Any())
                return res;

            Dictionary<char, int> ShiftTable = new Dictionary<char, int>();
            
            foreach (char c in myString)
            {
                if (!ShiftTable.Keys.Contains(c))
                    ShiftTable.Add(c, patternLength);
            }
            
            for (int i = 0; i < stringPattern.Length - 1; i++)
            {
                ShiftTable[stringPattern[i]] = patternLength - i - 1;
            }
            
            int index = patternLength - 1;
            while (index <= textLength - 1)
            {
                int k = 0;
                while (k <= patternLength - 1 && stringPattern[patternLength - 1 - k] == myString[index - k])
                    k = k + 1;
                if (k == patternLength)
                {
                    res.Add(index - patternLength + 1);
                    index = index + ShiftTable[myString[index]];
                    continue;
                } 
                else
                    index = index + ShiftTable[myString[index]];
            }
            return res;
        }
    }
}
