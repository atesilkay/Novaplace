using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPlace.Domain.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string MailAdress { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
