namespace Compila.Net.Utils.OperationResponses
{
    public class OperationBaseResponse
    {
        public bool Success { get; set; }

        protected OperationBaseResponse(bool success) => Success = success;
    }

    public static class OperationBaseResponseExtensions
    {
        public static TResultType GetResult<TResultType>(this OperationBaseResponse response)
        {
            if (response is SuccessfulOperation<TResultType> okResponse)
            {
                return okResponse.Result;
            }

            throw new InvalidOperationException($"Response is not of type SuccessfulOperation<{nameof(TResultType)}>");
        }
    }
}
