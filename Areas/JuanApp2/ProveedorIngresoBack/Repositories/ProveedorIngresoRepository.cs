using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using JuanApp2.Areas.JuanApp2.ProveedorIngresoBack.Entities;
using JuanApp2.Areas.JuanApp2.ProveedorIngresoBack.Interfaces;
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

namespace JuanApp2.Areas.JuanApp2.ProveedorIngresoBack.Repositories
{
    public class ProveedorIngresoRepository : IProveedorIngresoRepository
    {
        protected readonly JuanApp2Context _context;
        private readonly IMemoryCache _memoryCache;
        private readonly MemoryCacheEntryOptions _memoryCacheEntryOptions;

        public ProveedorIngresoRepository(JuanApp2Context context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;

            _memoryCacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
                SlidingExpiration = TimeSpan.FromMinutes(2)
            };
        }

        public IQueryable<ProveedorIngreso> AsQueryable()
        {
            try
            {
                return _context.ProveedorIngreso.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.ProveedorIngreso.Count();
            }
            catch (Exception) { throw; }
        }

        public ProveedorIngreso? GetByProveedorIngresoId(int proveedoringresoId)
        {
            try
            {
                //Look in cache first
                if (!_memoryCache.TryGetValue($@"JuanApp2.ProveedorIngreso.ProveedorIngresoId={proveedoringresoId}", out ProveedorIngreso? proveedoringreso))
                {
                    //If not exist in cache, look in DB
                    proveedoringreso = _context.ProveedorIngreso
                                .FirstOrDefault(x => x.ProveedorIngresoId == proveedoringresoId);
                    
                    if (proveedoringreso != null)
                    {
                        _memoryCache.Set(proveedoringresoId, proveedoringreso, _memoryCacheEntryOptions);
                    }
                }
                return proveedoringreso;
            }
            catch (Exception) { throw; }
        }

        public List<ProveedorIngreso?> GetAll()
        {
            try
            {
                return _context.ProveedorIngreso.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<ProveedorIngreso> GetAllByProveedorIngresoIdForModal(string textToSearch)
        {
            try
            {
                var query = from proveedoringreso in _context.ProveedorIngreso
                            select new { ProveedorIngreso = proveedoringreso};

                // Extraemos los resultados en listas separadas
                List<ProveedorIngreso> lstProveedorIngreso = query.Select(result => result.ProveedorIngreso)
                        .Where(x => x.ProveedorIngresoId.ToString().Contains(textToSearch))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .ToList();

                return lstProveedorIngreso;
            }
            catch (Exception) { throw; }
        }

        public List<ProveedorIngreso?> GetAllByProveedorIngresoId(List<int> lstProveedorIngresoChecked)
        {
            try
            {
                List<ProveedorIngreso?> lstProveedorIngreso = [];

                foreach (int ProveedorIngresoId in lstProveedorIngresoChecked)
                {
                    ProveedorIngreso proveedoringreso = _context.ProveedorIngreso.Where(x => x.ProveedorIngresoId == ProveedorIngresoId).FirstOrDefault();

                    if (proveedoringreso != null)
                    {
                        lstProveedorIngreso.Add(proveedoringreso);
                    }
                }

                return lstProveedorIngreso;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(ProveedorIngreso proveedoringreso)
        {
            try
            {
                EntityEntry<ProveedorIngreso> ProveedorIngresoToAdd = _context.ProveedorIngreso.Add(proveedoringreso);

                bool result = _context.SaveChanges() > 0;

                if (result)
                {
                    int AddedProveedorIngresoId = ProveedorIngresoToAdd.Entity.ProveedorIngresoId;

                    _memoryCache.Set($@"JuanApp2.ProveedorIngreso.ProveedorIngresoId={AddedProveedorIngresoId}", proveedoringreso, _memoryCacheEntryOptions);
                }

                return result;
            }
            catch (Exception) { throw; }
        }

        public bool Update(ProveedorIngreso proveedoringreso)
        {
            try
            {
                _context.ProveedorIngreso.Update(proveedoringreso);

                bool result = _context.SaveChanges() > 0;

                if (result)
                {
                    _memoryCache.Set($@"JuanApp2.ProveedorIngreso.ProveedorIngresoId={proveedoringreso.ProveedorIngresoId}", proveedoringreso, _memoryCacheEntryOptions);
                }

                return result;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByProveedorIngresoId(int proveedoringresoId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.ProveedorIngresoId == proveedoringresoId)
                        .ExecuteDelete();

                bool result = _context.SaveChanges() > 0;

                if (result)
                {
                    _memoryCache.Remove($@"JuanApp2.ProveedorIngreso.ProveedorIngresoId={proveedoringresoId}");
                }

                return result;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByProveedorIngresoIdInDataTable(List<int> lstProveedorIngresoChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("ProveedorIngresoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("ProveedorId", typeof(string));
                DataTable.Columns.Add("Importe", typeof(string));
                DataTable.Columns.Add("DebeOHaber", typeof(string));
                

                foreach (int ProveedorIngresoId in lstProveedorIngresoChecked)
                {
                    ProveedorIngreso proveedoringreso = _context.ProveedorIngreso.Where(x => x.ProveedorIngresoId == ProveedorIngresoId).FirstOrDefault();

                    if (proveedoringreso != null)
                    {
                        DataTable.Rows.Add(
                        proveedoringreso.ProveedorIngresoId,
                        proveedoringreso.Active,
                        proveedoringreso.DateTimeCreation,
                        proveedoringreso.DateTimeLastModification,
                        proveedoringreso.UserCreationId,
                        proveedoringreso.UserLastModificationId,
                        proveedoringreso.Descripcion,
                        proveedoringreso.Fecha,
                        proveedoringreso.ProveedorId,
                        proveedoringreso.Importe,
                        proveedoringreso.DebeOHaber
                        
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
                List<ProveedorIngreso> lstProveedorIngreso = _context.ProveedorIngreso.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("ProveedorIngresoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Descripcion", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("ProveedorId", typeof(string));
                DataTable.Columns.Add("Importe", typeof(string));
                DataTable.Columns.Add("DebeOHaber", typeof(string));
                

                foreach (ProveedorIngreso proveedoringreso in lstProveedorIngreso)
                {
                    DataTable.Rows.Add(
                        proveedoringreso.ProveedorIngresoId,
                        proveedoringreso.Active,
                        proveedoringreso.DateTimeCreation,
                        proveedoringreso.DateTimeLastModification,
                        proveedoringreso.UserCreationId,
                        proveedoringreso.UserLastModificationId,
                        proveedoringreso.Descripcion,
                        proveedoringreso.Fecha,
                        proveedoringreso.ProveedorId,
                        proveedoringreso.Importe,
                        proveedoringreso.DebeOHaber
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
