﻿using Cuestionarios.DAL.EntityFramework.Mappings;
using Cuestionarios.Entities;
using System;
using System.Data.Entity;


namespace Cuestionarios.DAL
{
    public class QuestionnaireDbContext : DbContext
    {
        /// <summary>
        /// Initialize the DB
        /// </summary>
        public QuestionnaireDbContext() : base(nameOrConnectionString: "Default")
        {
            // The customized initialization strategy of the DB is established.  
            Database.SetInitializer(new DatabaseInitializationStrategy());
            Database.Initialize(false);
        }

        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Option> Options { get; set; }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            if (pModelBuilder == null)
            {
                throw new ArgumentNullException(nameof(pModelBuilder));
            }

            //Adds each entity map
            pModelBuilder.Configurations.Add(new OptionMap());
            pModelBuilder.Configurations.Add(new QuestionMap());

            base.OnModelCreating(pModelBuilder);
        }

    }
}
