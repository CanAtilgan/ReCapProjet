using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {   
                                                               //ona verilen passwordun hash'ını oluşturacak, aynı şekilde salt'ınında oluşturuyor olacak
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) //pasword hash'i oluşturma 
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; //ilgili algoritmanın key değerini kullanıyoruz burda.her kullanıcı için farklı key oluşturur
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //"Encoding.UTF8.GetBytes(password)" yukarda gönderilen passwor'du byt değeri ile gönderme,(stringi byte değeri ile gönderme)
            }
        }

        //PasswordHash'ini doğrulama . "string password" bu password, kullanıcığının sisteme sonradan giriş yapmak için verdiği parola
        public static bool VerifyPasswordHash(string password,byte[] passwordHash, byte[] passwordSalt) //değerleri kendimiz vereceğimiz out olmazburda, veritabanımızdaki hash ve salt olacak burdaki
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt)) //doğrulama yapacağımız key'i vermek için "passwordSalt" 
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //hesaplanan hash oluşturuldu (girilen şirfeye hash hesapladı)
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i]) //gönderilen hash ile verikaynağımızdaki hash aynı değilse;
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }
    }
}
