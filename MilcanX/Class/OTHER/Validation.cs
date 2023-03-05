using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilcanX.Class.OTHER
{
    public class Validation
    {

        public static bool SadeceHarflerMi(string word)
        {
            return word.All(Char.IsLetter);
        }
    }
}
