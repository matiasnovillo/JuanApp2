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
    public interface ITipoDeMovimientoService
    {
        void ExportToExcel(string path, DataTable dtTipoDeMovimiento);

        void ExportToCSV(string path, List<TipoDeMovimiento> lstTipoDeMovimiento);

        void ExportToPDF(string path, List<TipoDeMovimiento> lstTipoDeMovimiento);

        List<TipoDeMovimiento> ImportExcel(string path, int userId);
    }
}