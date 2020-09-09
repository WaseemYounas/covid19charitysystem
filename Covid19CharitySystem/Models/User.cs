﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covid19CharitySystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Role { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreatedAt { get; set; }

        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<Task> Task { get; set;   }
    }
}