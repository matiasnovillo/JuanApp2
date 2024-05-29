using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;
using JuanApp.Areas.BasicCore.Entities;
using JuanApp.Areas.JuanApp.Entities;
using DocumentFormat.OpenXml.InkML;
using Microsoft.Win32;
using System.Linq;
using System.Windows.Forms;
using JuanApp.Areas.JuanApp.Repositories;

namespace JuanApp.Formularios.Entrada
{
    public partial class ConsultaEntrada : Form
    {
        private readonly IEntradaRepository _entradaRepository;
        private readonly IEntradaService _entradaService;
        private readonly ServiceProvider _serviceProvider;

        public ConsultaEntrada(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;

                _entradaRepository = serviceProvider.GetRequiredService<IEntradaRepository>();
                _entradaService = serviceProvider.GetRequiredService<IEntradaService>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "EntradaId";
                col0.HeaderText = "ID del sistema";
                DataGridViewEntrada.Columns.Add(col0);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "NroDePesaje";
                col2.HeaderText = "Nº de pesaje";
                DataGridViewEntrada.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "CodigoDeProducto";
                col3.HeaderText = "Código de producto";
                DataGridViewEntrada.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new();
                col4.DataPropertyName = "NombreDeProducto";
                col4.HeaderText = "Nombre de producto";
                col4.Width = 250;
                DataGridViewEntrada.Columns.Add(col4);

                DataGridViewTextBoxColumn col5 = new();
                col5.DataPropertyName = "TexContenido";
                col5.HeaderText = "Tex. Contenido";
                DataGridViewEntrada.Columns.Add(col5);

                DataGridViewTextBoxColumn col6 = new();
                col6.DataPropertyName = "Neto";
                col6.HeaderText = "Neto";
                DataGridViewEntrada.Columns.Add(col6);

                DataGridViewTextBoxColumn col7 = new();
                col7.DataPropertyName = "DateTimeLastModification";
                col7.HeaderText = "Fecha de creacion";
                DataGridViewEntrada.Columns.Add(col7);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewEntrada.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewEntrada.Columns.Add(colBorrar);

                WindowState = FormWindowState.Maximized;

                DataGridViewEntrada.AutoGenerateColumns = false;

                DateTime now = DateTime.Now;
                DateTime NowIn030DaysBefore = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
                DateTime NowIn2359 = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);

                dateTimePickerFechaInicio.Value = NowIn030DaysBefore.AddDays(-30);
                dateTimePickerFechaFin.Value = NowIn2359;

                numericUpDownRegistrosPorPagina.Value = 500;

                GetTabla();
            }
            catch (Exception)
            {
                throw;
            }
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

        private void DataGridViewEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    //Actualizar
                    int EntradaId = Convert.ToInt32(DataGridViewEntrada.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioEntrada FormularioEntrada = new(_serviceProvider,
                    EntradaId);

                    FormularioEntrada.ShowDialog();

                    GetTabla();
                }
                else if (e.ColumnIndex == 8)
                {
                    //Borrar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int EntradaId = Convert.ToInt32(DataGridViewEntrada.Rows[e.RowIndex].Cells[0].Value.ToString());

                        _entradaRepository.DeleteByEntradaId(EntradaId);

                        GetTabla();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GetTabla()
        {
            try
            {
                if (dateTimePickerFechaInicio.Value > dateTimePickerFechaFin.Value)
                {
                    MessageBox.Show("Fecha de inicio debe ser menor a fecha fin", "Atención");
                    return;
                }

                List<Areas.JuanApp.Entities.Entrada> lstEntrada = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstEntrada = _entradaRepository
                    .AsQueryable()
                    .Where(x => x.DateTimeLastModification >= dateTimePickerFechaInicio.Value &&
                    x.DateTimeLastModification <= dateTimePickerFechaFin.Value)
                    .OrderBy(x => x.NombreDeProducto)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
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
                    .Where(x => words.All(word => x.NombreDeProducto.Contains(word)) ||
                    words.All(word => x.NroDePesaje.ToString().Contains(word)) ||
                    words.All(word => x.CodigoDeProducto.ToString().Contains(word)))
                    .Where(x => x.DateTimeLastModification >= dateTimePickerFechaInicio.Value &&
                    x.DateTimeLastModification <= dateTimePickerFechaFin.Value)
                    .OrderBy(x => x.NombreDeProducto)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                    .ToList();
                }

                decimal NetoTotal = 0;
                foreach (Areas.JuanApp.Entities.Entrada entrada in lstEntrada)
                {
                    NetoTotal += entrada.Neto;
                }
                txtNetoTotal.Text = NetoTotal.ToString();

                DataGridViewEntrada.DataSource = lstEntrada;

                statusLabel.Text = $@"Información: Cantidad de entradas listadas: {lstEntrada.Count}";
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
                FormularioEntrada FormularioEntrada = new(_serviceProvider,
                        0);

                FormularioEntrada.ShowDialog();
            }
            catch (Exception)
            {

                throw;
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
