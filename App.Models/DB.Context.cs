﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBContainer1 : DbContext
    {
        public DBContainer1()
            : base("name=DBContainer1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<SysModule> sysmodule { get; set; }
        public DbSet<SysSample> syssample { get; set; }
        public DbSet<SysLog> SysLog { get; set; }
        public DbSet<SysException> SysException { get; set; }
        public DbSet<SysModuleOperate> SysModuleOperate { get; set; }
        public DbSet<SysUser> SysUser { get; set; }
        public DbSet<SysRole> SysRole { get; set; }
        public DbSet<SysRoleSysUser> SysRoleSysUser { get; set; }
        public DbSet<SysRight> SysRight { get; set; }
        public DbSet<SysRightOperate> SysRightOperate { get; set; }
    }
}
