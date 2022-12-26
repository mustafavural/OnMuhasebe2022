namespace Core.Business.Constants
{
    public static class CoreMessages
    {
        public static class AuthorizationMessages
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

        public static class UserMessages
        {
            public static string UserAdded => "Yeni kullanıcı başarıyla eklendi.";
            public static string UserDeleted => "Kullanıcı başarıyla silindi.";
            public static string UserUpdated => "Kullanıcı başarıyla güncellendi.";
            public static string InUse => "Kullanımda olan kullanıcı silinemez.";
        }

        public static class ClaimMessages
        {
            public static string OperationClaimAdded => "Yeni yetki türü başarıyla eklendi.";
            public static string OperationClaimDeleted => "Yetki başarıyla silindi.";
            public static string OperationClaimUpdated => "Yetki başarıyla güncellendi.";
            public static string AlreadyExist => "Yetki daha önce girilmiş.";
            public static string InUse => "Kullanımda olan yetki silinemez.";
            public static string ClaimAddedToUser => "Yetki kullanıcıya atandı.";
            public static string ClaimDeletedFromUser => "Yetki kullanıcıdan silindi.";
            public static string ClaimAlreadyAddedToUser => "Kullanıcıda bu yetki zaten mevcut.";
        }

        public static class CompanyMessages
        {
            public static string CompanyAdded => "Şirket eklendi.";
            public static string CompanyDeleted => "Şirket silindi.";
            public static string CompanyModified => "Şirket güncellendi.";
            public static string UserAddedToCompany => "Kullanıcı şirkete eklendi.";
            public static string UserDeletedFromCompany => "Kullanıcı şirketten silindi.";
            public static string YearEndTransferCompletedSuccessfully => "Yıl sonu devir işlemi başarıyla gerçekleştirildi.";
            public static string CompanyAlreadyExist => "Şirket zaten mevcut.";
            public static string CompanyNotFound => "Şirket bulunamadı.";
            public static string YearOuOfDate => "Yıl bilgisi güncel değil.";
            public static string CompanyDatabaseCreatedSuccessfully => " adet şirkete ait veritabanı başarıyla oluşturuldu.";
            public static string CompanyTableCreatedSuccessfully => " adet tablo başarıyla oluşturuldu.";
        }
    }
}