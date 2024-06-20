using JuanApp2.Areas.JuanApp2.TipoDeMovimientoBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.TipoDeMovimientoBack.Interfaces
{
    public interface ITipoDeMovimientoRepository
    {
        IQueryable<TipoDeMovimiento> AsQueryable();

        #region Queries
        int Count();

        TipoDeMovimiento? GetByTipoDeMovimientoId(int tipodemovimientoId);

        List<TipoDeMovimiento?> GetAll();

        List<TipoDeMovimiento?> GetAllByTipoDeMovimientoId(List<int> lstTipoDeMovimientoChecked);

        List<TipoDeMovimiento> GetAllByTipoDeMovimientoIdForModal(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(TipoDeMovimiento tipodemovimiento);

        bool Update(TipoDeMovimiento tipodemovimiento);

        bool DeleteByTipoDeMovimientoId(int tipodemovimiento);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByTipoDeMovimientoIdInDataTable(List<int> lstTipoDeMovimientoChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}
