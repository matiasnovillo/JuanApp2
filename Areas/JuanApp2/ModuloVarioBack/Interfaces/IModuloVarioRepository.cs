using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.ModuloVarioBack.Interfaces
{
    public interface IModuloVarioRepository
    {
        IQueryable<ModuloVario> AsQueryable();

        #region Queries
        int Count();

        ModuloVario? GetByModuloVarioId(int modulovarioId);

        List<ModuloVario?> GetAll();

        List<ModuloVario?> GetAllByModuloVarioId(List<int> lstModuloVarioChecked);

        List<ModuloVario> GetAllByModuloVarioIdForModal(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(ModuloVario modulovario);

        bool Update(ModuloVario modulovario);

        bool DeleteByModuloVarioId(int modulovario);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByModuloVarioIdInDataTable(List<int> lstModuloVarioChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}
