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
            public static string ClaimAdded => "Yetki eklendi.";
            public static string ClaimDeleted => "Yetki silindi.";
            public static string ClaimModified => "Yetki güncellendi.";
            public static string ClaimAddedToUser => "Yetki kullanıcıya atandı.";
            public static string ClaimDeletedFromUser => "Yetki kullanıcıdan silindi.";
            public static string ClaimAlreadyAddedToUser => "Kullanıcıda bu yetki zaten mevcut.";
        }

        public static class Company
        {
            public static string CompanyAdded => "Şirket eklendi.";
            public static string CompanyDeleted => "Şirket silindi.";
            public static string CompanyModified => "Şirket güncellendi.";
            public static string YearEndTransferCompletedSuccessfully => "Yıl sonu devir işlemi başarıyla gerçekleştirildi.";
        }
    }
}