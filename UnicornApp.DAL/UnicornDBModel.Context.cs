﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnicornApp.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UnicornDBEntities : DbContext
    {
        public UnicornDBEntities()
            : base("name=UnicornDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FollowingUser> FollowingUser { get; set; }
        public virtual DbSet<Tweet> Tweet { get; set; }
        public virtual DbSet<TweetLikeDislike> TweetLikeDislike { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
