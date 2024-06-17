﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class AuditLogs
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public string Action { get; set; }
        public string? Details { get; set; }
        public DateTime? Created_at { get; set; }
   
    }
}
