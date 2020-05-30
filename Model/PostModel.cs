using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Model
{
     public class JsonRegisterInfo
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
