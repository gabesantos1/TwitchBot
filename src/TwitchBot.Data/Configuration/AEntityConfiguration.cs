﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TwitchBot.Domain.Abstract;

namespace TwitchBot.Data.Configuration
{
    /// <summary>
    /// Class responsible for configurating abstract base entity model.
    /// </summary>
    /// <typeparam name="T">Base entity model.</typeparam>
    public class AEntityConfiguration<T> : IEntityTypeConfiguration<T>
        where T : AEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .UseIdentityAlwaysColumn();

            builder.Property(p => p.CreatedAt).IsRequired();
            builder.Property(p => p.UpdatedAt).IsRequired();
        }
    }
}
