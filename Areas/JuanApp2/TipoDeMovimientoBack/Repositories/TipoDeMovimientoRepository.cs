using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.TipoDeMovimientoBack.Entities;
using JuanApp2.Areas.JuanApp2.TipoDeMovimientoBack.Interfaces;
using JuanApp2.DatabaseContexts;
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

namespace JuanApp2.Areas.JuanApp2.TipoDeMovimientoBack.Repositories
{
    public class TipoDeMovimientoRepository : ITipoDeMovimientoRepository
    {
        protected readonly JuanApp2Context _context;

        public TipoDeMovimientoRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<TipoDeMovimiento> AsQueryable()
        {
            try
            {
                return _context.TipoDeMovimiento.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.TipoDeMovimiento.Count();
            }
            catch (Exception) { throw; }
        }

        public TipoDeMovimiento? GetByTipoDeMovimientoId(int tipodemovimientoId)
        {
            try
            {
                return _context.TipoDeMovimiento
                            .FirstOrDefault(x => x.TipoDeMovimientoId == tipodemovimientoId);
            }
            catch (Exception) { throw; }
        }

        public List<TipoDeMovimiento?> GetAll()
        {
            try
            {
                return _context.TipoDeMovimiento.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<TipoDeMovimiento> GetAllByTipoDeMovimientoIdForModal(string textToSearch)
        {
            try
            {
                var query = from tipodemovimiento in _context.TipoDeMovimiento
                            select new { TipoDeMovimiento = tipodemovimiento};

                // Extraemos los resultados en listas separadas
                List<TipoDeMovimiento> lstTipoDeMovimiento = query.Select(result => result.TipoDeMovimiento)
                        .Where(x => x.TipoDeMovimientoId.ToString().Contains(textToSearch))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .ToList();

                return lstTipoDeMovimiento;
            }
            catch (Exception) { throw; }
        }

        public List<TipoDeMovimiento?> GetAllByTipoDeMovimientoId(List<int> lstTipoDeMovimientoChecked)
        {
            try
            {
                List<TipoDeMovimiento?> lstTipoDeMovimiento = [];

                foreach (int TipoDeMovimientoId in lstTipoDeMovimientoChecked)
                {
                    TipoDeMovimiento tipodemovimiento = _context.TipoDeMovimiento.Where(x => x.TipoDeMovimientoId == TipoDeMovimientoId).FirstOrDefault();

                    if (tipodemovimiento != null)
                    {
                        lstTipoDeMovimiento.Add(tipodemovimiento);
                    }
                }

                return lstTipoDeMovimiento;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(TipoDeMovimiento tipodemovimiento)
        {
            try
            {
                _context.TipoDeMovimiento.Add(tipodemovimiento);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(TipoDeMovimiento tipodemovimiento)
        {
            try
            {
                _context.TipoDeMovimiento.Update(tipodemovimiento);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByTipoDeMovimientoId(int tipodemovimientoId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.TipoDeMovimientoId == tipodemovimientoId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByTipoDeMovimientoIdInDataTable(List<int> lstTipoDeMovimientoChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("TipoDeMovimientoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Nombre", typeof(string));
                

                foreach (int TipoDeMovimientoId in lstTipoDeMovimientoChecked)
                {
                    TipoDeMovimiento tipodemovimiento = _context.TipoDeMovimiento.Where(x => x.TipoDeMovimientoId == TipoDeMovimientoId).FirstOrDefault();

                    if (tipodemovimiento != null)
                    {
                        DataTable.Rows.Add(
                        tipodemovimiento.TipoDeMovimientoId,
                        tipodemovimiento.Active,
                        tipodemovimiento.DateTimeCreation,
                        tipodemovimiento.DateTimeLastModification,
                        tipodemovimiento.UserCreationId,
                        tipodemovimiento.UserLastModificationId,
                        tipodemovimiento.Nombre
                        
                        );
                    }
                }                

                return DataTable;
            }
            catch (Exception) { throw; }
        }

        public DataTable GetAllInDataTable()
        {
            try
            {
                List<TipoDeMovimiento> lstTipoDeMovimiento = _context.TipoDeMovimiento.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("TipoDeMovimientoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Nombre", typeof(string));
                

                foreach (TipoDeMovimiento tipodemovimiento in lstTipoDeMovimiento)
                {
                    DataTable.Rows.Add(
                        tipodemovimiento.TipoDeMovimientoId,
                        tipodemovimiento.Active,
                        tipodemovimiento.DateTimeCreation,
                        tipodemovimiento.DateTimeLastModification,
                        tipodemovimiento.UserCreationId,
                        tipodemovimiento.UserLastModificationId,
                        tipodemovimiento.Nombre
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
