using JuanApp2.Areas.JuanApp2.CobradorBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces
{
    public interface ICobradorRepository
    {
        IQueryable<Cobrador> AsQueryable();

        #region Queries
        int Count();

        Cobrador? GetByCobradorId(int cobradorId);

        List<Cobrador?> GetAll();

        List<Cobrador?> GetAllByCobradorIdWithIDsList(List<int> lstIDs);

        List<Cobrador?> GetAllByCobradorId(List<int> lstCobradorChecked);

        List<Cobrador> GetAllByCobradorIdForModal(string textToSearch);

        Cobrador? GetByNombreCompleto(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(Cobrador cobrador);

        bool Update(Cobrador cobrador);

        bool DeleteByCobradorId(int cobrador);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByCobradorIdInDataTable(List<int> lstCobradorChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}
