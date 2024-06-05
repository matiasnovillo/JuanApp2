using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Entities;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Interfaces;
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

namespace JuanApp2.Areas.JuanApp2.CobranzaBack.Repositories
{
    public class CobranzaRepository : ICobranzaRepository
    {
        protected readonly JuanApp2Context _context;

        public CobranzaRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<Cobranza> AsQueryable()
        {
            try
            {
                return _context.Cobranza.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Cobranza.Count();
            }
            catch (Exception) { throw; }
        }

        public Cobranza? GetByCobranzaId(int cobranzaId)
        {
            try
            {
                return _context.Cobranza
                            .FirstOrDefault(x => x.CobranzaId == cobranzaId);
            }
            catch (Exception) { throw; }
        }

        public List<Cobranza?> GetAll()
        {
            try
            {
                return _context.Cobranza.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<Cobranza> GetAllByCobranzaIdForModal(string textToSearch)
        {
            try
            {
                var query = from cobranza in _context.Cobranza
                            select new { Cobranza = cobranza};

                // Extraemos los resultados en listas separadas
                List<Cobranza> lstCobranza = query.Select(result => result.Cobranza)
                        .Where(x => x.CobranzaId.ToString().Contains(textToSearch))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .ToList();

                return lstCobranza;
            }
            catch (Exception) { throw; }
        }

        public List<Cobranza?> GetAllByCobranzaId(List<int> lstCobranzaChecked)
        {
            try
            {
                List<Cobranza?> lstCobranza = [];

                foreach (int CobranzaId in lstCobranzaChecked)
                {
                    Cobranza cobranza = _context.Cobranza.Where(x => x.CobranzaId == CobranzaId).FirstOrDefault();

                    if (cobranza != null)
                    {
                        lstCobranza.Add(cobranza);
                    }
                }

                return lstCobranza;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(Cobranza cobranza)
        {
            try
            {
                _context.Cobranza.Add(cobranza);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(Cobranza cobranza)
        {
            try
            {
                _context.Cobranza.Update(cobranza);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByCobranzaId(int cobranzaId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.CobranzaId == cobranzaId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByCobranzaIdInDataTable(List<int> lstCobranzaChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("CobranzaId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("CobradorId", typeof(string));
                DataTable.Columns.Add("DineroBanco", typeof(string));
                DataTable.Columns.Add("DineroCheque", typeof(string));
                DataTable.Columns.Add("DineroEfectivo", typeof(string));
                DataTable.Columns.Add("DineroTotal", typeof(string));
                

                foreach (int CobranzaId in lstCobranzaChecked)
                {
                    Cobranza cobranza = _context.Cobranza.Where(x => x.CobranzaId == CobranzaId).FirstOrDefault();

                    if (cobranza != null)
                    {
                        DataTable.Rows.Add(
                        cobranza.CobranzaId,
                        cobranza.Active,
                        cobranza.DateTimeCreation,
                        cobranza.DateTimeLastModification,
                        cobranza.UserCreationId,
                        cobranza.UserLastModificationId,
                        cobranza.CobradorId,
                        cobranza.DineroBanco,
                        cobranza.DineroCheque,
                        cobranza.DineroEfectivo,
                        cobranza.DineroTotal
                        
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
                List<Cobranza> lstCobranza = _context.Cobranza.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("CobranzaId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("CobradorId", typeof(string));
                DataTable.Columns.Add("DineroBanco", typeof(string));
                DataTable.Columns.Add("DineroCheque", typeof(string));
                DataTable.Columns.Add("DineroEfectivo", typeof(string));
                DataTable.Columns.Add("DineroTotal", typeof(string));
                

                foreach (Cobranza cobranza in lstCobranza)
                {
                    DataTable.Rows.Add(
                        cobranza.CobranzaId,
                        cobranza.Active,
                        cobranza.DateTimeCreation,
                        cobranza.DateTimeLastModification,
                        cobranza.UserCreationId,
                        cobranza.UserLastModificationId,
                        cobranza.CobradorId,
                        cobranza.DineroBanco,
                        cobranza.DineroCheque,
                        cobranza.DineroEfectivo,
                        cobranza.DineroTotal
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
