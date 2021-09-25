using System;
using System.Collections.Generic;
using System.Text;

namespace Bible.Models
{
    public class Pastor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Church { get; set; }
        public string Message { get; set; }
        public string ProfilePicture { get; set; }
        public string VideoLink { get; set; }
    }
}
