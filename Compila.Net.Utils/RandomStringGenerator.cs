using System.Security.Cryptography;
using System.Text;

namespace Compila.Net.Utils
{
	public static class RandomStringGenerator
	{
		public static string GenerateRandomToken(int length, RandomStringType randomStringType = RandomStringType.AlphaNumeric)
		{
			char[] chars = randomStringType switch
			{
				RandomStringType.AlphaNumeric => "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray(),
				RandomStringType.LowerCaseAlphaNumeric => "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray(),
				RandomStringType.UpperCaseAlphaNumeric => "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray(),
				RandomStringType.Alpha => "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(),
				RandomStringType.LowerCaseAlpha => "abcdefghijklmnopqrstuvwxyz".ToCharArray(),
				RandomStringType.UpperCaseAlpha => "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(),
				RandomStringType.Numeric => "0123456789".ToCharArray(),
				RandomStringType.Hexadecimal => "0123456789ABCDEF".ToCharArray(),
				_ => "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray(),
			};

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

	public enum RandomStringType
	{
		AlphaNumeric,
		LowerCaseAlphaNumeric,
		UpperCaseAlphaNumeric,
		Alpha,
		LowerCaseAlpha,
		UpperCaseAlpha,
		Numeric,
		Hexadecimal
	}
}
