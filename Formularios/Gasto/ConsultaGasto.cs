using DocumentFormat.OpenXml.Bibliography;
using JuanApp2.Areas.JuanApp2.DTOs;
using JuanApp2.Areas.JuanApp2.GastoBack.Entities;
using JuanApp2.Areas.JuanApp2.GastoBack.Interfaces;
using JuanApp2.Areas.JuanApp2.GastoBack.Services;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.DTOs;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Text.RegularExpressions;

namespace JuanApp2.Formularios.Gasto
{
    public partial class ConsultaGasto : Form
    {
        private readonly IGastoRepository _gastoRepository;
        private readonly IGastoService _gastoService;
        private readonly IModuloGastoRepository _modulogastoRepository;
        private readonly ServiceProvider _serviceProvider;

        public ConsultaGasto(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;

                _gastoRepository = serviceProvider.GetRequiredService<IGastoRepository>();
                _gastoService = serviceProvider.GetRequiredService<IGastoService>();
                _modulogastoRepository = serviceProvider.GetRequiredService<IModuloGastoRepository>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "GastoId";
                col0.HeaderText = "ID del sistema";
                DataGridViewGasto.Columns.Add(col0);

                DataGridViewTextBoxColumn col4 = new();
                col4.DataPropertyName = "Referencia";
                col4.HeaderText = "Referencia";
                DataGridViewGasto.Columns.Add(col4);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "Fecha";
                col1.HeaderText = "Fecha";
                DataGridViewGasto.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "Descripcion";
                col2.HeaderText = "Descripcion";
                DataGridViewGasto.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "Importe";
                col3.HeaderText = "Importe";
                DataGridViewGasto.Columns.Add(col3);

                DataGridViewTextBoxColumn col5 = new();
                col5.DataPropertyName = "Saldo";
                col5.HeaderText = "Saldo negativo";
                DataGridViewGasto.Columns.Add(col5);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewGasto.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewGasto.Columns.Add(colBorrar);

                WindowState = FormWindowState.Maximized;

                DataGridViewGasto.AutoGenerateColumns = false;

                numericUpDownRegistrosPorPagina.Value = 2000;

                //DateTimePickers
                DateTime Today = DateTime.Today;
                Today = new(Today.Year, Today.Month, Today.Day, 0, 0, 0);

                DateTime TodayToFin = new(Today.Year, Today.Month, Today.Day, 23, 59, 59);

                // Calcular el lunes y domingo de la semana actual
                DateTime Monday = Today.AddDays(-(int)Today.DayOfWeek + (int)DayOfWeek.Monday);
                DateTime Sunday = Monday.AddDays(6);

                DateTimePickerFechaInicio.Value = Today.AddMonths(-2);
                DateTimePickerFechaFin.Value = Sunday;

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
                string Referencia = DataGridViewGasto.Rows[e.RowIndex].Cells[1].Value.ToString();
                int GastoId = Convert.ToInt32(DataGridViewGasto.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (e.ColumnIndex == 5)
                {
                    //Actualizar
                    if (Referencia == "")
                    {
                        FormularioGasto FormularioGasto = new(_serviceProvider, GastoId);

                        FormularioGasto.ShowDialog();
                    }
                    else
                    {
                        FichaDeMovimientoDeCaja.FormularioModuloGasto FormularioModuloGasto = new(_serviceProvider, GastoId);

                        FormularioModuloGasto.ShowDialog();
                    }

                    GetTabla();
                }
                else if (e.ColumnIndex == 6)
                {
                    //Borrar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (Referencia == "")
                        {
                            _gastoRepository.DeleteByGastoId(GastoId);
                        }
                        else
                        {
                            _modulogastoRepository.DeleteByModuloGastoId(GastoId);
                        }

                        GetTabla();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<gastoDTO> GetTabla()
        {
            try
            {
                List<gastoDTO> lstgastoDTO = [];

                #region Gasto (modulo)
                List<Areas.JuanApp2.GastoBack.Entities.Gasto> lstGasto = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstGasto = _gastoRepository
                    .AsQueryable()
                    .Where(x => x.Fecha >= DateTimePickerFechaInicio.Value &&
                    x.Fecha <= DateTimePickerFechaFin.Value)
                    .OrderBy(x => x.Fecha)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                    .ToList();
                }
                else
                {
                    string[] words = Regex
                        .Replace(txtBuscar.Text
                        .Trim(), @"\s+", " ")
                        .Split(" ");

                    lstGasto = _gastoRepository
                    .AsQueryable()
                    .Where(x => x.Fecha >= DateTimePickerFechaInicio.Value &&
                    x.Fecha <= DateTimePickerFechaFin.Value)
                    .Where(x => words.All(word => x.Descripcion.Contains(word)))
                    .OrderBy(x => x.Fecha)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                    .ToList();
                }

                foreach (Areas.JuanApp2.GastoBack.Entities.Gasto gasto in lstGasto)
                {
                    gastoDTO gastoDTO = new gastoDTO()
                    {
                        ID = gasto.GastoId,
                        Descripcion = gasto.Descripcion,
                        Fecha = gasto.Fecha,
                        Importe = gasto.Importe,
                        Referencia = ""
                    };

                    lstgastoDTO.Add(gastoDTO);
                }
                #endregion

                #region Gastos (ModuloGasto)
                List<ModuloGasto> lstModuloGasto = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstModuloGasto = _modulogastoRepository
                        .AsQueryable()
                        .Where(x => x.Fecha <= DateTimePickerFechaFin.Value &&
                        x.Fecha >= DateTimePickerFechaInicio.Value)
                        .OrderBy(x => x.DateTimeLastModification)
                        .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                        .ToList();
                }
                else
                {
                    string[] words = Regex
                       .Replace(txtBuscar.Text
                       .Trim(), @"\s+", " ")
                       .Split(" ");

                    lstModuloGasto = _modulogastoRepository
                        .AsQueryable()
                        .Where(x => words.Any(word => x.Descripcion.Contains(word)))
                        .Where(x => x.Fecha <= DateTimePickerFechaFin.Value &&
                        x.Fecha >= DateTimePickerFechaInicio.Value)
                        .OrderBy(x => x.DateTimeLastModification)
                        .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                        .ToList();
                }

                foreach (ModuloGasto modulogasto in lstModuloGasto)
                {
                    gastoDTO gastoDTO = new gastoDTO()
                    {
                        ID = modulogasto.ModuloGastoId,
                        Descripcion = modulogasto.Descripcion,
                        Fecha = modulogasto.Fecha,
                        Importe = modulogasto.DineroTotal,
                        Referencia = "Ficha de caja"
                    };

                    lstgastoDTO.Add(gastoDTO);
                }
                #endregion

                lstgastoDTO = lstgastoDTO
                    .AsQueryable()
                    .OrderBy(x => x.Fecha)
                    .ToList();

                DataGridViewGasto.Rows.Clear();

                decimal Saldo = 0;

                foreach (gastoDTO gasto in lstgastoDTO)
                {
                    Saldo += gasto.Importe;

                    DataGridViewGasto.Rows.Add(gasto.ID.ToString(),
                            gasto.Referencia,
                            gasto.Fecha.ToString("dd/MM/yyyy HH:mm"),
                            gasto.Descripcion,
                            $@"${gasto.Importe.ToString("N2")}",
                            $@"${Saldo.ToString("N2")}",
                            "",
                            "");
                }

                statusLabel.Text = $@"Información: Cantidad de gastos listados: {lstGasto.Count}";

                txtSaldoTotal.Text = $@"${Saldo.ToString("N2")}";

                //Diseño
                if (Saldo <= 0)
                {
                    txtSaldoTotal.BackColor = Color.Green;
                }
                else
                {
                    txtSaldoTotal.BackColor = Color.Red;
                }

                return lstgastoDTO;
            }
            catch (Exception) { throw; }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioGasto FormularioProveedor = new(_serviceProvider,
                        0);

                FormularioProveedor.ShowDialog();
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

        private void btnExportarAExcel_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
                if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string SelectedPath = $@"{FolderBrowserDialog.SelectedPath}\\Gastos_{DateTime.Now.ToString("dd_MM_yyyy__HH_mm")}.xlsx";

                    List<gastoDTO> lstgastoDTO = GetTabla();
                    DataTable dtgastoDTO = new();

                    dtgastoDTO.Columns.Add("ID", typeof(string));
                    dtgastoDTO.Columns.Add("Referencia", typeof(string));
                    dtgastoDTO.Columns.Add("Fecha", typeof(string));
                    dtgastoDTO.Columns.Add("Descripcion", typeof(string));
                    dtgastoDTO.Columns.Add("Importe", typeof(string));
                    dtgastoDTO.Columns.Add("SaldoNegativo", typeof(string));

                    decimal Saldo = 0;

                    foreach (gastoDTO gastoDTO in lstgastoDTO)
                    {
                        Saldo += gastoDTO.Importe;

                        dtgastoDTO.Rows.Add(
                            gastoDTO.ID.ToString(),
                            gastoDTO.Referencia,
                            gastoDTO.Fecha.ToString("dd/MM/yyyy"),
                            gastoDTO.Descripcion,
                            $@"${gastoDTO.Importe.ToString("N2")}",
                            $@"${Saldo.ToString("N2")}"
                            );
                    }


                    _gastoService.ExportToExcel(SelectedPath, dtgastoDTO);

                    MessageBox.Show($@"Generación de Excel realizada correctamente", "Información");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
