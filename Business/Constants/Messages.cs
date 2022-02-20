using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages

    {
        public static string Added =  "Kayıt eklendi";
        public static string Deleted = "Kayıt silindi";
        public static string Uptaded = "Kayıt güncellendi";
        public static string Listed = "Kayıtlar listelendi";

        public static string CarNamePriceInvalid = "Araba ismi ya da fiyat geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarImageLimit = "Bir arabanın en fazla 5 resmi olabilir";
        public static string CarImageUploaded = "Resim başarıyla yüklendi";
        public static string CarImageDeleted = "Resim başarıyla silindi";
        public static string CarImageUpdated = "Resim başarıyla güncellendi";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered="Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
