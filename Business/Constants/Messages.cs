using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        //------------------------- ARABA -------------------------//
        public static string CarAdded = "Araba Eklendi.";
        public static string CarNameInvalid = "Araba İsmi Geçersiz";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string CarsListed = "Arabalar Listelendi";
        public static string CarDeleted = "Araba Silindi ";
        public static string CarUpdated = "Araba Güncellendi";

        //-------------------------KİRA -------------------------//

        public static string RentedCar = "Araba Kiralandı";
        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";
        public static string RentalUpdatedReturnDate = "Araç Kiralandı";
        public static string RentalUpdatedReturnDateError = "Bu araç kiralanmış durumdadır";

        //------------------------- KULLANICI -------------------------//
        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UserDeleted = "Kullanıcı Silindi.";
        public static string UserUpdated = "Kullanıcı Güncellendi.";

        //------------------------- MÜŞTERİ -------------------------//
        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string CustomerUpdated = "Müşteri Güncellendi.";


        public static string GeneralAdded = "Ekleme Başarılı";
        public static string GeneralDeleted = "Silme Başarılı";
        public static string GeneralUpdated = "Güncelleme Başarılı";
        public static string GeneralNameInvalid = "Geçersiz İsim";
        public static string GeneralListed = "Listelendi";

        public static string CheckUploadedImagesLimit = "En az 5 resim ekleyebilirsiniz";

        public static string ImagesAdded = "Resim Eklendi";

        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "Kayıt Olundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string PasswordError = "Parola Hatası.";
        public static string SuccessfulLogin = "Giriş Başarılı.";
        public static string UserAlreadyExists = "Kullanıcı Mevcut.";

        public static string AccessTokenCreated = "Token Üretildi.";
    }
}