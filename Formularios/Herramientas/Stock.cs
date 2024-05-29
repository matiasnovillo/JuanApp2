using DocumentFormat.OpenXml.ExtendedProperties;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JuanApp.Formularios.Herramientas
{
    public partial class Stock : Form
    {
        private readonly ISalidaRepository _salidaRepository;
        private readonly IEntradaRepository _entradaRepository;
        private readonly IEntradaService _entradaService;
        private readonly ServiceProvider _serviceProvider;

        public Stock(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _salidaRepository = serviceProvider.GetRequiredService<ISalidaRepository>();
            _entradaRepository = serviceProvider.GetRequiredService<IEntradaRepository>();
            _entradaService = serviceProvider.GetRequiredService<IEntradaService>();

            InitializeComponent();

            DataGridViewTextBoxColumn col0 = new();
            col0.DataPropertyName = "EntradaId";
            col0.HeaderText = "ID del sistema";
            DataGridViewStock.Columns.Add(col0);

            DataGridViewTextBoxColumn col2 = new();
            col2.DataPropertyName = "NroDePesaje";
            col2.HeaderText = "Nº de pesaje";
            DataGridViewStock.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new();
            col3.DataPropertyName = "CodigoDeProducto";
            col3.HeaderText = "Código de producto";
            DataGridViewStock.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new();
            col4.DataPropertyName = "NombreDeProducto";
            col4.HeaderText = "Nombre de producto";
            col4.Width = 250;
            DataGridViewStock.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new();
            col5.DataPropertyName = "TexContenido";
            col5.HeaderText = "Tex. Contenido";
            DataGridViewStock.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new();
            col6.DataPropertyName = "Neto";
            col6.HeaderText = "Neto";
            DataGridViewStock.Columns.Add(col6);

            DataGridViewTextBoxColumn col7 = new();
            col7.DataPropertyName = "DateTimeLastModification";
            col7.HeaderText = "Fecha de última modificación";
            DataGridViewStock.Columns.Add(col7);

            WindowState = FormWindowState.Maximized;

            GetTabla();
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                GetTabla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<Areas.JuanApp.Entities.Entrada> GetTabla()
        {
            try
            {
                List<Areas.JuanApp.Entities.Entrada> lstEntrada = [];

                List<Areas.JuanApp.Entities.Salida> lstSalida = _salidaRepository.GetAll();

                var nrosDePesajeSalida = lstSalida.Select(salida => salida.NroDePesaje).ToList();

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstEntrada = _entradaRepository
                    .AsQueryable()
                    .Where(entrada => !nrosDePesajeSalida.Contains(entrada.NroDePesaje))
                    .OrderBy(x => x.NombreDeProducto)
                    .ToList();
                }
                else
                {
                    string[] words = Regex
                        .Replace(txtBuscar.Text
                        .Trim(), @"\s+", " ")
                        .Split(" ");

                    lstEntrada = _entradaRepository
                    .AsQueryable()
                    .Where(entrada => !nrosDePesajeSalida.Contains(entrada.NroDePesaje))
                    .Where(x => words.Any(word => x.CodigoDeProducto.Contains(word)) ||
                    words.All(word => x.NombreDeProducto.ToString().Contains(word)) ||
                    words.All(word => x.NroDePesaje.ToString().Contains(word)))
                    .OrderBy(x => x.NombreDeProducto)
                    .ToList();
                }

                DataGridViewStock.DataSource = lstEntrada;

                decimal Neto = 0;
                foreach (var entrada in lstEntrada)
                {
                    Neto += entrada.Neto;
                }
                txtNetoTotal.Text = Neto.ToString();

                txtNroTotalDeProductos.Text = lstEntrada.Count.ToString();

                statusLabel.Text = $@"Información: Cantidad de entradas listadas: {lstEntrada.Count}.";

                return lstEntrada;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnShowHideTabla_Click(object sender, EventArgs e)
        {
            pnlSearchBar.Visible = !pnlSearchBar.Visible;
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = FolderBrowserDialog.SelectedPath;

                List<Areas.JuanApp.Entities.Entrada> lstEntrada = GetTabla();

                string AjaxForString = "";

                foreach (Areas.JuanApp.Entities.Entrada entrada in lstEntrada)
                {
                    AjaxForString += $@"{entrada.EntradaId},";
                }

                AjaxForString = AjaxForString.TrimEnd(',');

                _entradaService.ExportAsExcel(lstEntrada,
                    new() { AjaxForString = AjaxForString },
                    "NotAll",
                    SelectedPath);

                MessageBox.Show($@"Generación de Excel realizada correctamente", "Información");
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    GetTabla();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
