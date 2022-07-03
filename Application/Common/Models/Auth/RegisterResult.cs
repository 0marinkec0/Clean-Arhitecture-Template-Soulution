namespace Application.Common.Models.Auth
{
    public class RegisterResult
    {
        public bool Success { get; set; }
        public string Errors { get; set; }

        public RegisterResult(bool successfull, string errors)
        {
            Success = successfull;
            Errors = errors;
        }

        public static RegisterResult Successfull()
        {
            return new RegisterResult( true, string.Empty);
        }

        public static RegisterResult Failure(string errors)
        {
            return new RegisterResult(false, errors);
        }
    }
}
