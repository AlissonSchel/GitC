﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiInsano.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
    }
}