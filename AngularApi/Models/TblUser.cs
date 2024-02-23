﻿using System;
using System.Collections.Generic;

namespace AngularApi.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Email { get; set; }
    }
}
