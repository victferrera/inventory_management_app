namespace GE.BL.Helpers
{
    public class ErrorHandling
    {
        private List<string> _errors;
        public bool hasErrors = false;

        public ErrorHandling()
        {
            if(_errors == null)
                _errors = new List<string>();
        }

        public void AddError(string error)
        {
            _errors.Add(error);

            if(!hasErrors)
                hasErrors = true;
        }

        private void CleanErrors()
        {
            _errors.Clear();
            hasErrors = false;
        }

        public List<string> GetErrors()
        {
            var errors = _errors.ToList();
            CleanErrors();
            return errors;
        }
    }
}
