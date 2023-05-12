using Core.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class DecodeAccessToken
    {
        public string User { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public List<OperationClaim> Calims { get; set; }
    }
}
