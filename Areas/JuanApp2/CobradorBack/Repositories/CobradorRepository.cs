using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.CobradorBack.Entities;
using JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces;
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

namespace JuanApp2.Areas.JuanApp2.CobradorBack.Repositories
{
    public class CobradorRepository : ICobradorRepository
    {
        protected readonly JuanApp2Context _context;

        public CobradorRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<Cobrador> AsQueryable()
        {
            try
            {
                return _context.Cobrador.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Cobrador.Count();
            }
            catch (Exception) { throw; }
        }

        public Cobrador? GetByCobradorId(int cobradorId)
        {
            try
            {
                return _context.Cobrador
                            .FirstOrDefault(x => x.CobradorId == cobradorId);
            }
            catch (Exception) { throw; }
        }

        public List<Cobrador?> GetAll()
        {
            try
            {
                return _context.Cobrador.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<Cobrador> GetAllByCobradorIdForModal(string textToSearch)
        {
            try
            {
                var query = from cobrador in _context.Cobrador
                            select new { Cobrador = cobrador};

                // Extraemos los resultados en listas separadas
                List<Cobrador> lstCobrador = query.Select(result => result.Cobrador)
                        .Where(x => x.CobradorId.ToString().Contains(textToSearch))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .ToList();

                return lstCobrador;
            }
            catch (Exception) { throw; }
        }

        public List<Cobrador?> GetAllByCobradorId(List<int> lstCobradorChecked)
        {
            try
            {
                List<Cobrador?> lstCobrador = [];

                foreach (int CobradorId in lstCobradorChecked)
                {
                    Cobrador cobrador = _context.Cobrador.Where(x => x.CobradorId == CobradorId).FirstOrDefault();

                    if (cobrador != null)
                    {
                        lstCobrador.Add(cobrador);
                    }
                }

                return lstCobrador;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(Cobrador cobrador)
        {
            try
            {
                _context.Cobrador.Add(cobrador);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(Cobrador cobrador)
        {
            try
            {
                _context.Cobrador.Update(cobrador);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByCobradorId(int cobradorId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.CobradorId == cobradorId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByCobradorIdInDataTable(List<int> lstCobradorChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("CobradorId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("NombreCompleto", typeof(string));
                DataTable.Columns.Add("Celular", typeof(string));
                DataTable.Columns.Add("Direccion", typeof(string));
                DataTable.Columns.Add("Email", typeof(string));
                

                foreach (int CobradorId in lstCobradorChecked)
                {
                    Cobrador cobrador = _context.Cobrador.Where(x => x.CobradorId == CobradorId).FirstOrDefault();

                    if (cobrador != null)
                    {
                        DataTable.Rows.Add(
                        cobrador.CobradorId,
                        cobrador.Active,
                        cobrador.DateTimeCreation,
                        cobrador.DateTimeLastModification,
                        cobrador.UserCreationId,
                        cobrador.UserLastModificationId,
                        cobrador.NombreCompleto,
                        cobrador.Celular,
                        cobrador.Direccion,
                        cobrador.Email
                        
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
                List<Cobrador> lstCobrador = _context.Cobrador.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("CobradorId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("NombreCompleto", typeof(string));
                DataTable.Columns.Add("Celular", typeof(string));
                DataTable.Columns.Add("Direccion", typeof(string));
                DataTable.Columns.Add("Email", typeof(string));
                

                foreach (Cobrador cobrador in lstCobrador)
                {
                    DataTable.Rows.Add(
                        cobrador.CobradorId,
                        cobrador.Active,
                        cobrador.DateTimeCreation,
                        cobrador.DateTimeLastModification,
                        cobrador.UserCreationId,
                        cobrador.UserLastModificationId,
                        cobrador.NombreCompleto,
                        cobrador.Celular,
                        cobrador.Direccion,
                        cobrador.Email
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
