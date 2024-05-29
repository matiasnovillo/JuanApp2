using DocumentFormat.OpenXml.Spreadsheet;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using PdfSharp;
using PdfSharp.Pdf;
using System.Text.RegularExpressions;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace JuanApp.Formularios.Salida
{
    public partial class ConsultaSalida : Form
    {
        private readonly ISalidaRepository _salidaRepository;
        private readonly ISalidaService _salidaService;
        private readonly IRemitoRepository _remitoRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly ServiceProvider _serviceProvider;

        private decimal KilosRealesTotal = 0;
        private decimal PrecioTotal = 0;
        private decimal SubtotalTotal = 0;
        private string CodigoCliente = "";
        private string NombreCliente = "";

        public ConsultaSalida(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;
                _salidaRepository = serviceProvider.GetRequiredService<ISalidaRepository>();
                _salidaService = serviceProvider.GetRequiredService<ISalidaService>();
                _remitoRepository = serviceProvider.GetRequiredService<IRemitoRepository>();
                _clienteRepository = serviceProvider.GetRequiredService<IClienteRepository>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "SalidaId";
                col0.HeaderText = "ID del sistema";
                DataGridViewSalida.Columns.Add(col0);

                DataGridViewTextBoxColumn col8 = new();
                col8.DataPropertyName = "NroDePesaje";
                col8.HeaderText = "Nº de pesaje";
                DataGridViewSalida.Columns.Add(col8);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "CodigoDeCliente";
                col1.HeaderText = "Código de cliente";
                DataGridViewSalida.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "NombreDeCliente";
                col2.HeaderText = "Nombre de cliente";
                col2.Width = 250;
                DataGridViewSalida.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "CodigoDeProducto";
                col3.HeaderText = "Código de producto";
                DataGridViewSalida.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new();
                col4.DataPropertyName = "NombreDeProducto";
                col4.HeaderText = "Nombre de producto";
                col4.Width = 250;
                DataGridViewSalida.Columns.Add(col4);

                DataGridViewTextBoxColumn col5 = new();
                col5.DataPropertyName = "KilosReales";
                col5.HeaderText = "Kilos Reales";
                DataGridViewSalida.Columns.Add(col5);

                DataGridViewTextBoxColumn col6 = new();
                col6.DataPropertyName = "Precio";
                col6.HeaderText = "Precio";
                DataGridViewSalida.Columns.Add(col6);

                DataGridViewTextBoxColumn col7 = new();
                col7.DataPropertyName = "Subtotal";
                col7.HeaderText = "Subtotal";
                DataGridViewSalida.Columns.Add(col7);

                DataGridViewTextBoxColumn col9 = new();
                col9.DataPropertyName = "DateTimeLastModification";
                col9.HeaderText = "Fecha de última modificación";
                DataGridViewSalida.Columns.Add(col9);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewSalida.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewSalida.Columns.Add(colBorrar);

                DataGridViewSalida.AutoGenerateColumns = false;

                WindowState = FormWindowState.Maximized;

                DateTime now = DateTime.Now;
                DateTime NowIn030DaysBefore = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
                DateTime NowIn2359 = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);

                dateTimePickerFechaInicio.Value = NowIn030DaysBefore.AddDays(-30);
                dateTimePickerFechaFin.Value = NowIn2359;

                List<Areas.JuanApp.Entities.Salida> lstSalida = GetTabla();

                HacerCalculosDeTotales(lstSalida);

                VerificarDuplicados(lstSalida);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void HacerCalculosDeTotales(List<Areas.JuanApp.Entities.Salida> lstSalida)
        {
            KilosRealesTotal = 0;
            PrecioTotal = 0;
            SubtotalTotal = 0;

            foreach (Areas.JuanApp.Entities.Salida salida in lstSalida)
            {
                KilosRealesTotal += salida.KilosReales;
                SubtotalTotal += salida.Subtotal;
            }

            if (KilosRealesTotal != 0)
            {
                PrecioTotal = SubtotalTotal / KilosRealesTotal;
            }
            
            txtKilosRealesTotal.Text = KilosRealesTotal.ToString();
            txtPrecioTotal.Text = PrecioTotal.ToString();
            txtSubtotalTotal.Text = SubtotalTotal.ToString();
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Areas.JuanApp.Entities.Salida> lstSalida = GetTabla();

                VerificarDuplicados(lstSalida);

                HacerCalculosDeTotales(lstSalida);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = FolderBrowserDialog.SelectedPath;

                List<Areas.JuanApp.Entities.Salida> lstSalida = GetTabla();

                string AjaxForString = "";

                foreach (Areas.JuanApp.Entities.Salida salida in lstSalida)
                {
                    AjaxForString += $@"{salida.SalidaId},";
                }

                AjaxForString = AjaxForString.TrimEnd(',');

                _salidaService.ExportAsExcel(lstSalida,
                    new() { AjaxForString = AjaxForString },
                    "NotAll",
                    SelectedPath);

                MessageBox.Show($@"Generación de Excel realizada correctamente", "Información");
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = FolderBrowserDialog.SelectedPath;

                List<Areas.JuanApp.Entities.Salida> lstSalida = GetTabla();

                HacerCalculosDeTotales(lstSalida);

                bool HayDuplicados = VerificarDuplicados(lstSalida);

                if (HayDuplicados)
                {
                    return;
                }

                string HTML = $@"
<html>
    <head>
    </head>
    <body>
        <p>&nbsp;</p>
        <table style=""border-collapse: collapse; width: 100%;"" border=""1"">
        <tbody>
        <tr>
        <td style=""width: 25%;"">[Logo]</td>
        <td style=""width: 25%;"">
        <p>Raz&oacute;n social</p>
        <p>CUIT</p>
        <p>Direcci&oacute;n</p>
        <p>Localidad</p>
        <p>Tel&eacute;fono</p>
        </td>
        <td style=""width: 25%;"">
        <p>Pampa y Brasa SRL</p>
        <p>30-71819155-2</p>
        <p>Lima 1333</p>
        <p>Martinez</p>
        <p>1164943915</p>
        </td>
        <td style=""width: 25%;"">
        <p>Remito</p>
        <p>N&ordm; [NroDeRemito]</p>
        <p>Fecha</p>
        <p>[FechaDeRemito]</p>
        </td>
        </tr>
        </tbody>
        </table>
        <table style=""border-collapse: collapse; width: 100%; height: 142px;"" border=""1"">
        <tbody>
        <tr style=""height: 142px;"">
        <td style=""width: 25%; height: 142px;"">
        <p>Nombre</p>
        <p>Domicilio</p>
        <p>Localidad</p>
        <p>CUIT</p>
        </td>
        <td style=""width: 25%; height: 142px;"">
        <p>[NombreCliente]</p>
        <p>[DireccionCliente]</p>
        <p>[LocalidadCliente]</p>
        <p>[CUITCliente]</p>
        </td>
        <td style=""width: 25%; height: 142px;"">
        <p>Tel&eacute;fono</p>
        <p>CP</p>
        <p>Provincia</p>
        </td>
        <td style=""width: 25%; height: 142px;"">
        <p>[TelefonoCliente]</p>
        <p>[CodigoPostalCliente]</p>
        <p>[ProvinciaCliente]</p>
        </td>
        </tr>
        </tbody>
        </table>
        <table style=""border-collapse: collapse; width: 100%;"" border=""1"">
        <tbody>
        <tr>
        <td style=""width: 20%;"">Art&iacute;culo</td>
        <td style=""width: 20%;"">Descripci&oacute;n</td>
        <td style=""width: 20%;"">Cantidad (KG)</td>
        <td style=""width: 20%;"">Precio ($)</td>
        <td style=""width: 20%;"">Subtotal ($)</td>
        </tr>";

                DateTime Now = DateTime.Now;

                Areas.JuanApp.Entities.Remito Remito = new()
                {
                    Fecha = Now,
                    Active = true,
                    UserCreationId = 1,
                    UserLastModificationId = 1,
                    DateTimeCreation = Now,
                    DateTimeLastModification = Now,
                    CodigoCliente = CodigoCliente,
                    NombreCliente = NombreCliente,
                    KilosTotales = KilosRealesTotal,
                    PrecioTotal = PrecioTotal,
                    SubtotalTotal = SubtotalTotal
                };
                int LastId = _remitoRepository.Add(Remito);

                HTML = HTML.Replace("[NroDeRemito]", LastId.ToString());
                HTML = HTML.Replace("[FechaDeRemito]", Now.ToString("dd/MM/yyyy HH:mm"));

                Areas.JuanApp.Entities.Cliente Cliente = _clienteRepository
                    .AsQueryable()
                    .Where(x => x.CodigoDeCliente == CodigoCliente)
                    .FirstOrDefault();

                HTML = HTML.Replace("[NombreCliente]", Cliente.NombreDeCliente);
                HTML = HTML.Replace("[DireccionCliente]", Cliente.Domicilio);
                HTML = HTML.Replace("[LocalidadCliente]", Cliente.Localidad);
                HTML = HTML.Replace("[CUITCliente]", Cliente.CUIT);
                HTML = HTML.Replace("[TelefonoCliente]", Cliente.Telefono);
                HTML = HTML.Replace("[CodigoPostalCliente]", Cliente.CodigoPostal);
                HTML = HTML.Replace("[ProvinciaCliente]", Cliente.Provincia);
                HTML = HTML.Replace("[Logo]", $@"<img src=""Logo.png"" alt=""Logo"" width=""150"">");

                foreach (Areas.JuanApp.Entities.Salida salida in lstSalida)
                {
                    HTML += $@"<tr>
        <td style=""width: 20%;"">{salida.CodigoDeProducto}</td>
        <td style=""width: 20%;"">{salida.NombreDeProducto}</td>
        <td style=""width: 20%;"">{salida.KilosReales}</td>
        <td style=""width: 20%;"">{salida.Precio}</td>
        <td style=""width: 20%;"">{salida.Subtotal}</td>
        </tr>";
                }

                HTML += $@"
        
        </tbody>
        </table>
        <table style=""border-collapse: collapse; width: 100%;"" border=""1"">
        <tbody>
        <tr>
        <td style=""width: 33.3333%;"">&nbsp;</td>
        <td style=""width: 33.3333%;"">&nbsp;</td>
        <td style=""width: 33.3333%;"">
        <p>Cantidad total (KGs): {KilosRealesTotal}</p>
        <p>Subtotal ($): {SubtotalTotal}</p>
        </td>
        </tr>
        </tbody>
        </table>
        <table style=""border-collapse: collapse; width: 100%;"" border=""1"">
        <tbody>
        <tr>
        <td style=""width: 50%;"">
        <p>Recibi conforme:</p>
        <p>&nbsp;</p>
        </td>
        <td style=""width: 50%;"">
        <p>Firma y sello:</p>
        <p>&nbsp;</p>
        </td>
        </tr>
        </tbody>
        </table>
    </body>
</html>";

                PdfSharp.Pdf.PdfDocument documento = PdfGenerator.GeneratePdf(HTML, PageSize.A4);
                documento.Save($@"{SelectedPath}\Salida_{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.pdf");

                MessageBox.Show($@"Generación de PDF realizada correctamente", "Información");
            }
        }

        private void DataGridViewSalida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 10)
                {
                    //Actualizar
                    int EntradaId = Convert.ToInt32(DataGridViewSalida.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioSalida FormularioSalida = new(_serviceProvider,
                    EntradaId);

                    FormularioSalida.ShowDialog();

                    GetTabla();
                }
                else if (e.ColumnIndex == 11)
                {
                    //Borrar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int EntradaId = Convert.ToInt32(DataGridViewSalida.Rows[e.RowIndex].Cells[0].Value.ToString());

                        _salidaRepository.DeleteBySalidaId(EntradaId);

                        GetTabla();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<Areas.JuanApp.Entities.Salida> GetTabla()
        {
            try
            {
                if (dateTimePickerFechaInicio.Value > dateTimePickerFechaFin.Value)
                {
                    MessageBox.Show("Fecha de inicio debe ser menor a fecha fin", "Atención");
                    return null;
                }

                List<Areas.JuanApp.Entities.Salida> lstSalida = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstSalida = _salidaRepository
                    .AsQueryable()
                    .Where(x => x.DateTimeLastModification >= dateTimePickerFechaInicio.Value &&
                    x.DateTimeLastModification <= dateTimePickerFechaFin.Value)
                    .OrderBy(x => x.NombreDeProducto)
                    .Take(Convert.ToInt32(numericUpDownRegistros.Value))
                    .ToList();
                }
                else
                {
                    string[] words = Regex
                        .Replace(txtBuscar.Text
                        .Trim(), @"\s+", " ")
                        .Split(" ");

                    lstSalida = _salidaRepository
                    .AsQueryable()
                    .Where(x => words.Any(word => x.CodigoDeCliente.Contains(word)) ||
                    words.Any(word => x.NombreDeCliente.ToString().Contains(word)) ||
                    words.Any(word => x.NroDePesaje.ToString().Contains(word)) ||
                    words.Any(word => x.NombreDeProducto.ToString().Contains(word)) ||
                    words.Any(word => x.CodigoDeProducto.ToString().Contains(word)))
                    .Where(x => x.DateTimeLastModification >= dateTimePickerFechaInicio.Value &&
                    x.DateTimeLastModification <= dateTimePickerFechaFin.Value)
                    .OrderBy(x => x.NombreDeProducto)
                    .Take(Convert.ToInt32(numericUpDownRegistros.Value))
                    .ToList();
                }

                DataGridViewSalida.DataSource = lstSalida;

                statusLabel.Text = $@"Información: Cantidad de entradas listadas: {lstSalida.Count}.";

                return lstSalida;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioSalida FormularioSalida = new(_serviceProvider,
                        0);

                FormularioSalida.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        bool VerificarDuplicados(List<Areas.JuanApp.Entities.Salida> registros)
        {
            // Recorremos la lista de registros
            foreach (var registro1 in registros)
            {
                // Por cada registro, comparamos con el resto de registros
                foreach (var registro2 in registros)
                {
                    // Nos aseguramos de no comparar un registro consigo mismo
                    if (registro1 != registro2)
                    {
                        // Si encontramos dos registros con NombreDeCliente diferentes, retornamos true
                        if (registro1.NombreDeCliente != registro2.NombreDeCliente)
                        {
                            //MessageBox.Show("Hay nombres de clientes diferentes en la tabla", "Atención");
                            CodigoCliente = "";
                            NombreCliente = "";
                            btnGenerarPDF.Enabled = false;
                            return true;
                        }
                    }
                }
            }

            if (registros.Count > 0)
            {
                CodigoCliente = registros[0].CodigoDeCliente;
                NombreCliente = registros[0].NombreDeCliente;
                btnGenerarPDF.Enabled = true;
            }

            // Si no encontramos duplicados, retornamos false
            return false;
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar todos los registros?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _salidaRepository.DeleteAll();

                    MessageBox.Show("Todos los registros han sido borrados exitosamente", "Información");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnHideShowTable_Click(object sender, EventArgs e)
        {
            pnlSearchBar.Visible = !pnlSearchBar.Visible;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    List<Areas.JuanApp.Entities.Salida> lstSalida = GetTabla();

                    VerificarDuplicados(lstSalida);

                    HacerCalculosDeTotales(lstSalida);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
