namespace Compila.Net.Utils.Exceptions
{
	public class NullParameterException : ArgumentNullException
    {
        public NullParameterException(string paramName) : base(paramName: paramName, $"{paramName} can't be null.") { }
    }

    public class InternalNullArgumentException : ArgumentNullException
    {
        bool _isInternal = true;
        public InternalNullArgumentException(string message, bool isInternal = true) : base(message: message, null)
        {
            _isInternal = isInternal;
        }
    }
}
