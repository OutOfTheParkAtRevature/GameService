﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository
{
    public class SeasonContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Season> Seasons { get; set; }

        public SeasonContext() { }

        public SeasonContext(DbContextOptions<SeasonContext> options) : base(options) { }

    }
}
