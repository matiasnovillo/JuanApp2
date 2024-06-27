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
    public interface IProveedorIngresoService
    {
        void ExportToExcel(string path, DataTable dtProveedorIngreso);

        void ExportToCSV(string path, List<ProveedorIngreso> lstProveedorIngreso);

        void ExportToPDF(string path, List<ProveedorIngreso> lstProveedorIngreso);

        List<ProveedorIngreso> ImportExcel(string path, int userId);
    }
}