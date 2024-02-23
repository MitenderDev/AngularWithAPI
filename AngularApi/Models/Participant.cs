using System;
using System.Collections.Generic;

namespace AngularApi.Models
{
    public partial class Participant
    {
        public string? Email { get; set; }
        public string? MeetingId { get; set; }
        public int Id { get; set; }
    }
}
