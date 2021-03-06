﻿using Cuestionarios.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Cuestionarios.DAL.EntityFramework.Mappings
{
    class OptionMap: EntityTypeConfiguration<Option>
    {

        /// <summary>
        /// Maps Option Class to the database
        /// </summary>
        public OptionMap()
        {
            ToTable("Option");

            HasKey(b => b.Id)
                .Property(b => b.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(b => b.Answer)
                .IsRequired()
                .HasColumnName("answer");

            Property(b => b.Correct)
                .IsRequired()
                .HasColumnName("correct");
        }

    }
}
