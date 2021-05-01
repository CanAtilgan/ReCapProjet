using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages 
    {
        public static string CarAdded = "Ürün Eklendi";
        public static string CarDeleted = "Araç silme işlemi başarılı";
        public static string CarNameInvalid = "ürün ismi veya fiyat geçersiz";
        public static string CarsListed = "Ürünler getirildi";
        public static string CarUpdate = "Güncelleme başarılı";

        public static string BrandAdded = "Model ekleme başarılı";
        public static string BrandDeleted = "Model silme işlemi başarılı";
        public static string BrandListed = "Markalar getirildi";
        public static string BrandUpdate = "Güncelleme başarılı";
        
        public static string RentalError = "Araç kullanımda olduğu için kiralanamaz";
        
        public static string CustomerDeleted = "Müsteri silme işlemi başarılı";
        
        public static string Delete = "Silme işlemi başarılı";
        public static string Add = "Ekleme işlemi başarılı";
        public static string Update = "Güncelleme işlemi başarılı";
        public static string Listed = "Ürünler getirildi";

        public static string UserAdded = "Kullanıcı ekleme başarılı.";
        public static string UserUpdated = "Güncelleme başarılı";
        public static string UserDeleted = "Kullanıcı silindi!!";
        
        public static string ImageLimitExceded = "Eklenebilecek maksimum resim sayısı 5 adettir.";
        public static string CarAvailable = "Araç kullanımda , lütfen başka araç seçin";

        public static string CarImageAdded = "Araç resmi eklendi";
        public static string CarImageDeleted = "Araç resmi silindi.";
        public static string CarImagesListed = "Resimler listelendi";
        
        public static string AuthorizationDenied = "Yetkiniz yok";
        
        public static string UserRegistered= "Kayıt oldu";
        public static string UserNotFound ="Kullanıcı bulunamadı";
        public static string PasswordError="Paralo hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
