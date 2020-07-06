﻿using System;
using System.Collections.Generic;

namespace OnlineShopAPI.Models
{
    public partial class SystemConfig
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool? Status { get; set; }
    }
}
