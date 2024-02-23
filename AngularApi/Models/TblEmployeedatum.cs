using System;
using System.Collections.Generic;

namespace AngularApi.Models
{
    public partial class TblEmployeedatum
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Adders { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
