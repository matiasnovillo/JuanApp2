using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.CobradorBack.Entities;

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

namespace JuanApp2.Areas.JuanApp2.CobradorBack.EntitiesConfiguration
{
    public class CobradorConfiguration : IEntityTypeConfiguration<Cobrador>
    {
        public void Configure(EntityTypeBuilder<Cobrador> entity)
        {
            try
            {
                //CobradorId
                entity.HasKey(e => e.CobradorId);
                entity.Property(e => e.CobradorId)
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

                //NombreCompleto
                entity.Property(e => e.NombreCompleto)
                    .HasColumnType("varchar(200)")
                    .IsRequired(true);

                //Celular
                entity.Property(e => e.Celular)
                    .HasColumnType("varchar(100)")
                    .IsRequired(false);

                //Direccion
                entity.Property(e => e.Direccion)
                    .HasColumnType("text")
                    .IsRequired(false);

                //Email
                entity.Property(e => e.Email)
                    .HasColumnType("varchar(400)")
                    .IsRequired(false);

                
            }
            catch (Exception) { throw; }
        }
    }
}
