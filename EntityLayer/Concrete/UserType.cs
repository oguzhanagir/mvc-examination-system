﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserType
    {
        [Key]
        public int UserTypeID { get; set; }
        [StringLength(20)]
        public string UserTypeName { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
