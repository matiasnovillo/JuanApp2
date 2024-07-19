using JuanApp2.Areas.JuanApp2.GastoBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.GastoBack.Interfaces
{
    public interface IGastoRepository
    {
        IQueryable<Gasto> AsQueryable();

        #region Queries
        int Count();

        Gasto? GetByGastoId(int gastoId);

        List<Gasto?> GetAll();

        List<Gasto?> GetAllByGastoId(List<int> lstGastoChecked);

        List<Gasto> GetAllByGastoIdForModal(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(Gasto gasto);

        bool Update(Gasto gasto);

        bool DeleteByGastoId(int gasto);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByGastoIdInDataTable(List<int> lstGastoChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}
