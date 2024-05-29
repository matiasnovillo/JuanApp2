using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

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

namespace JuanApp2.Areas.JuanApp2.Entities.EntitiesConfiguration
{
    public class CajaConfiguration : IEntityTypeConfiguration<Caja>
    {
        public void Configure(EntityTypeBuilder<Caja> entity)
        {
            try
            {
                //CajaId
                entity.HasKey(e => e.CajaId);
                entity.Property(e => e.CajaId)
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

                //DateTimeTransaccion
                entity.Property(e => e.DateTimeTransaccion)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //CajaTipoDeTransaccionId
                entity.Property(e => e.CajaTipoDeTransaccionId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //EntradaId
                entity.Property(e => e.EntradaId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //SalidaId
                entity.Property(e => e.SalidaId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //IngresoOEgresoDeDinero
                entity.Property(e => e.IngresoOEgresoDeDinero)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //FormaDePagoId
                entity.Property(e => e.FormaDePagoId)
                    .HasColumnType("int")
                    .IsRequired(true);

                
            }
            catch (Exception) { throw; }
        }
    }
}
