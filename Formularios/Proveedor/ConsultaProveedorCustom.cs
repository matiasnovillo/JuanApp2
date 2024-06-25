using JuanApp2.Areas.JuanApp2.CompraBack.Entities;
using JuanApp2.Areas.JuanApp2.CompraBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.DTOs;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Entities;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JuanApp2.Formularios.Proveedor
{
    public partial class ConsultaProveedorCustom : Form
    {
        private readonly ICompraRepository _compraRepository;
        private readonly IProveedorRepository _proveedorRepository;
        private readonly IProveedorService _proveedorService;
        private readonly IModuloProveedorRepository _moduloproveedorRepository;
        private readonly ServiceProvider _serviceProvider;

        private List<Areas.JuanApp2.ProveedorBack.Entities.Proveedor> _lstProveedor;
        private Color ColorForCompra;
        private Color ColorForPagoAProveedores;

        public ConsultaProveedorCustom(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;

                _compraRepository = serviceProvider.GetRequiredService<ICompraRepository>();
                _proveedorRepository = serviceProvider.GetRequiredService<IProveedorRepository>();
                _proveedorService = serviceProvider.GetRequiredService<IProveedorService>();
                _moduloproveedorRepository = serviceProvider.GetRequiredService<IModuloProveedorRepository>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "CompraId";
                col0.HeaderText = "ID del sistema";
                DataGridViewCompra.Columns.Add(col0);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "Fecha";
                col1.HeaderText = "Fecha";
                DataGridViewCompra.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "Proveedor";
                col2.HeaderText = "Proveedor";
                DataGridViewCompra.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "Referencia";
                col3.HeaderText = "Referencia";
                DataGridViewCompra.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new();
                col4.DataPropertyName = "Descripcion";
                col4.HeaderText = "Descripcion";
                DataGridViewCompra.Columns.Add(col4);

                DataGridViewTextBoxColumn col5 = new();
                col5.DataPropertyName = "Kilogramo";
                col5.HeaderText = "Kilogramo";
                DataGridViewCompra.Columns.Add(col5);

                DataGridViewTextBoxColumn col6 = new();
                col6.DataPropertyName = "Precio";
                col6.HeaderText = "Precio";
                DataGridViewCompra.Columns.Add(col6);

                DataGridViewTextBoxColumn col7 = new();
                col7.DataPropertyName = "Debe";
                col7.HeaderText = "Debe";
                DataGridViewCompra.Columns.Add(col7);

                DataGridViewTextBoxColumn col8 = new();
                col8.DataPropertyName = "Haber";
                col8.HeaderText = "Haber";
                DataGridViewCompra.Columns.Add(col8);

                DataGridViewTextBoxColumn col9 = new();
                col9.DataPropertyName = "Saldo";
                col9.HeaderText = "Saldo";
                DataGridViewCompra.Columns.Add(col9);

                DataGridViewTextBoxColumn col10 = new();
                col10.DataPropertyName = "Vencimiento";
                col10.HeaderText = "Vencimiento";
                DataGridViewCompra.Columns.Add(col10);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewCompra.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewCompra.Columns.Add(colBorrar);

                WindowState = FormWindowState.Maximized;

                DataGridViewCompra.AutoGenerateColumns = false;
                DataGridViewCompra.DefaultCellStyle.Font = new Font("Arial", 11);

                numericUpDownRegistrosPorPagina.Value = 500;

                DateTime now = DateTime.Now;
                DateTime NowIn030DaysBefore = new(now.Year, now.Month, now.Day, 0, 0, 0);
                DateTime NowIn2359 = new(now.Year, now.Month, now.Day, 23, 59, 59);

                DateTimePickerFechaInicio.Value = NowIn030DaysBefore.AddDays(-30);
                DateTimePickerFechaFin.Value = NowIn2359;

                _lstProveedor = _proveedorRepository.GetAll();

                cmbProveedor.Items.Clear();
                cmbProveedor.Items.Add($@"TODOS");
                foreach (Areas.JuanApp2.ProveedorBack.Entities.Proveedor proveedor in _lstProveedor)
                {
                    cmbProveedor.Items.Add($@"{proveedor.NombreCompleto}");
                }
                cmbProveedor.SelectedIndex = 0;

                //Coloring rows of DataGridView
                ColorForCompra = Color.White;
                PanelColourCompra.BackColor = ColorForCompra;

                ColorForPagoAProveedores = Color.White;
                PanelColourPagoAProveedores.BackColor = ColorForPagoAProveedores;

                GetTabla();
            }
            catch (Exception) { throw; }
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
            catch (Exception) { throw; }
        }

        private void DataGridViewEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 11)
                {
                    //Actualizar
                    int CompraId = Convert.ToInt32(DataGridViewCompra.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioCompra FormularioCompra = new(_serviceProvider,
                    CompraId);

                    FormularioCompra.ShowDialog();

                    GetTabla();
                }
                else if (e.ColumnIndex == 12)
                {
                    //Borrar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int CompraId = Convert.ToInt32(DataGridViewCompra.Rows[e.RowIndex].Cells[0].Value.ToString());

                        _compraRepository.DeleteByCompraId(CompraId);

                        GetTabla();
                    }
                }
            }
            catch (Exception) { throw; }
        }

        private List<consultaProveedorDTO> GetTabla()
        {
            try
            {
                List<Compra> lstCompra = [];
                List<ModuloProveedor> lstModuloProveedor = [];
                List<consultaProveedorDTO> lstconsultaProveedorDTO = [];

                #region lstCompra
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    if (cmbProveedor.SelectedItem.ToString() == "TODOS")
                    {
                        lstCompra = _compraRepository
                            .AsQueryable()
                            .Where(x => x.Fecha <= DateTimePickerFechaFin.Value &&
                            x.Fecha >= DateTimePickerFechaInicio.Value)
                            .OrderBy(x => x.Fecha)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                    }
                    else
                    {
                        Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(cmbProveedor.SelectedItem.ToString());

                        lstCompra = _compraRepository
                            .AsQueryable()
                            .Where(x => x.ProveedorId == Proveedor.ProveedorId)
                            .Where(x => x.Fecha <= DateTimePickerFechaFin.Value &&
                            x.Fecha >= DateTimePickerFechaInicio.Value)
                            .OrderBy(x => x.Fecha)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                    }

                }
                else
                {
                    if (cmbProveedor.SelectedItem.ToString() == "TODOS")
                    {
                        string[] words = Regex
                       .Replace(txtBuscar.Text
                       .Trim(), @"\s+", " ")
                       .Split(" ");

                        lstCompra = _compraRepository
                            .AsQueryable()
                            .Where(x => words.Any(word => x.Referencia.Contains(word)) ||
                            words.Any(word => x.Descripcion.Contains(word)))
                            .Where(x => x.Fecha <= DateTimePickerFechaFin.Value &&
                            x.Fecha >= DateTimePickerFechaInicio.Value)
                            .OrderBy(x => x.Fecha)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                    }
                    else
                    {
                        Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(cmbProveedor.SelectedItem.ToString());

                        string[] words = Regex
                       .Replace(txtBuscar.Text
                       .Trim(), @"\s+", " ")
                       .Split(" ");

                        lstCompra = _compraRepository
                            .AsQueryable()
                            .Where(x => words.Any(word => x.Referencia.Contains(word)) ||
                            words.Any(word => x.Descripcion.Contains(word)))
                            .Where(x => x.ProveedorId == Proveedor.ProveedorId)
                            .Where(x => x.Fecha <= DateTimePickerFechaFin.Value &&
                            x.Fecha >= DateTimePickerFechaInicio.Value)
                            .OrderBy(x => x.Fecha)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                    }
                }
                #endregion

                #region lstModuloProveedor
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    if (cmbProveedor.SelectedItem.ToString() == "TODOS")
                    {
                        lstModuloProveedor = _moduloproveedorRepository
                            .AsQueryable()
                            .Where(x => x.Fecha <= DateTimePickerFechaFin.Value &&
                            x.Fecha >= DateTimePickerFechaInicio.Value)
                            .OrderBy(x => x.Fecha)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                    }
                    else
                    {
                        Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(cmbProveedor.SelectedItem.ToString());

                        lstModuloProveedor = _moduloproveedorRepository
                            .AsQueryable()
                            .Where(x => x.ProveedorId == Proveedor.ProveedorId)
                            .Where(x => x.Fecha <= DateTimePickerFechaFin.Value &&
                            x.Fecha >= DateTimePickerFechaInicio.Value)
                            .OrderBy(x => x.Fecha)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                    }
                }
                else
                {
                    if (cmbProveedor.SelectedItem.ToString() == "TODOS")
                    {
                        string[] words = Regex
                       .Replace(txtBuscar.Text
                       .Trim(), @"\s+", " ")
                       .Split(" ");

                        lstModuloProveedor = _moduloproveedorRepository
                            .AsQueryable()
                            .Where(x => words.Any(word => x.Descripcion.Contains(word)))
                            .Where(x => x.Fecha <= DateTimePickerFechaFin.Value &&
                            x.Fecha >= DateTimePickerFechaInicio.Value)
                            .OrderBy(x => x.Fecha)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                    }
                    else
                    {
                        Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(cmbProveedor.SelectedItem.ToString());

                        string[] words = Regex
                       .Replace(txtBuscar.Text
                       .Trim(), @"\s+", " ")
                       .Split(" ");

                        lstModuloProveedor = _moduloproveedorRepository
                            .AsQueryable()
                            .Where(x => words.Any(word => x.Descripcion.Contains(word)))
                            .Where(x => x.ProveedorId == Proveedor.ProveedorId)
                            .Where(x => x.Fecha <= DateTimePickerFechaFin.Value &&
                            x.Fecha >= DateTimePickerFechaInicio.Value)
                            .OrderBy(x => x.Fecha)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                    }
                }
                #endregion

                DataGridViewCompra.Rows.Clear();

                #region lstCompra
                decimal SaldoTotalCompra = 0;

                DateTime FechaMinimaCompra = DateTime.MaxValue;

                decimal TotalAVencerCompra = 0;

                foreach (Compra compra in lstCompra)
                {
                    DateTime FechaMasDiaDepagoDe0 = new(compra.Fecha.Year, compra.Fecha.Month, compra.Fecha.Day, 0, 0, 0);
                    FechaMasDiaDepagoDe0 = FechaMasDiaDepagoDe0.AddDays(compra.DiaDePago);
                    DateTime HoyDe0 = new(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    if (compra.Fecha.AddDays(compra.DiaDePago) < FechaMinimaCompra)
                    {
                        if (FechaMasDiaDepagoDe0 >= HoyDe0)
                        {
                            FechaMinimaCompra = FechaMasDiaDepagoDe0;
                            TotalAVencerCompra = compra.Subtotal;
                        }
                    }

                    if (compra.DebeOHaber == true)
                    {
                        SaldoTotalCompra += compra.Subtotal;
                    }
                    else
                    {
                        SaldoTotalCompra -= compra.Subtotal;
                    }

                    consultaProveedorDTO consultaProveedorDTO = new()
                    {
                        Id = compra.CompraId,
                        Fecha = compra.Fecha,
                        ProveedorId = compra.ProveedorId,
                        Referencia = compra.Referencia,
                        Descripcion = compra.Descripcion,
                        Kilogramo = compra.Kilogramo,
                        Precio = compra.Precio,
                        Debe = compra.DebeOHaber == true ? compra.Subtotal : 0,
                        Haber = compra.DebeOHaber == true ? 0 : compra.Subtotal,
                        Saldo = SaldoTotalCompra,
                        Vencimiento = FechaMasDiaDepagoDe0,
                        DateTimeLastModification = compra.DateTimeLastModification
                    };
                    lstconsultaProveedorDTO.Add(consultaProveedorDTO);
                }
                #endregion

                #region lstModuloProveedor
                decimal SaldoTotalModuloProveedor = SaldoTotalCompra;

                DateTime FechaMinimaModuloProveedor = DateTime.MaxValue;

                foreach (ModuloProveedor moduloproveedor in lstModuloProveedor)
                {
                    if (moduloproveedor.Fecha.AddDays(0) < FechaMinimaModuloProveedor)
                    {
                        FechaMinimaModuloProveedor = moduloproveedor.Fecha.AddDays(0);
                    }

                    SaldoTotalModuloProveedor -= moduloproveedor.DineroTotal;

                    consultaProveedorDTO consultaProveedorDTO = new()
                    {
                        Id = moduloproveedor.ModuloProveedorId,
                        Fecha = moduloproveedor.Fecha,
                        ProveedorId = moduloproveedor.ProveedorId,
                        Referencia = "PAGO A PROVEEDORES",
                        Descripcion = moduloproveedor.Descripcion,
                        Kilogramo = 0,
                        Precio = 0,
                        Debe = 0,
                        Haber = moduloproveedor.DineroTotal,
                        Saldo = SaldoTotalModuloProveedor,
                        Vencimiento = moduloproveedor.Fecha.AddDays(0),
                        DateTimeLastModification = moduloproveedor.DateTimeLastModification
                    };
                    lstconsultaProveedorDTO.Add(consultaProveedorDTO);
                }
                #endregion

                lstconsultaProveedorDTO = lstconsultaProveedorDTO
                    .AsQueryable()
                    .OrderBy(x => x.DateTimeLastModification)
                    .ToList();

                foreach (consultaProveedorDTO consultaProveedorDTO in lstconsultaProveedorDTO)
                {
                    Areas.JuanApp2.ProveedorBack.Entities.Proveedor ProveedorDataGridView = _proveedorRepository.GetByProveedorId(consultaProveedorDTO.ProveedorId);

                    DataGridViewCompra.Rows.Add(consultaProveedorDTO.Id.ToString(),
                        consultaProveedorDTO.Fecha.ToString("dd/MM/yyyy"),
                        ProveedorDataGridView.NombreCompleto,
                        consultaProveedorDTO.Referencia,
                        consultaProveedorDTO.Descripcion,
                        consultaProveedorDTO.Referencia == "PAGO A PROVEEDORES" ? "" : consultaProveedorDTO.Kilogramo,
                        consultaProveedorDTO.Referencia == "PAGO A PROVEEDORES" ? "" : $@"${consultaProveedorDTO.Precio.ToString("N2")}",
                        consultaProveedorDTO.Referencia == "PAGO A PROVEEDORES" ? "" : $@"${consultaProveedorDTO.Debe.ToString("N2")}",
                        $@"${consultaProveedorDTO.Haber.ToString("N2")}",
                        $@"${consultaProveedorDTO.Saldo.ToString("N2")}",
                        consultaProveedorDTO.Referencia == "PAGO A PROVEEDORES" ? "" : consultaProveedorDTO.Vencimiento.ToString("dd/MM/yyyy"),
                        "",
                        "");
                }

                decimal SaldoTotal = SaldoTotalModuloProveedor;
                DateTime FechaMinima = FechaMinimaCompra;
                decimal TotalAVencer = TotalAVencerCompra;

                txtSaldoTotal.Text = $@"${SaldoTotal.ToString("N2")}";
                txtProximoVencimiento.Text = FechaMinima.ToString("dd/MM/yyyy");
                txtTotalAVencer.Text = $@"${TotalAVencer.ToString("N2")}";

                //Diseño
                if (SaldoTotalCompra < 0)
                {
                    txtSaldoTotal.BackColor = Color.Red;
                }
                else
                {
                    txtSaldoTotal.BackColor = Color.Green;
                }

                if (FechaMinimaCompra.Year == DateTime.Now.Year &&
                    FechaMinimaCompra.Month == DateTime.Now.Month &&
                    FechaMinimaCompra.Day == DateTime.Now.Day)
                {
                    txtProximoVencimiento.BackColor = Color.Aquamarine;
                    txtTotalAVencer.BackColor = Color.Aquamarine;
                }

                DataGridViewCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                statusLabel.Text = $@"Información: Cantidad de compras listadas: {lstCompra.Count}";

                return lstconsultaProveedorDTO;
            }
            catch (Exception) { throw; }
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
            catch (Exception) { throw; }
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioCompra FormularioCompra = new(_serviceProvider,
                        0);

                FormularioCompra.ShowDialog();
            }
            catch (Exception) { throw; }
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetTabla();
            }
            catch (Exception) { throw; }
        }

        private void btnExportarAExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = $@"{FolderBrowserDialog.SelectedPath}\\Proveedores_{DateTime.Now.ToString("dd_MM_yyyy__HH_mm")}.xlsx";

                List<consultaProveedorDTO> lstconsultaProveedorDTO = GetTabla();
                DataTable dtconsultaProveedorDTO = new();

                dtconsultaProveedorDTO.Columns.Add("ID", typeof(string));
                dtconsultaProveedorDTO.Columns.Add("Fecha", typeof(string));
                dtconsultaProveedorDTO.Columns.Add("Nombre completo", typeof(string));
                dtconsultaProveedorDTO.Columns.Add("Referencia", typeof(string));
                dtconsultaProveedorDTO.Columns.Add("Descripcion", typeof(string));
                dtconsultaProveedorDTO.Columns.Add("Kilogramo", typeof(string));
                dtconsultaProveedorDTO.Columns.Add("Precio", typeof(string));
                dtconsultaProveedorDTO.Columns.Add("Debe", typeof(string));
                dtconsultaProveedorDTO.Columns.Add("Haber", typeof(string));
                dtconsultaProveedorDTO.Columns.Add("Saldo", typeof(string));
                dtconsultaProveedorDTO.Columns.Add("Vencimiento", typeof(string));

                foreach (consultaProveedorDTO consultaProveedorDTO in lstconsultaProveedorDTO)
                {
                    Areas.JuanApp2.ProveedorBack.Entities.Proveedor ProveedorDataGridView = _proveedorRepository.GetByProveedorId(consultaProveedorDTO.ProveedorId);

                    dtconsultaProveedorDTO.Rows.Add(consultaProveedorDTO.Id.ToString(),
                        consultaProveedorDTO.Fecha.ToString("dd/MM/yyyy"),
                        ProveedorDataGridView.NombreCompleto,
                        consultaProveedorDTO.Referencia,
                        consultaProveedorDTO.Descripcion,
                        consultaProveedorDTO.Referencia == "PAGO A PROVEEDORES" ? "" : consultaProveedorDTO.Kilogramo.ToString("N2"),
                        consultaProveedorDTO.Referencia == "PAGO A PROVEEDORES" ? "" : $@"${consultaProveedorDTO.Precio.ToString("N2")}",
                        consultaProveedorDTO.Referencia == "PAGO A PROVEEDORES" ? "" : $@"${consultaProveedorDTO.Debe.ToString("N2")}",
                        $@"${consultaProveedorDTO.Haber.ToString("N2")}",
                        $@"${consultaProveedorDTO.Saldo.ToString("N2")}",
                        consultaProveedorDTO.Referencia == "PAGO A PROVEEDORES" ? "" : consultaProveedorDTO.Vencimiento.ToString("dd/MM/yyyy"));
                }


                _proveedorService.ExportToExcel(SelectedPath, dtconsultaProveedorDTO);

                MessageBox.Show($@"Generación de Excel realizada correctamente", "Información");
            }
        }

        private void PanelColourCobranza_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (ColorDialogForCompra.ShowDialog() == DialogResult.OK)
                {
                    ColorForCompra = ColorDialogForCompra.Color;

                    PanelColourCompra.BackColor = ColorForCompra;

                    GetTabla();
                }
            }
            catch (Exception) { throw; }
        }

        private void PanelColourPagoAProveedores_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (ColorDialogForPagoAProveedores.ShowDialog() == DialogResult.OK)
                {
                    ColorForPagoAProveedores = ColorDialogForPagoAProveedores.Color;

                    PanelColourPagoAProveedores.BackColor = ColorForPagoAProveedores;

                    GetTabla();
                }
            }
            catch (Exception) { throw; }
        }

        private void DataGridViewCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string Referencia = DataGridViewCompra.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (Referencia == "COMPRA")
                {
                    if (DataGridViewCompra.Rows[e.RowIndex].DefaultCellStyle.BackColor == ColorForCompra)
                    {
                        DataGridViewCompra.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                    else
                    {
                        DataGridViewCompra.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorForCompra;
                    }
                }
                else
                {
                    if (DataGridViewCompra.Rows[e.RowIndex].DefaultCellStyle.BackColor == ColorForPagoAProveedores)
                    {
                        DataGridViewCompra.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                    else
                    {
                        DataGridViewCompra.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorForPagoAProveedores;
                    }
                }
            } 
        }
    }
}
