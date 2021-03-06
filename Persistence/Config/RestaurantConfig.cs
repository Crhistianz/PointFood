﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class RestaurantConfig
    {
        public RestaurantConfig(EntityTypeBuilder<Restaurant> entityBuilder)
        {
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Address).IsRequired().HasMaxLength(100);
            entityBuilder.HasOne(x => x.RestaurantOwner)
                .WithMany()
                .HasForeignKey(x => x.RestauranteOwnerId);
        }
    }
}
