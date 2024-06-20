using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Interfaces;
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

namespace JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Repositories
{
    public class ModuloProveedorRepository : IModuloProveedorRepository
    {
        protected readonly JuanApp2Context _context;

        public ModuloProveedorRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<ModuloProveedor> AsQueryable()
        {
            try
            {
                return _context.ModuloProveedor.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.ModuloProveedor.Count();
            }
            catch (Exception) { throw; }
        }

        public ModuloProveedor? GetByModuloProveedorId(int moduloproveedorId)
        {
            try
            {
                return _context.ModuloProveedor
                            .FirstOrDefault(x => x.ModuloProveedorId == moduloproveedorId);
            }
            catch (Exception) { throw; }
        }

        public List<ModuloProveedor?> GetAll()
        {
            try
            {
                return _context.ModuloProveedor.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<ModuloProveedor> GetAllByModuloProveedorIdForModal(string textToSearch)
        {
            try
            {
                var query = from moduloproveedor in _context.ModuloProveedor
                            select new { ModuloProveedor = moduloproveedor};

                // Extraemos los resultados en listas separadas
                List<ModuloProveedor> lstModuloProveedor = query.Select(result => result.ModuloProveedor)
                        .Where(x => x.ModuloProveedorId.ToString().Contains(textToSearch))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .ToList();

                return lstModuloProveedor;
            }
            catch (Exception) { throw; }
        }

        public List<ModuloProveedor?> GetAllByModuloProveedorId(List<int> lstModuloProveedorChecked)
        {
            try
            {
                List<ModuloProveedor?> lstModuloProveedor = [];

                foreach (int ModuloProveedorId in lstModuloProveedorChecked)
                {
                    ModuloProveedor moduloproveedor = _context.ModuloProveedor.Where(x => x.ModuloProveedorId == ModuloProveedorId).FirstOrDefault();

                    if (moduloproveedor != null)
                    {
                        lstModuloProveedor.Add(moduloproveedor);
                    }
                }

                return lstModuloProveedor;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(ModuloProveedor moduloproveedor)
        {
            try
            {
                _context.ModuloProveedor.Add(moduloproveedor);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(ModuloProveedor moduloproveedor)
        {
            try
            {
                _context.ModuloProveedor.Update(moduloproveedor);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByModuloProveedorId(int moduloproveedorId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.ModuloProveedorId == moduloproveedorId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByModuloProveedorIdInDataTable(List<int> lstModuloProveedorChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("ModuloProveedorId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("ProveedorId", typeof(string));
                DataTable.Columns.Add("DineroBanco", typeof(string));
                DataTable.Columns.Add("DineroTotal", typeof(string));
                DataTable.Columns.Add("DineroCheque", typeof(string));
                DataTable.Columns.Add("DineroEfectivo", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                

                foreach (int ModuloProveedorId in lstModuloProveedorChecked)
                {
                    ModuloProveedor moduloproveedor = _context.ModuloProveedor.Where(x => x.ModuloProveedorId == ModuloProveedorId).FirstOrDefault();

                    if (moduloproveedor != null)
                    {
                        DataTable.Rows.Add(
                        moduloproveedor.ModuloProveedorId,
                        moduloproveedor.Active,
                        moduloproveedor.DateTimeCreation,
                        moduloproveedor.DateTimeLastModification,
                        moduloproveedor.UserCreationId,
                        moduloproveedor.UserLastModificationId,
                        moduloproveedor.Fecha,
                        moduloproveedor.ProveedorId,
                        moduloproveedor.DineroBanco,
                        moduloproveedor.DineroTotal,
                        moduloproveedor.DineroCheque,
                        moduloproveedor.DineroEfectivo,
                        moduloproveedor.Descripcion
                        
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
                List<ModuloProveedor> lstModuloProveedor = _context.ModuloProveedor.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("ModuloProveedorId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("ProveedorId", typeof(string));
                DataTable.Columns.Add("DineroBanco", typeof(string));
                DataTable.Columns.Add("DineroTotal", typeof(string));
                DataTable.Columns.Add("DineroCheque", typeof(string));
                DataTable.Columns.Add("DineroEfectivo", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                

                foreach (ModuloProveedor moduloproveedor in lstModuloProveedor)
                {
                    DataTable.Rows.Add(
                        moduloproveedor.ModuloProveedorId,
                        moduloproveedor.Active,
                        moduloproveedor.DateTimeCreation,
                        moduloproveedor.DateTimeLastModification,
                        moduloproveedor.UserCreationId,
                        moduloproveedor.UserLastModificationId,
                        moduloproveedor.Fecha,
                        moduloproveedor.ProveedorId,
                        moduloproveedor.DineroBanco,
                        moduloproveedor.DineroTotal,
                        moduloproveedor.DineroCheque,
                        moduloproveedor.DineroEfectivo,
                        moduloproveedor.Descripcion
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
