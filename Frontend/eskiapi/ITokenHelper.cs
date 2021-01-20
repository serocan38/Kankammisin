using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;

namespace Frontend.eskiapi
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(UserdbModel user, List<OperationClaim> operationClaims);
    }
}
