﻿using System;
using System.Collections.Generic;

namespace AngularApi.Models
{
    public partial class TblUserdatum
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
