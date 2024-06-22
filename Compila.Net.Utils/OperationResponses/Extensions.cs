namespace Compila.Net.Utils.OperationResponses
{
    public static class OperationBaseResponseExtensions
    {
        public static TResultType GetResult<TResultType>(this OperationBaseResponse response)
        {
            if (response is SuccessfulOperationResponse<TResultType> okResponse)
            {
                return okResponse.Result;
            }

            throw new InvalidOperationException($"Response is not of type SuccessfulOperation<{nameof(TResultType)}>");
        }
    }
}
