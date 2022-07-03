namespace Application.Common.Models.Auth
{
    public class Result
    {
        public bool Success { get; set; }
        public string Token { get; set; }
        public string Error { get; set; }

        public Result(bool success, string token, string error)
        {
            Success = success;
            Token = token;
            Error = error;
        }

        public static Result Successfull()
        {
            return new Result(true, string.Empty,string.Empty);
        }

        public static Result Successfull(string token)
        {
            return new Result(true, token, string.Empty);
        }

        public static Result Faliure(string error)
        {
            return new Result(false, string.Empty, error);
        }
    }
}
