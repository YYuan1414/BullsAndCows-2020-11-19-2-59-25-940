using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            //Regex secret = new Regex("/^[0 - 9]{3,}[0 - 9]$/");
            //do
            //{
            //    secret = new Regex("/^[0 - 9]{3,}[0 - 9]$/");
            //}
            //while (secret.ToString().ToList().Distinct().Count() != secret.ToString().Length);

            //return secret.ToString();
            return string.Empty;
        }
    }
}