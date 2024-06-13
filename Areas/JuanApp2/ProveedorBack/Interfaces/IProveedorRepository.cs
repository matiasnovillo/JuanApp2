using JuanApp2.Areas.JuanApp2.ProveedorBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces
{
    public interface IProveedorRepository
    {
        IQueryable<Proveedor> AsQueryable();

        #region Queries
        int Count();

        Proveedor? GetByProveedorId(int proveedorId);

        Proveedor? GetByNombreCompleto(string nombreCompleto);

        List<Proveedor?> GetAll();

        List<Proveedor?> GetAllByProveedorId(List<int> lstProveedorChecked);

        List<Proveedor> GetAllByProveedorIdForModal(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(Proveedor proveedor);

        bool Update(Proveedor proveedor);

        bool DeleteByProveedorId(int proveedor);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByProveedorIdInDataTable(List<int> lstProveedorChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}
