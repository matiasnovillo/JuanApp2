using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.CompraBack.Entities;
using JuanApp2.Areas.JuanApp2.CompraBack.Interfaces;
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

namespace JuanApp2.Areas.JuanApp2.CompraBack.Repositories
{
    public class CompraRepository : ICompraRepository
    {
        protected readonly JuanApp2Context _context;

        public CompraRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<Compra> AsQueryable()
        {
            try
            {
                return _context.Compra.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Compra.Count();
            }
            catch (Exception) { throw; }
        }

        public Compra? GetByCompraId(int compraId)
        {
            try
            {
                return _context.Compra
                            .FirstOrDefault(x => x.CompraId == compraId);
            }
            catch (Exception) { throw; }
        }

        public List<Compra?> GetAll()
        {
            try
            {
                return _context.Compra.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<Compra> GetAllByCompraIdForModal(string textToSearch)
        {
            try
            {
                var query = from compra in _context.Compra
                            select new { Compra = compra};

                // Extraemos los resultados en listas separadas
                List<Compra> lstCompra = query.Select(result => result.Compra)
                        .Where(x => x.CompraId.ToString().Contains(textToSearch))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .ToList();

                return lstCompra;
            }
            catch (Exception) { throw; }
        }

        public List<Compra?> GetAllByCompraId(List<int> lstCompraChecked)
        {
            try
            {
                List<Compra?> lstCompra = [];

                foreach (int CompraId in lstCompraChecked)
                {
                    Compra compra = _context.Compra.Where(x => x.CompraId == CompraId).FirstOrDefault();

                    if (compra != null)
                    {
                        lstCompra.Add(compra);
                    }
                }

                return lstCompra;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(Compra compra)
        {
            try
            {
                _context.Compra.Add(compra);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(Compra compra)
        {
            try
            {
                _context.Compra.Update(compra);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByCompraId(int compraId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.CompraId == compraId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByCompraIdInDataTable(List<int> lstCompraChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("CompraId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("DiaDePago", typeof(string));
                DataTable.Columns.Add("Referencia", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                DataTable.Columns.Add("Unidad", typeof(string));
                DataTable.Columns.Add("Kilogramo", typeof(string));
                DataTable.Columns.Add("Precio", typeof(string));
                DataTable.Columns.Add("Subtotal", typeof(string));
                DataTable.Columns.Add("DebeOHaber", typeof(string));
                DataTable.Columns.Add("ProveedorId", typeof(string));
                

                foreach (int CompraId in lstCompraChecked)
                {
                    Compra compra = _context.Compra.Where(x => x.CompraId == CompraId).FirstOrDefault();

                    if (compra != null)
                    {
                        DataTable.Rows.Add(
                        compra.CompraId,
                        compra.Active,
                        compra.DateTimeCreation,
                        compra.DateTimeLastModification,
                        compra.UserCreationId,
                        compra.UserLastModificationId,
                        compra.Fecha,
                        compra.DiaDePago,
                        compra.Referencia,
                        compra.Descripcion,
                        compra.Unidad,
                        compra.Kilogramo,
                        compra.Precio,
                        compra.Subtotal,
                        compra.DebeOHaber,
                        compra.ProveedorId
                        
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
                List<Compra> lstCompra = _context.Compra.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("CompraId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("DiaDePago", typeof(string));
                DataTable.Columns.Add("Referencia", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                DataTable.Columns.Add("Unidad", typeof(string));
                DataTable.Columns.Add("Kilogramo", typeof(string));
                DataTable.Columns.Add("Precio", typeof(string));
                DataTable.Columns.Add("Subtotal", typeof(string));
                DataTable.Columns.Add("DebeOHaber", typeof(string));
                DataTable.Columns.Add("ProveedorId", typeof(string));
                

                foreach (Compra compra in lstCompra)
                {
                    DataTable.Rows.Add(
                        compra.CompraId,
                        compra.Active,
                        compra.DateTimeCreation,
                        compra.DateTimeLastModification,
                        compra.UserCreationId,
                        compra.UserLastModificationId,
                        compra.Fecha,
                        compra.DiaDePago,
                        compra.Referencia,
                        compra.Descripcion,
                        compra.Unidad,
                        compra.Kilogramo,
                        compra.Precio,
                        compra.Subtotal,
                        compra.DebeOHaber,
                        compra.ProveedorId
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
