using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using JuanApp2.Areas.BasicCore;
using JuanApp2.Areas.JuanApp2.Entities;
using JuanApp2.Areas.JuanApp2.Interfaces;
using System.Data;

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

namespace JuanApp2.Areas.JuanApp2.Repositories
{
    public class CajaRepository : ICajaRepository
    {
        protected readonly JuanApp2Context _context;

        public CajaRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<Caja> AsQueryable()
        {
            try
            {
                return _context.Caja.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Caja.Count();
            }
            catch (Exception) { throw; }
        }

        public Caja? GetByCajaId(int cajaId)
        {
            try
            {
                return _context.Caja
                            .FirstOrDefault(x => x.CajaId == cajaId);
            }
            catch (Exception) { throw; }
        }

        public List<Caja?> GetAll()
        {
            try
            {
                return _context.Caja.ToList();
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(Caja caja)
        {
            try
            {
                _context.Caja.Add(caja);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(Caja caja)
        {
            try
            {
                _context.Caja.Update(caja);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByCajaId(int cajaId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.CajaId == cajaId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Other methods
        public DataTable GetAllInDataTable()
        {
            try
            {
                List<Caja> lstCaja = _context.Caja.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("CajaId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("DateTimeTransaccion", typeof(string));
                DataTable.Columns.Add("CajaTipoDeTransaccionId", typeof(string));
                DataTable.Columns.Add("EntradaId", typeof(string));
                DataTable.Columns.Add("SalidaId", typeof(string));
                DataTable.Columns.Add("IngresoOEgresoDeDinero", typeof(string));
                DataTable.Columns.Add("FormaDePagoId", typeof(string));
                

                foreach (Caja caja in lstCaja)
                {
                    DataTable.Rows.Add(
                        caja.CajaId,
                        caja.Active,
                        caja.DateTimeCreation,
                        caja.DateTimeLastModification,
                        caja.UserCreationId,
                        caja.UserLastModificationId,
                        caja.DateTimeTransaccion,
                        caja.CajaTipoDeTransaccionId,
                        caja.EntradaId,
                        caja.SalidaId,
                        caja.IngresoOEgresoDeDinero,
                        caja.FormaDePagoId
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
