using System.Text;

namespace Compila.Net.Utils
{
	public static class Extensions
	{
		public static decimal TruncateDecimal(this decimal @this, int places, bool parseDecimals = false)
		{
			var multipler = (int)Math.Pow(10, places);
			var truncated = decimal.Truncate(@this * multipler) / multipler;

			if (parseDecimals)
				return decimal.Parse(truncated.ToString($"F{places}"));

			return truncated;
		}

		public static int DecimalPlaces(this decimal @this)
		{
			return BitConverter.GetBytes(decimal.GetBits(@this)[3])[2];
		}

		public static string Base64Encode(this string @this)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(@this));
		}

		public static string Base64Decode(this string @this)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(@this));
		}

		public static string TruncateString(this string @this, int maxLength)
		{
			if (@this.Length <= maxLength)
				return @this;

			var middlePoint = maxLength / 2;
			string start = @this[..middlePoint];
			string end = @this[^middlePoint..];

			return $"{start}...{end}";
		}
	}
}
