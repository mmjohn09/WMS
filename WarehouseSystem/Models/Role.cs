﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        
        public string UserRole { get; set; }
        

    }
}
