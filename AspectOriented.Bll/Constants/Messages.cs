using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AspectOriented.Core.Constants
{
    public static class Messages
    {
        //Ekleme
        public static string AddedMessage = " Ekleme İşlemi Başarılı!";
        public static string AddedErrorMessage = " Ekleme İşlemi Gerçekleşemedi! Lütfen İlgili Alanları Kontrol Ediniz!";
        //Silme
        public static string DeletedMessage = "Silme İşlemi Başarılı!";
        public static string DeletedErrorMessage = "Ekleme İşlemi Gerçekleşemedi! Lütfen Sistem Yöneticinizle İletişime Geçiniz!";
        //Güncelleme
        public static string UpdatedMessage = "Güncelleme İşlemi Başarılı!";
        public static string UpdatedErrorMessage = " Güncelleme İşlemi Gerçekleşemedi! Lütfen Sistem Yöneticinizle İletişime Geçiniz!";
        //Listeleme
        public static string ListedMessage = "Listeleme Başarılı!";
        public static string ListedErrorMessage = "Listeleme Yapılırken Bir Sorun Oluştur!";
    }
}
