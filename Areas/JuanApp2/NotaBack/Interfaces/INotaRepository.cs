using JuanApp2.Areas.JuanApp2.NotaBack.Entities;
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

namespace JuanApp2.Areas.JuanApp2.NotaBack.Interfaces
{
    public interface INotaRepository
    {
        IQueryable<Nota> AsQueryable();

        #region Queries
        int Count();

        Nota? GetByNotaId(int notaId);

        Nota? GetNota1();

        Nota? GetNota2();

        Nota? GetNota3();

        Nota? GetNota4();

        List<Nota?> GetAll();

        List<Nota?> GetAllByNotaId(List<int> lstNotaChecked);

        List<Nota> GetAllByNotaIdForModal(string textToSearch);
        #endregion

        #region Non-Queries
        bool Add(Nota nota);

        bool Update(Nota nota);

        bool UpdateNota1(Nota nota);

        bool UpdateNota2(Nota nota);

        bool UpdateNota3(Nota nota);

        bool UpdateNota4(Nota nota);

        bool DeleteByNotaId(int nota);
        #endregion

        #region Methods for DataTable
        DataTable GetAllByNotaIdInDataTable(List<int> lstNotaChecked);

        DataTable GetAllInDataTable();
        #endregion
    }
}
