using ClosedXML.Excel;
using IronPdf;
using CsvHelper;
using JuanApp2.Areas.JuanApp2.CompraBack.Entities;
using JuanApp2.Areas.JuanApp2.CompraBack.Interfaces;
using System.Data;
using System.Globalization;

namespace JuanApp2.Areas.JuanApp2.CompraBack.Services
{
    public class CompraService : ICompraService
    {
        #region Exportations
        public void ExportToExcel(string path, DataTable dtCompra)
        {
            using var Book = new XLWorkbook();

            DataTable dtCompraOriginal = new()
            {
                TableName = "Compra"
            };

            //We define another DataTable dtCompraCopy to avoid issue related to DateTime conversion
            DataTable dtCompraCopy = new()
            {
                TableName = "Compra"
            };

            #region Define columns for dtCompraCopy
            DataColumn dtColumnCompraIdFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "CompraId"
            };
            dtCompraCopy.Columns.Add(dtColumnCompraIdFordtCompraCopy);

            DataColumn dtColumnActiveFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Active"
            };
            dtCompraCopy.Columns.Add(dtColumnActiveFordtCompraCopy);

            DataColumn dtColumnDateTimeCreationFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "DateTimeCreation"
            };
            dtCompraCopy.Columns.Add(dtColumnDateTimeCreationFordtCompraCopy);

            DataColumn dtColumnDateTimeLastModificationFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "DateTimeLastModification"
            };
            dtCompraCopy.Columns.Add(dtColumnDateTimeLastModificationFordtCompraCopy);

            DataColumn dtColumnUserCreationIdFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "UserCreationId"
            };
            dtCompraCopy.Columns.Add(dtColumnUserCreationIdFordtCompraCopy);

            DataColumn dtColumnUserLastModificationIdFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "UserLastModificationId"
            };
            dtCompraCopy.Columns.Add(dtColumnUserLastModificationIdFordtCompraCopy);

            DataColumn dtColumnFechaFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Fecha"
            };
            dtCompraCopy.Columns.Add(dtColumnFechaFordtCompraCopy);

            DataColumn dtColumnDiaDePagoFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "DiaDePago"
            };
            dtCompraCopy.Columns.Add(dtColumnDiaDePagoFordtCompraCopy);

            DataColumn dtColumnReferenciaFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Referencia"
            };
            dtCompraCopy.Columns.Add(dtColumnReferenciaFordtCompraCopy);

            DataColumn dtColumnDescripcionFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Descripcion"
            };
            dtCompraCopy.Columns.Add(dtColumnDescripcionFordtCompraCopy);

            DataColumn dtColumnUnidadFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Unidad"
            };
            dtCompraCopy.Columns.Add(dtColumnUnidadFordtCompraCopy);

            DataColumn dtColumnKilogramoFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Kilogramo"
            };
            dtCompraCopy.Columns.Add(dtColumnKilogramoFordtCompraCopy);

            DataColumn dtColumnPrecioFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Precio"
            };
            dtCompraCopy.Columns.Add(dtColumnPrecioFordtCompraCopy);

            DataColumn dtColumnSubtotalFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "Subtotal"
            };
            dtCompraCopy.Columns.Add(dtColumnSubtotalFordtCompraCopy);

            DataColumn dtColumnDebeOHaberFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "DebeOHaber"
            };
            dtCompraCopy.Columns.Add(dtColumnDebeOHaberFordtCompraCopy);

            DataColumn dtColumnProveedorIdFordtCompraCopy = new()
            {
                DataType = typeof(string),
                ColumnName = "ProveedorId"
            };
            dtCompraCopy.Columns.Add(dtColumnProveedorIdFordtCompraCopy);

            
            #endregion

            dtCompraOriginal = dtCompra;

            foreach (DataRow DataRow in dtCompraOriginal.Rows)
            {
                dtCompraCopy.Rows.Add(DataRow.ItemArray);
            }

            var Sheet = Book.Worksheets.Add(dtCompraCopy);

            Sheet.ColumnsUsed().AdjustToContents();

            Book.SaveAs(path);
        }

        public void ExportToCSV(string path, List<Compra> lstCompra)
        {
            using var Writer = new StreamWriter(path);

            using var CsvWriter = new CsvWriter(Writer, CultureInfo.InvariantCulture);

            CsvWriter.WriteRecords(lstCompra);
        }

        public void ExportToPDF(string path, List<Compra> lstCompra)
        {
            string ProjectName = "EmptyProject";
            string Table = "Compra";
            var Renderer = new HtmlToPdf();
            string RowsAsHTML = "";


            foreach (Compra? Compra in lstCompra)
            {
                RowsAsHTML += $@"{Compra?.ToStringOnlyValuesForHTML()}";
            }

            Renderer.RenderHtmlAsPdf($@"<table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""88%"" style=""width: 88% !important; min-width: 88%; max-width: 88%;"">
    <tr>
    <td align=""left"" valign=""top"">
        <font face=""'Source Sans Pro', sans-serif"" color=""#1a1a1a"" style=""font-size: 52px; line-height: 55px; font-weight: 300; letter-spacing: -1.5px;"">
            <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #1a1a1a; font-size: 52px; line-height: 55px; font-weight: 300; letter-spacing: -1.5px;"">{ProjectName}</span>
        </font>
        <div style=""height: 25px; line-height: 25px; font-size: 23px;"">&nbsp;</div>
        <font face=""'Source Sans Pro', sans-serif"" color=""#4c4c4c"" style=""font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"">
            <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #4c4c4c; font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"">Registers of {Table}</span>
        </font>
        <div style=""height: 35px; line-height: 35px; font-size: 33px;"">&nbsp;</div>
    </td>
    </tr>
</table>
<br>
<table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""100%"" style=""width: 100% !important; min-width: 100%; max-width: 100%;"">
    <tr>
        <th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">CompraId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Active&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">DateTimeCreation&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">DateTimeLastModification&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">UserCreationId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">UserLastModificationId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Boolean&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">DateTime&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Decimal&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Integer&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextArea&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextBasic&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextEditor&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextEmail&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextFile&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextHexColour&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextPassword&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextPhoneNumber&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextTag&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">TextURL&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">CompraStatusId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th>
    </tr>
    {RowsAsHTML}
</table>
<br>
<font face=""'Source Sans Pro', sans-serif"" color=""#868686"" style=""font-size: 17px; line-height: 20px;"">
    <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #868686; font-size: 17px; line-height: 20px;"">Printed on: {DateTime.Now}</span>
</font>
").SaveAs(path);
        }
        #endregion

        #region Importations
        public List<Compra> ImportExcel(string path, int userId)
        {
            List<Compra> lstCompra = [];

            var WorkBook = new XLWorkbook(path);
            var Rows = WorkBook.Worksheet(1).RangeUsed().RowsUsed();

            foreach (var row in Rows)
            {
                var rowNumber = row.RowNumber();

                if (rowNumber > 1)
                {
                    DateTime Fecha = Convert.ToDateTime(row.Cell(7).GetString());
                    int DiaDePago = Convert.ToInt32(row.Cell(8).GetString());
                    string Referencia = row.Cell(9).GetString();
                    string Descripcion = row.Cell(10).GetString();
                    int Unidad = Convert.ToInt32(row.Cell(11).GetString());
                    decimal Kilogramo = Convert.ToDecimal(row.Cell(12).GetString());
                    decimal Precio = Convert.ToDecimal(row.Cell(13).GetString());
                    decimal Subtotal = Convert.ToDecimal(row.Cell(14).GetString());
                    bool DebeOHaber = Convert.ToBoolean(row.Cell(15).GetString());
                    int ProveedorId = Convert.ToInt32(row.Cell(16).GetString());
                    

                    Compra Compra = new()
                    {
                        CompraId = 0,
                        Active = true,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        UserCreationId = userId,
                        UserLastModificationId = userId,
                        Fecha = Fecha,
                        DiaDePago = DiaDePago,
                        Referencia = Referencia,
                        Descripcion = Descripcion,
                        Unidad = Unidad,
                        Kilogramo = Kilogramo,
                        Precio = Precio,
                        Subtotal = Subtotal,
                        DebeOHaber = DebeOHaber,
                        ProveedorId = ProveedorId,
                        
                    };

                    lstCompra.Add(Compra);
                }
            }

            return lstCompra;
        }
        #endregion
    }
}
