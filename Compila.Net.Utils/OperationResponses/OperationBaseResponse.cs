namespace Compila.Net.Utils.OperationResponses
{
    public class OperationBaseResponse
    {
        public bool Success { get; set; }

        protected OperationBaseResponse(bool success) => Success = success;
    }
}
