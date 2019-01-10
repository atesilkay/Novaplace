using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPlace.Domain.Entity
{
    public class UserGroup
    {
        public int GroupId { get; set; }

        public string GroupName { get; set; }

        public bool IsActive { get; set; }

        public bool IsDefault { get; set; }
    }
}
