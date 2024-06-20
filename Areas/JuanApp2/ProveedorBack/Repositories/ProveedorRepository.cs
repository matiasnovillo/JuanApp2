using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Entities;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using JuanApp2.DatabaseContexts;
using System.Text.RegularExpressions;
using System.Data;
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

namespace JuanApp2.Areas.JuanApp2.ProveedorBack.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        protected readonly JuanApp2Context _context;

        public ProveedorRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<Proveedor> AsQueryable()
        {
            try
            {
                return _context.Proveedor.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Proveedor.Count();
            }
            catch (Exception) { throw; }
        }

        public Proveedor? GetByProveedorId(int proveedorId)
        {
            try
            {
                return _context.Proveedor
                            .FirstOrDefault(x => x.ProveedorId == proveedorId);
            }
            catch (Exception) { throw; }
        }

        public Proveedor? GetByNombreCompleto(string txtBuscar)
        {
            try
            {
                string[] words = Regex
                       .Replace(txtBuscar
                       .Trim(), @"\s+", " ")
                       .Split(" ");

                Proveedor Proveedor = _context.Proveedor
                    .Where(x => words.Any(word => x.NombreCompleto.Contains(word)))
                    .FirstOrDefault();

                return Proveedor;
            }
            catch (Exception) { throw; }
        }

        public Proveedor? GetByReferenciaDescripcion(string txtBuscar)
        {
            try
            {
                string[] words = Regex
                       .Replace(txtBuscar
                       .Trim(), @"\s+", " ")
                       .Split(" ");

                Proveedor Proveedor = _context.Proveedor
                    .Where(x => words.Any(word => x.NombreCompleto.Contains(word)))
                    .FirstOrDefault();

                return Proveedor;
            }
            catch (Exception) { throw; }
        }

        public List<Proveedor?> GetAll()
        {
            try
            {
                return _context.Proveedor.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<Proveedor> GetAllByProveedorIdForModal(string textToSearch)
        {
            try
            {
                var query = from proveedor in _context.Proveedor
                            select new { Proveedor = proveedor};

                // Extraemos los resultados en listas separadas
                List<Proveedor> lstProveedor = query.Select(result => result.Proveedor)
                        .Where(x => x.ProveedorId.ToString().Contains(textToSearch))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .ToList();

                return lstProveedor;
            }
            catch (Exception) { throw; }
        }

        public List<Proveedor?> GetAllByProveedorId(List<int> lstProveedorChecked)
        {
            try
            {
                List<Proveedor?> lstProveedor = [];

                foreach (int ProveedorId in lstProveedorChecked)
                {
                    Proveedor proveedor = _context.Proveedor.Where(x => x.ProveedorId == ProveedorId).FirstOrDefault();

                    if (proveedor != null)
                    {
                        lstProveedor.Add(proveedor);
                    }
                }

                return lstProveedor;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(Proveedor proveedor)
        {
            try
            {
                _context.Proveedor.Add(proveedor);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(Proveedor proveedor)
        {
            try
            {
                _context.Proveedor.Update(proveedor);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByProveedorId(int proveedorId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.ProveedorId == proveedorId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByProveedorIdInDataTable(List<int> lstProveedorChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("ProveedorId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("NombreCompleto", typeof(string));
                DataTable.Columns.Add("Celular", typeof(string));
                DataTable.Columns.Add("Direccion", typeof(string));
                DataTable.Columns.Add("PaginaWeb", typeof(string));
                

                foreach (int ProveedorId in lstProveedorChecked)
                {
                    Proveedor proveedor = _context.Proveedor.Where(x => x.ProveedorId == ProveedorId).FirstOrDefault();

                    if (proveedor != null)
                    {
                        DataTable.Rows.Add(
                        proveedor.ProveedorId,
                        proveedor.Active,
                        proveedor.DateTimeCreation,
                        proveedor.DateTimeLastModification,
                        proveedor.UserCreationId,
                        proveedor.UserLastModificationId,
                        proveedor.NombreCompleto,
                        proveedor.Celular,
                        proveedor.Direccion,
                        proveedor.PaginaWeb
                        
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
                List<Proveedor> lstProveedor = _context.Proveedor.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("ProveedorId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("NombreCompleto", typeof(string));
                DataTable.Columns.Add("Celular", typeof(string));
                DataTable.Columns.Add("Direccion", typeof(string));
                DataTable.Columns.Add("PaginaWeb", typeof(string));
                

                foreach (Proveedor proveedor in lstProveedor)
                {
                    DataTable.Rows.Add(
                        proveedor.ProveedorId,
                        proveedor.Active,
                        proveedor.DateTimeCreation,
                        proveedor.DateTimeLastModification,
                        proveedor.UserCreationId,
                        proveedor.UserLastModificationId,
                        proveedor.NombreCompleto,
                        proveedor.Celular,
                        proveedor.Direccion,
                        proveedor.PaginaWeb
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
