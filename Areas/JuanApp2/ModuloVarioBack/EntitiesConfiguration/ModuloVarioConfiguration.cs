using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Entities;

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

namespace JuanApp2.Areas.JuanApp2.ModuloVarioBack.EntitiesConfiguration
{
    public class ModuloVarioConfiguration : IEntityTypeConfiguration<ModuloVario>
    {
        public void Configure(EntityTypeBuilder<ModuloVario> entity)
        {
            try
            {
                //ModuloVarioId
                entity.HasKey(e => e.ModuloVarioId);
                entity.Property(e => e.ModuloVarioId)
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

                //Fecha
                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //Descripcion
                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(8000)")
                    .IsRequired(true);

                //DineroEfectivo
                entity.Property(e => e.DineroEfectivo)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //DineroBanco
                entity.Property(e => e.DineroBanco)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //DineroCheque
                entity.Property(e => e.DineroCheque)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //DineroTotal
                entity.Property(e => e.DineroTotal)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //DebeOHaber
                entity.Property(e => e.DebeOHaber)
                    .HasColumnType("tinyint")
                    .IsRequired(true);

                
            }
            catch (Exception) { throw; }
        }
    }
}
