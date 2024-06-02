namespace Compila.Net.Utils.OperationResponses
{
    public class ErrorOperationResponse : OperationBaseResponse
    {
        public string ErrorMessage { get; set; }

        public ErrorOperationResponse(string errorMessage) : base(false)
        {
            ErrorMessage = errorMessage;
        }
    }
}
