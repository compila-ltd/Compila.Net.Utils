using System;
using System.Security.Cryptography;
using System.Text;

namespace Compila.Net.Utils
{
    public static class RandomStringGenerator
    {
        public static string GenerateRandomToken(int length)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

            byte[] data = new byte[4 * length];

            using (RandomNumberGenerator crypto = RandomNumberGenerator.Create())
            {
                crypto.GetBytes(data);
            }

            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                var rnd = BitConverter.ToUInt32(data, i * 4);
                var idx = rnd % chars.Length;

                result.Append(chars[idx]);
            }

            var token = result.ToString();

            return token;
        }
    }
}
