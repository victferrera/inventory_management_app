namespace GE.BL.Exceptions
{
    public class ValidatorException : Exception
    {
        public List<string> errors { get; private set; }

        public ValidatorException()
        {
            errors = new List<string>();
        }

        public ValidatorException(List<string> errors)
        {
            this.errors = errors;
        }

        public void AddError(string message)
        {
            errors.Add(message);
        }
    }
}
