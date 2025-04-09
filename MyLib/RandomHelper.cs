using System.Security.Cryptography;

namespace MyLib
{
    public static class RandomHelper
    {
        public static string RandomLatinString(int length)
        {
            const string chars = "QWERTYUIOPASDFGHJKLZXCVBNM0123456789qwertyuiopasdfghjklzxcvbnm";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[RandomNumberGenerator.GetInt32(s.Length)]).ToArray());
        }
    }
}