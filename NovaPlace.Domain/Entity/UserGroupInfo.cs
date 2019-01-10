using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPlace.Domain.Entity
{
    public class UserGroupInfo
    {
        public int UserGroupInfoId { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
    }
}
