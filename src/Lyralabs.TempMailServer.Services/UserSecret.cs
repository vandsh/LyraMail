﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyralabs.TempMailServer
{
    public struct UserSecret
    {
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
        public string Password { get; set; }
    }
}
