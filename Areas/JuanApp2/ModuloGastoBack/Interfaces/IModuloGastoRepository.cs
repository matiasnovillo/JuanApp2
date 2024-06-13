using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.ModuloGastoBack.Interfaces
{
    public interface IModuloGastoRepository
    {
        IQueryable<ModuloGasto> AsQueryable();

        #region Queries
        int Count();

        ModuloGasto? GetByModuloGastoId(int modulogastoId);

        List<ModuloGasto?> GetAll();

        List<ModuloGasto?> GetAllByModuloGastoId(List<int> lstModuloGastoChecked);

        List<ModuloGasto> GetAllByModuloGastoIdForModal(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(ModuloGasto modulogasto);

        bool Update(ModuloGasto modulogasto);

        bool DeleteByModuloGastoId(int modulogasto);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByModuloGastoIdInDataTable(List<int> lstModuloGastoChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}
