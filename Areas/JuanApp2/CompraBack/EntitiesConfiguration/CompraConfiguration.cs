using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.CompraBack.Entities;

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

namespace JuanApp2.Areas.JuanApp2.CompraBack.EntitiesConfiguration
{
    public class CompraConfiguration : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> entity)
        {
            try
            {
                //CompraId
                entity.HasKey(e => e.CompraId);
                entity.Property(e => e.CompraId)
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

                //DiaDePago
                entity.Property(e => e.DiaDePago)
                    .HasColumnType("int")
                    .IsRequired(true);

                //Referencia
                entity.Property(e => e.Referencia)
                    .HasColumnType("varchar(8000)")
                    .IsRequired(true);

                //Descripcion
                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(8000)")
                    .IsRequired(true);

                //Unidad
                entity.Property(e => e.Unidad)
                    .HasColumnType("int")
                    .IsRequired(true);

                //Kilogramo
                entity.Property(e => e.Kilogramo)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //Precio
                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //Subtotal
                entity.Property(e => e.Subtotal)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //DebeOHaber
                entity.Property(e => e.DebeOHaber)
                    .HasColumnType("tinyint")
                    .IsRequired(true);

                //ProveedorId
                entity.Property(e => e.ProveedorId)
                    .HasColumnType("int")
                    .IsRequired(true);

                
            }
            catch (Exception) { throw; }
        }
    }
}
