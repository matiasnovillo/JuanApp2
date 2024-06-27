using JuanApp2.Areas.JuanApp2.ProveedorIngresoBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.ProveedorIngresoBack.Interfaces
{
    public interface IProveedorIngresoRepository
    {
        IQueryable<ProveedorIngreso> AsQueryable();

        #region Queries
        int Count();

        ProveedorIngreso? GetByProveedorIngresoId(int proveedoringresoId);

        List<ProveedorIngreso?> GetAll();

        List<ProveedorIngreso?> GetAllByProveedorIngresoId(List<int> lstProveedorIngresoChecked);

        List<ProveedorIngreso> GetAllByProveedorIngresoIdForModal(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(ProveedorIngreso proveedoringreso);

        bool Update(ProveedorIngreso proveedoringreso);

        bool DeleteByProveedorIngresoId(int proveedoringreso);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByProveedorIngresoIdInDataTable(List<int> lstProveedorIngresoChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}
