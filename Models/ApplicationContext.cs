﻿using AngleSharp.Dom;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perfomans.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<DepartmentParameters> DepartmentParameters { get; set; }
        public DbSet<Parameters> Parameters { get; set; }
        public DbSet<ParametersGroup> ParametersGroups { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Evaluations> Evaluations { get; set; }
        public DbSet<State> States { get; set; } 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentParameters>().HasKey(pi => new { pi.DepartmentId, pi.ParameterId });
            modelBuilder.Entity<DepartmentParameters>().
                HasOne(pi => pi.Department).WithMany(pi => pi.DepartmentParameters).HasForeignKey(p => p.DepartmentId);
            modelBuilder.Entity<DepartmentParameters>().
                HasOne(pi => pi.parameter).WithMany(pi => pi.Departments).HasForeignKey(p => p.ParameterId);

            modelBuilder.Entity<ParametersGroup>().HasKey(pi => new { pi.GroupId, pi.ParameterId });
            modelBuilder.Entity<ParametersGroup>().
                HasOne(pi => pi.Parameters).WithMany(pi => pi.ParametersGroups).HasForeignKey(p => p.ParameterId);
            modelBuilder.Entity<ParametersGroup>().
                HasOne(pi => pi.Groups).WithMany(pi => pi.ParametersGroups).HasForeignKey(p => p.GroupId);


            string adminRoleName = "Admin";
            string userRoleName = "User";
            string TLRoleName = "Teamlead";
            string HeadRoleName = "Head";

            string adminEmail = "admin@mail.ru";
            string adminPassword = "123456";
            string adminName = "Denis";
            string adminSourName = "Temchenko";

            string devdep = "Developing";
            string GroupName = "Group1";

            string DefState = "Default";
            string FireState = "Fired";

            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            Role TLRole = new Role { Id = 3, Name = TLRoleName };
            Role HeadRole = new Role { Id = 4, Name = HeadRoleName };

            Departments departments = new Departments { Id = 1, Name = devdep };
            Groups groups = new Groups { id = 1, Name = GroupName, DepartmentId = departments.Id };

            State state = new State { Id = 1, Name = DefState };
            State state1 = new State { Id = 2, Name = FireState };



            modelBuilder.Entity<Departments>().HasData(new Departments[] { departments });
            modelBuilder.Entity<Groups>().HasData(new Groups[] { groups });
            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole, TLRole, HeadRole });
            modelBuilder.Entity<State>().HasData(new State[] { state, state1 });

            User adminUser = new User {
                Id = 1,
                Name = adminName,
                SourName = adminSourName,
                Email = adminEmail,
                Password = adminPassword,
                RoleId = adminRole.Id,
                DepartmentId = departments.Id,
                StateId = state.Id,
                SupervisorId = 1
            };
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });

            base.OnModelCreating(modelBuilder);
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
