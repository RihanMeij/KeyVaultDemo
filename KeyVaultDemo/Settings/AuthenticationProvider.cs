using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyVaultDemo.Settings
{
    public class AuthenticationProvider
    {
        public Uri AuthenticationUrl { get; set; }

        public string Key { get; set; }

        public string Secret { get; set; }
    }
}
