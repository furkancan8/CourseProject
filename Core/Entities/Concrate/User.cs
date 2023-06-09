﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrate
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public string Number { get; set; }
        public bool IsSendMail { get; set; }
        public string ImageUrl { get; set; }
        public bool VerifyEmail { get; set; }
        public string Linkedln { get; set; }
        public string Github { get; set; }
        public string UserName { get; set; }


    }
}
