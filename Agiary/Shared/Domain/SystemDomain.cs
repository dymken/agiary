using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Agiary.Domain.System
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions options) : base(options) { }
        public DbSet<Module> Modules { get; set; }
        //public DbSet<Task> Tasks { get; set; }
    }

    [Table("module", Schema = "system")]
    public class Module
    {
        [Column("module_id")]
        public int Id { get; set; }
        
        [Column("module_sysname")]
        public string SysName { get; set; }

        [Column("module_name")]
        public string Name { get; set; }

        [Column("module_icon")]
        public string IconName { get; set; }

        //public ICollection<Task> Tasks { get; set; }

        public override string ToString() => Name;
        
    }

 /*   [Table("task", Schema = "system")]
    public class Task
    {
        [Column("task_id")]
        public int Id { get; set; }

        [Column("module_id")]
        public int ModuleId { get; set; }

        [ForeignKey("ModuleId")]
        public Module Module { get; set; }

        [Column("task_name")]
        public string Name { get; set; }
    }*/
    
    [Table("user", Schema = "system")]
    public class User
    {
        [Column("user_id")]
        public int Id { get; set; }
        [Column("user_firstname")]
        public string FisrtName { get; set; }
        [Column("user_lastname")]
        public string LastName { get; set; }
        [Column("user_email")]
        public string Email { get; set; }
    }
}
