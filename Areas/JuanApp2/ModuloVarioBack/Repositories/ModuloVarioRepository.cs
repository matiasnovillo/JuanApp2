using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Interfaces;
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

namespace JuanApp2.Areas.JuanApp2.ModuloVarioBack.Repositories
{
    public class ModuloVarioRepository : IModuloVarioRepository
    {
        protected readonly JuanApp2Context _context;

        public ModuloVarioRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<ModuloVario> AsQueryable()
        {
            try
            {
                return _context.ModuloVario.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.ModuloVario.Count();
            }
            catch (Exception) { throw; }
        }

        public ModuloVario? GetByModuloVarioId(int modulovarioId)
        {
            try
            {
                return _context.ModuloVario
                            .FirstOrDefault(x => x.ModuloVarioId == modulovarioId);
            }
            catch (Exception) { throw; }
        }

        public List<ModuloVario?> GetAll()
        {
            try
            {
                return _context.ModuloVario.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<ModuloVario> GetAllByModuloVarioIdForModal(string textToSearch)
        {
            try
            {
                var query = from modulovario in _context.ModuloVario
                            select new { ModuloVario = modulovario};

                // Extraemos los resultados en listas separadas
                List<ModuloVario> lstModuloVario = query.Select(result => result.ModuloVario)
                        .Where(x => x.ModuloVarioId.ToString().Contains(textToSearch))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .ToList();

                return lstModuloVario;
            }
            catch (Exception) { throw; }
        }

        public List<ModuloVario?> GetAllByModuloVarioId(List<int> lstModuloVarioChecked)
        {
            try
            {
                List<ModuloVario?> lstModuloVario = [];

                foreach (int ModuloVarioId in lstModuloVarioChecked)
                {
                    ModuloVario modulovario = _context.ModuloVario.Where(x => x.ModuloVarioId == ModuloVarioId).FirstOrDefault();

                    if (modulovario != null)
                    {
                        lstModuloVario.Add(modulovario);
                    }
                }

                return lstModuloVario;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(ModuloVario modulovario)
        {
            try
            {
                _context.ModuloVario.Add(modulovario);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(ModuloVario modulovario)
        {
            try
            {
                _context.ModuloVario.Update(modulovario);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByModuloVarioId(int modulovarioId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.ModuloVarioId == modulovarioId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByModuloVarioIdInDataTable(List<int> lstModuloVarioChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("ModuloVarioId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                DataTable.Columns.Add("DineroEfectivo", typeof(string));
                DataTable.Columns.Add("DineroBanco", typeof(string));
                DataTable.Columns.Add("DineroCheque", typeof(string));
                DataTable.Columns.Add("DineroTotal", typeof(string));
                

                foreach (int ModuloVarioId in lstModuloVarioChecked)
                {
                    ModuloVario modulovario = _context.ModuloVario.Where(x => x.ModuloVarioId == ModuloVarioId).FirstOrDefault();

                    if (modulovario != null)
                    {
                        DataTable.Rows.Add(
                        modulovario.ModuloVarioId,
                        modulovario.Active,
                        modulovario.DateTimeCreation,
                        modulovario.DateTimeLastModification,
                        modulovario.UserCreationId,
                        modulovario.UserLastModificationId,
                        modulovario.Fecha,
                        modulovario.Descripcion,
                        modulovario.DineroEfectivo,
                        modulovario.DineroBanco,
                        modulovario.DineroCheque,
                        modulovario.DineroTotal
                        
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
                List<ModuloVario> lstModuloVario = _context.ModuloVario.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("ModuloVarioId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                DataTable.Columns.Add("DineroEfectivo", typeof(string));
                DataTable.Columns.Add("DineroBanco", typeof(string));
                DataTable.Columns.Add("DineroCheque", typeof(string));
                DataTable.Columns.Add("DineroTotal", typeof(string));
                

                foreach (ModuloVario modulovario in lstModuloVario)
                {
                    DataTable.Rows.Add(
                        modulovario.ModuloVarioId,
                        modulovario.Active,
                        modulovario.DateTimeCreation,
                        modulovario.DateTimeLastModification,
                        modulovario.UserCreationId,
                        modulovario.UserLastModificationId,
                        modulovario.Fecha,
                        modulovario.Descripcion,
                        modulovario.DineroEfectivo,
                        modulovario.DineroBanco,
                        modulovario.DineroCheque,
                        modulovario.DineroTotal
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
