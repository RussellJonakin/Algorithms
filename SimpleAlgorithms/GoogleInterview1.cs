using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class GoogleInterview1
    {
        //Test
        // col {a, c, y, i, t}, word = “cat” - true
        // col {a, c, y, t, i, t}, word = “catty” - true
        // col {A, c, y, i, t}, word = “cat” - false
        // col {} || null, word = “cat” -  false (empty or null collection)
        // col {a, g, h}, word = null || empty - false
        // col {D, o, ‘ ’, h, ‘ ’, ‘ ’, g} = “   ” - True (3 space character)
        // col {D, o, ‘ ’, h, g, B, u, l, e} = “Blue Dog” - True
        // col {D, o, h, g, B, u, l, e} = “Blue Dog” - False (no space to support phrase)



        public static bool CanBuildWord(List<char> charCollection, string word)
        {
            if (charCollection == null || !charCollection.Any())
            {
                return false;
            }

            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            //Create and load diction of character counts from charColection.
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in charCollection)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c] += 1;
                }
                else {
                    charCount.Add(c, 1);
                }
            }

            //check if charCount contains enough characters to build word.
            foreach (char c in word)
            {
                if (charCount.ContainsKey(c))
                {
                    if (charCount[c] > 0)
                    {
                        charCount[c] -= 1;
                    }
                    else {
                        return false;
                    }
                }
                else {
                    return false;
                }
            }

            return true;

        }

    }
}
