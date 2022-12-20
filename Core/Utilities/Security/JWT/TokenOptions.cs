namespace Core.Utilities.Security.JWT
{
    public class TokenOptions
    {
        public string Audience => "www.mvural.com";
        public string Issuer => "www.mvural.com";
        public int AccessTokenExpiration => 5;
        public string SecurityKey => "mysecretkey424434424434";
    }
}