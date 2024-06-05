using JuanApp2.Areas.JuanApp2.CobranzaBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.CobranzaBack.Interfaces
{
    public interface ICobranzaRepository
    {
        IQueryable<Cobranza> AsQueryable();

        #region Queries
        int Count();

        Cobranza? GetByCobranzaId(int cobranzaId);

        List<Cobranza?> GetAll();

        List<Cobranza?> GetAllByCobranzaId(List<int> lstCobranzaChecked);

        List<Cobranza> GetAllByCobranzaIdForModal(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(Cobranza cobranza);

        bool Update(Cobranza cobranza);

        bool DeleteByCobranzaId(int cobranza);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByCobranzaIdInDataTable(List<int> lstCobranzaChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}
