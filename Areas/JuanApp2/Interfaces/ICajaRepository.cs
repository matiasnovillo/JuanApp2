using JuanApp2.Areas.JuanApp2.Entities;
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

namespace JuanApp2.Areas.JuanApp2.Interfaces
{
    public interface ICajaRepository
    {
        IQueryable<Caja> AsQueryable();

        #region Queries
        int Count();

        Caja? GetByCajaId(int cajaId);

        List<Caja?> GetAll();
        #endregion

        #region Non-Queries
        bool Add(Caja caja);

        bool Update(Caja caja);

        bool DeleteByCajaId(int caja);
        #endregion

        #region Other methods
        DataTable GetAllInDataTable();
        #endregion
    }
}
