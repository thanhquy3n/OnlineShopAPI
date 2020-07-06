using System;
using System.Collections.Generic;

namespace OnlineShopAPI.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool? Status { get; set; }
    }
}
