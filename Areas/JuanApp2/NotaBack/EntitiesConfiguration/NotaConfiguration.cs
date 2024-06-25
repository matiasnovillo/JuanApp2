using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.NotaBack.Entities;

/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 */

namespace JuanApp2.Areas.JuanApp2.NotaBack.EntitiesConfiguration
{
    public class NotaConfiguration : IEntityTypeConfiguration<Nota>
    {
        public void Configure(EntityTypeBuilder<Nota> entity)
        {
            try
            {
                //NotaId
                entity.HasKey(e => e.NotaId);
                entity.Property(e => e.NotaId)
                    .ValueGeneratedOnAdd();

                //Active
                entity.Property(e => e.Active)
                    .HasColumnType("tinyint")
                    .IsRequired(true);

                //DateTimeCreation
                entity.Property(e => e.DateTimeCreation)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //DateTimeLastModification
                entity.Property(e => e.DateTimeLastModification)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //UserCreationId
                entity.Property(e => e.UserCreationId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //UserLastModificationId
                entity.Property(e => e.UserLastModificationId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //Nota1
                entity.Property(e => e.Nota1)
                    .HasColumnType("varchar(MAX)")
                    .IsRequired(true);

                //Nota2
                entity.Property(e => e.Nota2)
                    .HasColumnType("varchar(MAX)")
                    .IsRequired(true);

                //Nota3
                entity.Property(e => e.Nota3)
                    .HasColumnType("varchar(MAX)")
                    .IsRequired(true);

                //Nota4
                entity.Property(e => e.Nota4)
                    .HasColumnType("varchar(MAX)")
                    .IsRequired(true);

                
            }
            catch (Exception) { throw; }
        }
    }
}
