using ClosedXML.Excel;
using IronPdf;
using CsvHelper;
using JuanApp2.Areas.JuanApp2.GastoBack.Entities;
using JuanApp2.Areas.JuanApp2.GastoBack.Interfaces;
using System.Data;
using System.Globalization;

namespace JuanApp2.Areas.JuanApp2.GastoBack.Services
{
    public class GastoService : IGastoService
    {
        public void ExportToExcel(string path, DataTable dtGasto)
        {
            using var Book = new XLWorkbook();

            DataTable dtGastoOriginal = new()
            {
                TableName = "Gasto"
            };

            //We define another DataTable dtGastoCopy to avoid issue related to DateTime conversion
            DataTable dtGastoCopy = new()
            {
                TableName = "Gasto"
            };

            #region Define columns for dtGastoCopy
            DataColumn dtColumnGastoIdFordtGastoCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "ID"
            };
            dtGastoCopy.Columns.Add(dtColumnGastoIdFordtGastoCopy);

            DataColumn dtColumnActiveFordtGastoCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Referencia"
            };
            dtGastoCopy.Columns.Add(dtColumnActiveFordtGastoCopy);

            DataColumn dtColumnDateTimeCreationFordtGastoCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Fecha"
            };
            dtGastoCopy.Columns.Add(dtColumnDateTimeCreationFordtGastoCopy);

            DataColumn dtColumnDateTimeLastModificationFordtGastoCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Descripcion"
            };
            dtGastoCopy.Columns.Add(dtColumnDateTimeLastModificationFordtGastoCopy);

            DataColumn dtColumnUserCreationIdFordtGastoCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Importe"
            };
            dtGastoCopy.Columns.Add(dtColumnUserCreationIdFordtGastoCopy);

            DataColumn dtColumnUserLastModificationIdFordtGastoCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Saldo negativo"
            };
            dtGastoCopy.Columns.Add(dtColumnUserLastModificationIdFordtGastoCopy);
            #endregion

            dtGastoOriginal = dtGasto;

            foreach (DataRow DataRow in dtGastoOriginal.Rows)
            {
                dtGastoCopy.Rows.Add(DataRow.ItemArray);
            }

            var Sheet = Book.Worksheets.Add(dtGastoCopy);

            Sheet.ColumnsUsed().AdjustToContents();

            Book.SaveAs(path);
        }
    }
}
