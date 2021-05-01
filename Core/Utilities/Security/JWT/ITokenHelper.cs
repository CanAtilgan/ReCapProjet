using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    //Jwt üretip onları kullanıcıya verme
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims); //Token'ın içerine konulacak yetkiler ve onların nerden geleceğinide verdik
    }
}
