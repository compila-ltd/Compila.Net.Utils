namespace Compila.Net.Utils.OperationResponses
{
    public class ErrorOperation : OperationBaseResponse
    {
        public string ErrorMessage { get; set; }

        public ErrorOperation(string errorMessage) : base(false)
        {
            ErrorMessage = errorMessage;
        }
    }
}
