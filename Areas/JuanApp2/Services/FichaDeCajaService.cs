using ClosedXML.Excel;
using CsvHelper;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Entities;
using System.Data;
using System.Globalization;
using JuanApp2.Areas.JuanApp2.Interfaces;

namespace JuanApp2.Areas.JuanApp2.Services
{
    public class FichaDeCajaService : IFichaDeCajaService
    {
        public void ExportToExcel(string path, DataTable dtProveedor)
        {
            using var Book = new XLWorkbook();

            DataTable dtProveedorOriginal = new()
            {
                TableName = "Proveedor"
            };

            //We define another DataTable dtProveedorCopy to avoid issue related to DateTime conversion
            DataTable dtProveedorCopy = new()
            {
                TableName = "Proveedor"
            };

            #region Define columns for dtProveedorCopy
            DataColumn dtColumnIDFordtProveedorCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "ID"
            };
            dtProveedorCopy.Columns.Add(dtColumnIDFordtProveedorCopy);

            DataColumn dtColumnFechaFordtProveedorCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Fecha"
            };
            dtProveedorCopy.Columns.Add(dtColumnFechaFordtProveedorCopy);

            DataColumn dtColumnReferenciaFordtProveedorCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Referencia"
            };
            dtProveedorCopy.Columns.Add(dtColumnReferenciaFordtProveedorCopy);

            DataColumn dtColumnProveedorFordtProveedorCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Proveedor"
            };
            dtProveedorCopy.Columns.Add(dtColumnProveedorFordtProveedorCopy);

            DataColumn dtColumnDescripcionFordtProveedorCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Descripcion"
            };
            dtProveedorCopy.Columns.Add(dtColumnDescripcionFordtProveedorCopy);

            DataColumn dtColumnDebeFordtProveedorCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Debe"
            };
            dtProveedorCopy.Columns.Add(dtColumnDebeFordtProveedorCopy);

            DataColumn dtColumnHaberFordtProveedorCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Haber"
            };
            dtProveedorCopy.Columns.Add(dtColumnHaberFordtProveedorCopy);

            DataColumn dtColumnSaldoFordtProveedorCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Saldo"
            };
            dtProveedorCopy.Columns.Add(dtColumnSaldoFordtProveedorCopy);
            #endregion

            dtProveedorOriginal = dtProveedor;

            foreach (DataRow DataRow in dtProveedorOriginal.Rows)
            {
                dtProveedorCopy.Rows.Add(DataRow.ItemArray);
            }

            var Sheet = Book.Worksheets.Add(dtProveedorCopy);

            Sheet.ColumnsUsed().AdjustToContents();

            Book.SaveAs(path);
        }
    }
}
