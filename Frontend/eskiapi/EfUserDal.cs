using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;

namespace Frontend.eskiapi
{
    public class EfUserDal
    {
        private KankammisinContext _context;
        public EfUserDal(KankammisinContext context)
        {
            _context = context;
        }
        public List<OperationClaim> GetClaims(UserdbModel user)
        {
            using (_context)
            {
                var result = from operationClaim in _context.OperationClaims
                    join userOperationClaim in _context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.ID
                    select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}
