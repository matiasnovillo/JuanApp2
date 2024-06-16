using JuanApp2.Areas.JuanApp2.CobradorBack.Entities;
using JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Entities;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Interfaces;
using JuanApp2.Areas.JuanApp2.CompraBack.Entities;
using JuanApp2.Areas.JuanApp2.DTOs;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Entrada
{
    public partial class ConsultaFichaDeMovimientoDeCaja : Form
    {
        private readonly ICobranzaRepository _cobranzaRepository;
        private readonly IModuloProveedorRepository _moduloproveedorRepository;
        private readonly IModuloVarioRepository _modulovarioRepository;
        private readonly IModuloGastoRepository _modulogastoRepository;
        private readonly ICobradorRepository _cobradorRepository;
        private readonly IProveedorRepository _proveedorRepository;
        private readonly ServiceProvider _serviceProvider;

        public ConsultaFichaDeMovimientoDeCaja(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;

                _cobranzaRepository = serviceProvider.GetRequiredService<ICobranzaRepository>();
                _moduloproveedorRepository = serviceProvider.GetRequiredService<IModuloProveedorRepository>();
                _modulovarioRepository = serviceProvider.GetRequiredService<IModuloVarioRepository>();
                _modulogastoRepository = serviceProvider.GetRequiredService<IModuloGastoRepository>();
                _cobradorRepository = serviceProvider.GetRequiredService<ICobradorRepository>();
                _proveedorRepository = serviceProvider.GetRequiredService<IProveedorRepository>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "Id";
                col0.HeaderText = "ID del sistema";
                DataGridViewFicha.Columns.Add(col0);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "DateTimeLastModification";
                col1.HeaderText = "Fecha";
                DataGridViewFicha.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "Referencia";
                col2.HeaderText = "Referencia";
                DataGridViewFicha.Columns.Add(col2);

                DataGridViewTextBoxColumn col7 = new();
                col7.DataPropertyName = "Proveedor";
                col7.HeaderText = "Proveedor";
                DataGridViewFicha.Columns.Add(col7);

                DataGridViewTextBoxColumn col8 = new();
                col8.DataPropertyName = "Descripcion";
                col8.HeaderText = "Descripcion";
                DataGridViewFicha.Columns.Add(col8);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "Debe";
                col3.HeaderText = "Debe";
                DataGridViewFicha.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new();
                col4.DataPropertyName = "Haber";
                col4.HeaderText = "Haber";
                DataGridViewFicha.Columns.Add(col4);

                DataGridViewTextBoxColumn col5 = new();
                col5.DataPropertyName = "Saldo";
                col5.HeaderText = "Saldo";
                DataGridViewFicha.Columns.Add(col5);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewFicha.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewFicha.Columns.Add(colBorrar);

                WindowState = FormWindowState.Maximized;

                DataGridViewFicha.AutoGenerateColumns = false;

                DateTime now = DateTime.Now;
                DateTime NowIn030DaysBefore = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
                DateTime NowIn2359 = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);

                DateTimePickerFechaInicio.Value = NowIn030DaysBefore.AddDays(-30);
                DateTimePickerFechaFin.Value = NowIn2359;

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
                if (e.ColumnIndex == 8)
                {
                    //Actualizar
                    int CobranzaId = Convert.ToInt32(DataGridViewFicha.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioCobranza FormularioCobranza = new(_serviceProvider,
                    CobranzaId);

                    FormularioCobranza.ShowDialog();

                    GetTabla();
                }
                else if (e.ColumnIndex == 9)
                {
                    //Borrar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int CobranzaId = Convert.ToInt32(DataGridViewFicha.Rows[e.RowIndex].Cells[0].Value.ToString());

                        _cobranzaRepository.DeleteByCobranzaId(CobranzaId);

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
                //COBRANZA - PROVEEDOR - VARIOS - GASTOS
                List<fichaDeMovimientoDeCajaDTO> lstFichaDeMovimientoDeCajaDTO = [];

                decimal SaldoTotal = 0;
                decimal SaldoEfectivo = 0;
                decimal SaldoBanco = 0;
                decimal SaldoCheque = 0;

                #region Cobranza
                List<Cobranza> lstCobranza = [];
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstCobranza = _cobranzaRepository
                    .AsQueryable()
                    .Where(x => x.DateTimeLastModification <= DateTimePickerFechaFin.Value &&
                    x.DateTimeLastModification >= DateTimePickerFechaInicio.Value)
                    .OrderBy(x => x.DateTimeLastModification)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                    .ToList();
                }
                else
                {
                    Cobrador Cobrador = _cobradorRepository.GetByNombreCompleto(txtBuscar.Text);

                    if (Cobrador != null)
                    {
                        lstCobranza = _cobranzaRepository
                    .AsQueryable()
                    .Where(x => x.CobradorId == Cobrador.CobradorId)
                    .Where(x => x.DateTimeLastModification <= DateTimePickerFechaFin.Value &&
                    x.DateTimeLastModification >= DateTimePickerFechaInicio.Value)
                    .OrderBy(x => x.DateTimeLastModification)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                    .ToList();
                    }
                }

                foreach (Cobranza cobranza in lstCobranza)
                {
                    Cobrador CobradorCustom = _cobradorRepository.GetByCobradorId(cobranza.CobradorId);

                    fichaDeMovimientoDeCajaDTO fichaDeMovimientoDeCajaDTO = new()
                    {
                        ID = cobranza.CobranzaId,
                        Fecha = cobranza.DateTimeLastModification,
                        Referencia = "COBRANZA",
                        Proveedor = "",
                        Descripcion = CobradorCustom.NombreCompleto,
                        Debe = cobranza.DineroTotal,
                        Haber = 0
                    };

                    lstFichaDeMovimientoDeCajaDTO.Add(fichaDeMovimientoDeCajaDTO);

                    SaldoTotal += cobranza.DineroTotal;
                    SaldoEfectivo += cobranza.DineroEfectivo;
                    SaldoBanco += cobranza.DineroBanco;
                    SaldoCheque += cobranza.DineroCheque;
                }
                #endregion

                #region Proveedor (ModuloProveedor)
                List<ModuloProveedor> lstModuloProveedor = [];
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstModuloProveedor = _moduloproveedorRepository
                    .AsQueryable()
                    .Where(x => x.DateTimeLastModification <= DateTimePickerFechaFin.Value &&
                    x.DateTimeLastModification >= DateTimePickerFechaInicio.Value)
                    .OrderBy(x => x.DateTimeLastModification)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                    .ToList();
                }
                else
                {
                    JuanApp2.Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(txtBuscar.Text);

                    if (Proveedor != null)
                    {
                        lstModuloProveedor = lstModuloProveedor
                            .AsQueryable()
                            .Where(x => x.ProveedorId == Proveedor.ProveedorId)
                            .Where(x => x.DateTimeLastModification <= DateTimePickerFechaFin.Value &&
                            x.DateTimeLastModification >= DateTimePickerFechaInicio.Value)
                            .OrderBy(x => x.DateTimeLastModification)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                    }
                }

                foreach (ModuloProveedor moduloproveedor in lstModuloProveedor)
                {
                    JuanApp2.Areas.JuanApp2.ProveedorBack.Entities.Proveedor ProveedorCustom = _proveedorRepository.GetByProveedorId(moduloproveedor.ProveedorId);

                    fichaDeMovimientoDeCajaDTO fichaDeMovimientoDeCajaDTO = new()
                    {
                        ID = moduloproveedor.ProveedorId,
                        Fecha = moduloproveedor.DateTimeLastModification,
                        Referencia = "PAGO PROVEEDORES",
                        Proveedor = ProveedorCustom.NombreCompleto,
                        Descripcion = "",
                        Debe = 0,
                        Haber = moduloproveedor.DineroTotal
                    };

                    lstFichaDeMovimientoDeCajaDTO.Add(fichaDeMovimientoDeCajaDTO);

                    SaldoTotal -= moduloproveedor.DineroTotal;
                    SaldoEfectivo -= moduloproveedor.DineroEfectivo;
                    SaldoBanco -= moduloproveedor.DineroBanco;
                    SaldoCheque -= moduloproveedor.DineroCheque;
                }
                #endregion

                #region Varios (ModuloVario)
                List<ModuloVario> lstModuloVario = [];
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstModuloVario = _modulovarioRepository
                        .AsQueryable()
                        .Where(x => x.DateTimeLastModification <= DateTimePickerFechaFin.Value &&
                        x.DateTimeLastModification >= DateTimePickerFechaInicio.Value)
                        .OrderBy(x => x.DateTimeLastModification)
                        .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                        .ToList();
                }
                else
                {
                    lstModuloVario = _modulovarioRepository
                        .AsQueryable()
                        .Where(x => x.Descripcion.Contains(txtBuscar.Text))
                        .Where(x => x.DateTimeLastModification <= DateTimePickerFechaFin.Value &&
                        x.DateTimeLastModification >= DateTimePickerFechaInicio.Value)
                        .OrderBy(x => x.DateTimeLastModification)
                        .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                        .ToList();
                }

                foreach (ModuloVario modulovario in lstModuloVario)
                {
                    fichaDeMovimientoDeCajaDTO fichaDeMovimientoDeCajaDTO = new()
                    {
                        ID = modulovario.ModuloVarioId,
                        Fecha = modulovario.Fecha,
                        Referencia = "VARIOS",
                        Proveedor = "",
                        Descripcion = modulovario.Descripcion,
                        Debe = modulovario.DebeOHaber == true ? modulovario.DineroTotal : 0,
                        Haber = modulovario.DebeOHaber == true ? 0 : modulovario.DineroTotal
                    };

                    lstFichaDeMovimientoDeCajaDTO.Add(fichaDeMovimientoDeCajaDTO);

                    if (modulovario.DebeOHaber == true)
                    {
                        SaldoTotal += modulovario.DineroTotal;
                        SaldoEfectivo += modulovario.DineroEfectivo;
                        SaldoBanco += modulovario.DineroBanco;
                        SaldoCheque += modulovario.DineroCheque;
                    }
                    else
                    {
                        SaldoTotal -= modulovario.DineroTotal;
                        SaldoEfectivo -= modulovario.DineroEfectivo;
                        SaldoBanco -= modulovario.DineroBanco;
                        SaldoCheque -= modulovario.DineroCheque;
                    }
                    
                }
                #endregion

                #region Varios (ModuloVario)
                List<ModuloGasto> lstModuloGasto = [];
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstModuloGasto = _modulogastoRepository
                        .AsQueryable()
                        .Where(x => x.DateTimeLastModification <= DateTimePickerFechaFin.Value &&
                        x.DateTimeLastModification >= DateTimePickerFechaInicio.Value)
                        .OrderBy(x => x.DateTimeLastModification)
                        .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                        .ToList();
                }
                else
                {
                    lstModuloGasto = _modulogastoRepository
                        .AsQueryable()
                        .Where(x => x.Descripcion.Contains(txtBuscar.Text))
                        .Where(x => x.DateTimeLastModification <= DateTimePickerFechaFin.Value &&
                        x.DateTimeLastModification >= DateTimePickerFechaInicio.Value)
                        .OrderBy(x => x.DateTimeLastModification)
                        .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                        .ToList();
                }

                foreach (ModuloGasto modulogasto in lstModuloGasto)
                {
                    fichaDeMovimientoDeCajaDTO fichaDeMovimientoDeCajaDTO = new()
                    {
                        ID = modulogasto.ModuloGastoId,
                        Fecha = modulogasto.Fecha,
                        Referencia = "GASTOS",
                        Proveedor = "",
                        Descripcion = modulogasto.Descripcion,
                        Debe = 0,
                        Haber = modulogasto.DineroTotal
                    };

                    lstFichaDeMovimientoDeCajaDTO.Add(fichaDeMovimientoDeCajaDTO);

                    SaldoTotal -= modulogasto.DineroTotal;
                    SaldoEfectivo -= modulogasto.DineroEfectivo;
                    SaldoBanco -= modulogasto.DineroBanco;
                    SaldoCheque -= modulogasto.DineroCheque;
                }
                #endregion

                DataGridViewFicha.Rows.Clear();

                foreach (fichaDeMovimientoDeCajaDTO fichaDeMovimientoDeCajaDTO in lstFichaDeMovimientoDeCajaDTO)
                {

                    SaldoTotal += - fichaDeMovimientoDeCajaDTO.Haber + fichaDeMovimientoDeCajaDTO.Debe;



                    DataGridViewFicha.Rows.Add(fichaDeMovimientoDeCajaDTO.ID.ToString(),    //ID
                        fichaDeMovimientoDeCajaDTO.Fecha.ToString("dd/MM/yyyy HH:mm"),      //Fecha
                        fichaDeMovimientoDeCajaDTO.Referencia,                              //Referencia
                        fichaDeMovimientoDeCajaDTO.Proveedor,                               //Proveedor
                        fichaDeMovimientoDeCajaDTO.Descripcion,                             //Descripcion
                        fichaDeMovimientoDeCajaDTO.Debe,                                    //Debe
                        fichaDeMovimientoDeCajaDTO.Haber,                                   //Haber
                        SaldoTotal,                                                         //Saldo
                        "",
                        "");
                }

                

                //Diseño
                //SaldoTotal
                if (SaldoTotal < 0)
                {
                    txtSaldoTotal.BackColor = Color.Red;
                }
                else
                {
                    txtSaldoTotal.BackColor = Color.Green;
                }
                //SaldoEfectivo
                if (SaldoEfectivo < 0)
                {
                    txtSaldoEfectivo.BackColor = Color.Red;
                }
                else
                {
                    txtSaldoEfectivo.BackColor = Color.Green;
                }
                //SaldoBanco
                if (SaldoBanco < 0)
                {
                    txtSaldoBanco.BackColor = Color.Red;
                }
                else
                {
                    txtSaldoBanco.BackColor = Color.Green;
                }
                //SaldoCheque
                if (SaldoCheque < 0)
                {
                    txtSaldoCheque.BackColor = Color.Red;
                }
                else
                {
                    txtSaldoCheque.BackColor = Color.Green;
                }

                txtSaldoTotal.Text = SaldoTotal.ToString("N2");
                txtSaldoEfectivo.Text = SaldoEfectivo.ToString("N2");
                txtSaldoBanco.Text = SaldoBanco.ToString("N2");
                txtSaldoCheque.Text = SaldoCheque.ToString("N2");

                statusLabel.Text = $@"";
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

        private void btnPagoProveedor_Click(object sender, EventArgs e)
        {
            FichaDeMovimientoDeCaja.FormularioProveedor FormularioProveedor = new(_serviceProvider, 0);

            FormularioProveedor.ShowDialog();
        }

        private void btnCobranza_Click(object sender, EventArgs e)
        {
            FormularioCobranza FormularioCobranza = new(_serviceProvider, 0);

            FormularioCobranza.ShowDialog();
        }

        private void btnVario_Click(object sender, EventArgs e)
        {
            FormularioVario FormularioVario = new(_serviceProvider, 0);

            FormularioVario.ShowDialog();
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            FormularioGasto FormularioGasto = new(_serviceProvider, 0);

            FormularioGasto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTabla();
        }
    }
}
