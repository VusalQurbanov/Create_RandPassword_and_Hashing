using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordsAndHashing
{
    class RandomPasswordCreate
    {
         public string CreatePassword(int length)
        {
            const string keys = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            const string characters = "!@?$^*#";

            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(keys[rnd.Next(keys.Length)]);
                res.Append(characters[rnd.Next(characters.Length)]);
            }
            return res.ToString();
        }

    }
}
