using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            List<string> secretSourceList = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var random = new Random();
            string secret = string.Empty;
            for (var i = 0; i < 4; i++)
            {
                int index = random.Next(0, secretSourceList.Count);
                secret += secretSourceList[index];
                secretSourceList.RemoveAt(index);
            }

            return secret;
        }
    }
}