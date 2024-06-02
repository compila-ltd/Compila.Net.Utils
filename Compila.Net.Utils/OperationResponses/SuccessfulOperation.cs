namespace Compila.Net.Utils.OperationResponses
{
    public class SuccessfulOperation : OperationBaseResponse
    {
        public SuccessfulOperation() : base(true) { }
    }

    public class SuccessfulOperation<TResult> : OperationBaseResponse
    {
        public TResult Result { get; set; }

        public SuccessfulOperation(TResult result) : base(true) => Result = result;
    }
}
