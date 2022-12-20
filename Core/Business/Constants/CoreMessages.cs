using System.Runtime.Serialization;

namespace Core.Business.Constants
{
    public static class CoreMessages
    {
        public static class Authorization
        {
            public static string UserNotFound => "Kullanıcı bulunamadı.";
            public static string PasswordError => "Şifre Hatalı.";
            public static string SuccessfulLogin => "Sisteme giriş başarılı.";
            public static string UserAlreadyExists => "Kullanıcı zaten mevcut.";
            public static string UserRegistered => "Kullanıcı başarıyla kaydedildi.";
            public static string AccessTokenCreated => "AccessToken başarıyla oluşturuldu.";
            public static string AuthorizationDenied => "Yetkiniz yok.";
            public static string TokenIsTooOld => "Token'ın süresi dolmuş.";
            public static string UserHasNoClaims => "Kullanıcının yetkileri bulunamadı.";
        }
    }
}