using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Interfaces
{
    public interface IModuloProveedorRepository
    {
        IQueryable<ModuloProveedor> AsQueryable();

        #region Queries
        int Count();

        ModuloProveedor? GetByModuloProveedorId(int moduloproveedorId);

        List<ModuloProveedor?> GetAll();

        List<ModuloProveedor?> GetAllByModuloProveedorId(List<int> lstModuloProveedorChecked);

        List<ModuloProveedor> GetAllByModuloProveedorIdForModal(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(ModuloProveedor moduloproveedor);

        bool Update(ModuloProveedor moduloproveedor);

        bool DeleteByModuloProveedorId(int moduloproveedor);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByModuloProveedorIdInDataTable(List<int> lstModuloProveedorChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}