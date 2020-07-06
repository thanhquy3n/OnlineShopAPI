using System;
using System.Collections.Generic;

namespace OnlineShopAPI.Models
{
    public partial class Language
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
    }
}
