﻿using JuanApp2.Areas.JuanApp2.CompraBack.Entities;
using JuanApp2.Areas.JuanApp2.CompraBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Entities;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JuanApp.Formularios.Entrada
{
    public partial class ConsultaProveedorCustom : Form
    {
        private readonly ICompraRepository _compraRepository;
        private readonly IProveedorRepository _proveedorRepository;
        private readonly ServiceProvider _serviceProvider;
        private List<Proveedor> _lstProveedor;

        public ConsultaProveedorCustom(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;

                _compraRepository = serviceProvider.GetRequiredService<ICompraRepository>();
                _proveedorRepository = serviceProvider.GetRequiredService<IProveedorRepository>();

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
                foreach (Proveedor proveedor in _lstProveedor)
                {
                    cmbProveedor.Items.Add($@"{proveedor.NombreCompleto}");
                }
                cmbProveedor.SelectedIndex = 0;

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

        private void GetTabla()
        {
            try
            {
                List<Compra> lstCompra = [];



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
                        Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(cmbProveedor.SelectedItem.ToString());

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
                        Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(cmbProveedor.SelectedItem.ToString());

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

                DataGridViewCompra.Rows.Clear();

                decimal SaldoTotal = 0;

                DateTime FechaMinima = DateTime.MaxValue;

                decimal TotalAVencer = 0;

                foreach (Compra compra in lstCompra)
                {
                    Proveedor ProveedorDataGridView = _proveedorRepository.GetByProveedorId(compra.ProveedorId);

                    if (compra.Fecha.AddDays(compra.DiaDePago) < FechaMinima)
                    {
                        FechaMinima = compra.Fecha.AddDays(compra.DiaDePago);
                        TotalAVencer = compra.Subtotal;
                    }

                    if (compra.DebeOHaber == true)
                    {
                        SaldoTotal += compra.Subtotal;
                    }
                    else
                    {
                        SaldoTotal -= compra.Subtotal;
                    }


                    DataGridViewCompra.Rows.Add(compra.CompraId.ToString(),
                        compra.Fecha.ToString("dd/MM/yyyy"),
                        ProveedorDataGridView.NombreCompleto,
                        compra.Referencia,
                        compra.Descripcion,
                        compra.Kilogramo,
                        $@"${compra.Precio.ToString("N2")}",
                        compra.DebeOHaber == true ? $@"${compra.Subtotal.ToString("N2")}" : "",
                        compra.DebeOHaber == true ? "" : $@"${compra.Subtotal.ToString("N2")}",
                        $@"${SaldoTotal.ToString("N2")}",
                        compra.Fecha.AddDays(compra.DiaDePago).ToString("dd/MM/yyyy"),
                        "",
                        "");
                }

                txtSaldoTotal.Text = SaldoTotal.ToString();
                txtProximoVencimiento.Text = FechaMinima.ToString("dd/MM/yyyy");
                txtTotalAVencer.Text = TotalAVencer.ToString();

                //Diseño
                if (SaldoTotal < 0)
                {
                    txtSaldoTotal.BackColor = Color.Red;
                }
                else
                {
                    txtSaldoTotal.BackColor = Color.Green;
                }

                if (FechaMinima.Year == DateTime.Now.Year &&
                    FechaMinima.Month == DateTime.Now.Month &&
                    FechaMinima.Day == DateTime.Now.Day)
                {
                    txtProximoVencimiento.BackColor = Color.Aquamarine;
                    txtTotalAVencer.BackColor = Color.Aquamarine;
                }

                DataGridViewCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                statusLabel.Text = $@"Información: Cantidad de compras listadas: {lstCompra.Count}";
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
    }
}
