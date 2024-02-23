using System;
using System.Collections.Generic;

namespace AngularApi.Models
{
    public partial class Meetingtable
    {
        public int Id { get; set; }
        public string? DateandTime { get; set; }
        public string? MeetingId { get; set; }
        public string? MeetingName { get; set; }
        public string? Email { get; set; }
        public bool? Status { get; set; }
        public string? MeetingPassword { get; set; }
        public bool? AllowChat { get; set; }
        public bool? ScreenShare { get; set; }
    }
}
