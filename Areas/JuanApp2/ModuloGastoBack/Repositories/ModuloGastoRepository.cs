using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Interfaces;
using JuanApp2.DatabaseContexts;
using System.Text.RegularExpressions;
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

namespace JuanApp2.Areas.JuanApp2.ModuloGastoBack.Repositories
{
    public class ModuloGastoRepository : IModuloGastoRepository
    {
        protected readonly JuanApp2Context _context;

        public ModuloGastoRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<ModuloGasto> AsQueryable()
        {
            try
            {
                return _context.ModuloGasto.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.ModuloGasto.Count();
            }
            catch (Exception) { throw; }
        }

        public ModuloGasto? GetByModuloGastoId(int modulogastoId)
        {
            try
            {
                return _context.ModuloGasto
                            .FirstOrDefault(x => x.ModuloGastoId == modulogastoId);
            }
            catch (Exception) { throw; }
        }

        public List<ModuloGasto?> GetAll()
        {
            try
            {
                return _context.ModuloGasto.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<ModuloGasto> GetAllByModuloGastoIdForModal(string textToSearch)
        {
            try
            {
                var query = from modulogasto in _context.ModuloGasto
                            select new { ModuloGasto = modulogasto};

                // Extraemos los resultados en listas separadas
                List<ModuloGasto> lstModuloGasto = query.Select(result => result.ModuloGasto)
                        .Where(x => x.ModuloGastoId.ToString().Contains(textToSearch))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .ToList();

                return lstModuloGasto;
            }
            catch (Exception) { throw; }
        }

        public List<ModuloGasto?> GetAllByModuloGastoId(List<int> lstModuloGastoChecked)
        {
            try
            {
                List<ModuloGasto?> lstModuloGasto = [];

                foreach (int ModuloGastoId in lstModuloGastoChecked)
                {
                    ModuloGasto modulogasto = _context.ModuloGasto.Where(x => x.ModuloGastoId == ModuloGastoId).FirstOrDefault();

                    if (modulogasto != null)
                    {
                        lstModuloGasto.Add(modulogasto);
                    }
                }

                return lstModuloGasto;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(ModuloGasto modulogasto)
        {
            try
            {
                _context.ModuloGasto.Add(modulogasto);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(ModuloGasto modulogasto)
        {
            try
            {
                _context.ModuloGasto.Update(modulogasto);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByModuloGastoId(int modulogastoId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.ModuloGastoId == modulogastoId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByModuloGastoIdInDataTable(List<int> lstModuloGastoChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("ModuloGastoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                DataTable.Columns.Add("DineroEfectivo", typeof(string));
                DataTable.Columns.Add("DineroCheque", typeof(string));
                DataTable.Columns.Add("DineroBanco", typeof(string));
                DataTable.Columns.Add("DineroTotal", typeof(string));
                

                foreach (int ModuloGastoId in lstModuloGastoChecked)
                {
                    ModuloGasto modulogasto = _context.ModuloGasto.Where(x => x.ModuloGastoId == ModuloGastoId).FirstOrDefault();

                    if (modulogasto != null)
                    {
                        DataTable.Rows.Add(
                        modulogasto.ModuloGastoId,
                        modulogasto.Active,
                        modulogasto.DateTimeCreation,
                        modulogasto.DateTimeLastModification,
                        modulogasto.UserCreationId,
                        modulogasto.UserLastModificationId,
                        modulogasto.Fecha,
                        modulogasto.Descripcion,
                        modulogasto.DineroEfectivo,
                        modulogasto.DineroCheque,
                        modulogasto.DineroBanco,
                        modulogasto.DineroTotal
                        
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
                List<ModuloGasto> lstModuloGasto = _context.ModuloGasto.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("ModuloGastoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                DataTable.Columns.Add("DineroEfectivo", typeof(string));
                DataTable.Columns.Add("DineroCheque", typeof(string));
                DataTable.Columns.Add("DineroBanco", typeof(string));
                DataTable.Columns.Add("DineroTotal", typeof(string));
                

                foreach (ModuloGasto modulogasto in lstModuloGasto)
                {
                    DataTable.Rows.Add(
                        modulogasto.ModuloGastoId,
                        modulogasto.Active,
                        modulogasto.DateTimeCreation,
                        modulogasto.DateTimeLastModification,
                        modulogasto.UserCreationId,
                        modulogasto.UserLastModificationId,
                        modulogasto.Fecha,
                        modulogasto.Descripcion,
                        modulogasto.DineroEfectivo,
                        modulogasto.DineroCheque,
                        modulogasto.DineroBanco,
                        modulogasto.DineroTotal
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
