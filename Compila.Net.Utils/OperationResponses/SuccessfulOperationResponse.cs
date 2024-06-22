namespace Compila.Net.Utils.OperationResponses
{
    public class SuccessfulOperationResponse : OperationBaseResponse
    {
        public SuccessfulOperationResponse() : base(true) { }
    }

    public class SuccessfulOperationResponse<TResult> : OperationBaseResponse
    {
        public TResult Result { get; set; }

        public SuccessfulOperationResponse(TResult result) : base(true) => Result = result;
    }
}
