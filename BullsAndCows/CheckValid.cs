using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BullsAndCows
{
    public class CheckValid
    {
        public bool IsValid(string guess)
        {
            Regex vaildFormat = new Regex(@"^(\d\s){3}\d$");
            return vaildFormat.IsMatch(guess) && (guess.Split(' ').ToList().Distinct().Count() == 4);
        }
    }
}
