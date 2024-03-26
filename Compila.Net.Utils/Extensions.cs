using System;
using System.Text;

using Compila.Net.Utils.ServiceResponses;

namespace Compila.Net.Utils
{
    public static class Extensions
    {
        public static decimal TruncateDecimal(this decimal @this, int places)
        {
            var multipler = (int)Math.Pow(10, places);
            return decimal.Truncate(@this * multipler) / multipler;
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

        public static TResultType GetResult<TResultType>(this ServiceBaseResponse response)
        {
            if (response is ServiceOkResponse<TResultType> okResponse)
            {
                return okResponse.Result;
            }

            throw new InvalidOperationException($"Response is not of type ServiceOkResponse<{nameof(TResultType)}>");
        }
    }
}
