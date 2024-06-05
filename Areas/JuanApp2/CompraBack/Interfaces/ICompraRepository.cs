using JuanApp2.Areas.JuanApp2.CompraBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.CompraBack.Interfaces
{
    public interface ICompraRepository
    {
        IQueryable<Compra> AsQueryable();

        #region Queries
        int Count();

        Compra? GetByCompraId(int compraId);

        List<Compra?> GetAll();

        List<Compra?> GetAllByCompraId(List<int> lstCompraChecked);

        List<Compra> GetAllByCompraIdForModal(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(Compra compra);

        bool Update(Compra compra);

        bool DeleteByCompraId(int compra);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByCompraIdInDataTable(List<int> lstCompraChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}
