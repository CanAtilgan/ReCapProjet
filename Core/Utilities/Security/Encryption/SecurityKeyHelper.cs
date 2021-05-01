using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        //SecurityKey'i byte hale getirip onu simetrik bir anahtar haline getiriyor
        public static SecurityKey CreateSecurityKey(string securityKey) //"string securityKey" webapi deki 
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
