﻿using ePizza.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Data.Concrete.EntityFramework.Mappings
{
    public class UserLoginMap : IEntityTypeConfiguration<UserLogin>
    {
        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {

            builder.HasKey(l => new { l.LoginProvider, l.ProviderKey });
            builder.Property(l => l.LoginProvider).HasMaxLength(128);
            builder.Property(l => l.ProviderKey).HasMaxLength(128);
            builder.ToTable("AspNetUserLogins");



        }
    }
}
