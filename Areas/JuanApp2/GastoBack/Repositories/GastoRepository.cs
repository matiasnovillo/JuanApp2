using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using JuanApp2.Areas.JuanApp2.GastoBack.Entities;
using JuanApp2.Areas.JuanApp2.GastoBack.Interfaces;
using JuanApp2.DatabaseContexts;
using System.Text.RegularExpressions;
using System.Data;
using DocumentFormat.OpenXml.Bibliography;

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

namespace JuanApp2.Areas.JuanApp2.GastoBack.Repositories
{
    public class GastoRepository : IGastoRepository
    {
        protected readonly JuanApp2Context _context;

        public GastoRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<Gasto> AsQueryable()
        {
            try
            {
                return _context.Gasto.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Gasto.Count();
            }
            catch (Exception) { throw; }
        }

        public Gasto? GetByGastoId(int gastoId)
        {
            try
            {
                Gasto Gasto = _context.Gasto
                                .FirstOrDefault(x => x.GastoId == gastoId);
                return Gasto;
            }
            catch (Exception) { throw; }
        }

        public List<Gasto?> GetAll()
        {
            try
            {
                return _context.Gasto.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<Gasto?> GetAllByGastoId(List<int> lstGastoChecked)
        {
            try
            {
                List<Gasto?> lstGasto = [];

                foreach (int GastoId in lstGastoChecked)
                {
                    Gasto gasto = _context.Gasto.Where(x => x.GastoId == GastoId).FirstOrDefault();

                    if (gasto != null)
                    {
                        lstGasto.Add(gasto);
                    }
                }

                return lstGasto;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(Gasto gasto)
        {
            try
            {
                EntityEntry<Gasto> GastoToAdd = _context.Gasto.Add(gasto);

                bool result = _context.SaveChanges() > 0;

                return result;
            }
            catch (Exception) { throw; }
        }

        public bool Update(Gasto gasto)
        {
            try
            {
                _context.Gasto.Update(gasto);

                bool result = _context.SaveChanges() > 0;

                return result;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByGastoId(int gastoId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.GastoId == gastoId)
                        .ExecuteDelete();

                bool result = _context.SaveChanges() > 0;

                return result;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByGastoIdInDataTable(List<int> lstGastoChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("GastoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("Importe", typeof(string));
                

                foreach (int GastoId in lstGastoChecked)
                {
                    Gasto gasto = _context.Gasto.Where(x => x.GastoId == GastoId).FirstOrDefault();

                    if (gasto != null)
                    {
                        DataTable.Rows.Add(
                        gasto.GastoId,
                        gasto.Active,
                        gasto.DateTimeCreation,
                        gasto.DateTimeLastModification,
                        gasto.UserCreationId,
                        gasto.UserLastModificationId,
                        gasto.Descripcion,
                        gasto.Fecha,
                        gasto.Importe
                        
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
                List<Gasto> lstGasto = _context.Gasto.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("GastoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("Importe", typeof(string));
                

                foreach (Gasto gasto in lstGasto)
                {
                    DataTable.Rows.Add(
                        gasto.GastoId,
                        gasto.Active,
                        gasto.DateTimeCreation,
                        gasto.DateTimeLastModification,
                        gasto.UserCreationId,
                        gasto.UserLastModificationId,
                        gasto.Descripcion,
                        gasto.Fecha,
                        gasto.Importe
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
