﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.DeserializedClass
{
    public class JsonLogin
    {
        public string Status {  get; set; }
        public byte[] Token { get; set; }
    }
}