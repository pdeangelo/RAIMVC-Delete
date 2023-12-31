﻿using RAIModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIModel
{
    public class Context : DbContext
    {
        public Context() : base ("RAI")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanStatus> LoanStatus { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<DwellingType> DwellingType { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Investor> Investor { get; set; }
        public DbSet<LoanType> LoanType { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
    }
}
