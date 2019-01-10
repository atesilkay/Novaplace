using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPlace.Domain.Entity
{
    public class Post
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public string PostContent { get; set; }
        public DateTime PostDate { get; set; }
    }
}
