using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modify_Credit.Models;

namespace Modify_Credit.Data
{
    public class LeaveRequestDbContext : DbContext
    {
        public LeaveRequestDbContext(DbContextOptions<LeaveRequestDbContext> options):base(options)
        {
            
        }
        public DbSet<Employee> employees {get; set;}
        public DbSet<Department> departments { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<LeaveRequestForm>  leaveRequestForms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees").HasKey(q=>q.EmployeeId);
            modelBuilder.Entity<Employee>().Property(q=>q.Name).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Employee>().Property(q=>q.Family).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Employee>().Property(q=>q.NationalCode).HasMaxLength(10).IsRequired();         
            modelBuilder.Entity<Employee>().Property(q=>q.PhoneNumber).HasMaxLength(11).IsRequired();

            


            modelBuilder.Entity<Department>().ToTable("Departments").HasKey(q=>q.DepartmentId);
            modelBuilder.Entity<Department>().Property(q=>q.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Department>().Property(q=>q.Description).HasMaxLength(500);



            modelBuilder.Entity<Branch>().ToTable("branches").HasKey(q=>q.BranchId);
            modelBuilder.Entity<Branch>().Property(q=>q.Name);



            modelBuilder.Entity<LeaveRequestForm>().ToTable("LeaveRequestForms").HasKey(q=>q.LeaveRequestId);
            modelBuilder.Entity<LeaveRequestForm>().Property(q=>q.CreationDate).IsRequired();
            modelBuilder.Entity<LeaveRequestForm>().Property(q=>q.Description);
            modelBuilder.Entity<LeaveRequestForm>().Property(q=>q.EndHour).IsRequired();
            modelBuilder.Entity<LeaveRequestForm>().Property(q=>q.LeaveDate).IsRequired();
            modelBuilder.Entity<LeaveRequestForm>().Property(q=>q.StartHour).IsRequired();
            

            

        }
        

    }
    

}