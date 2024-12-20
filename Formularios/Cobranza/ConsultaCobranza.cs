﻿using JuanApp2.Areas.JuanApp2.CobradorBack.Entities;
using JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Entities;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JuanApp2.Formularios.Cobranza
{
    public partial class ConsultaCobranza : Form
    {
        private readonly ICobranzaRepository _cobranzaRepository;
        private readonly ICobradorRepository _cobradorRepository;
        private readonly ServiceProvider _serviceProvider;

        public ConsultaCobranza(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;

                _cobranzaRepository = serviceProvider.GetRequiredService<ICobranzaRepository>();
                _cobradorRepository = serviceProvider.GetRequiredService<ICobradorRepository>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "CobranzaId";
                col0.HeaderText = "ID del sistema";
                DataGridViewCobranza.Columns.Add(col0);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "DateTimeLastModification";
                col1.HeaderText = "Fecha";
                DataGridViewCobranza.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "Cobrador";
                col2.HeaderText = "Cobrador";
                DataGridViewCobranza.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "DineroTotal";
                col3.HeaderText = "Total cobrado";
                DataGridViewCobranza.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new();
                col4.DataPropertyName = "DineroEfectivo";
                col4.HeaderText = "Efectivo";
                DataGridViewCobranza.Columns.Add(col4);

                DataGridViewTextBoxColumn col5 = new();
                col5.DataPropertyName = "DineroBanco";
                col5.HeaderText = "Banco";
                DataGridViewCobranza.Columns.Add(col5);

                DataGridViewTextBoxColumn col6 = new();
                col6.DataPropertyName = "DineroCheque";
                col6.HeaderText = "Cheque";
                DataGridViewCobranza.Columns.Add(col6);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewCobranza.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewCobranza.Columns.Add(colBorrar);

                WindowState = FormWindowState.Maximized;

                DataGridViewCobranza.AutoGenerateColumns = false;
                DataGridViewCobranza.DefaultCellStyle.Font = new Font("Arial", 11);

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
                if (e.ColumnIndex == 7)
                {
                    //Actualizar
                    int CobranzaId = Convert.ToInt32(DataGridViewCobranza.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioCobranza FormularioCobranza = new(_serviceProvider,
                    CobranzaId);

                    FormularioCobranza.ShowDialog();

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
                        int CobranzaId = Convert.ToInt32(DataGridViewCobranza.Rows[e.RowIndex].Cells[0].Value.ToString());

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
                List<Areas.JuanApp2.CobranzaBack.Entities.Cobranza> lstCobranza = [];

                Areas.JuanApp2.CobradorBack.Entities.Cobrador Cobrador = _cobradorRepository.GetByNombreCompleto(txtBuscar.Text);

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

                DataGridViewCobranza.Rows.Clear();

                //This has been done in this way to avoid hundred of calls to the DB
                List<int> lstCobradorDataGridViewIDs = [];
                foreach (Areas.JuanApp2.CobranzaBack.Entities.Cobranza cobranza in lstCobranza)
                {
                    lstCobradorDataGridViewIDs.Add(cobranza.CobradorId);
                }

                List<Areas.JuanApp2.CobradorBack.Entities.Cobrador> lstCobradorDataGridView = _cobradorRepository
                    .GetAllByCobradorIdWithIDsList(lstCobradorDataGridViewIDs);

                for (int i = 0; i < lstCobranza.Count; i++)
                {
                    string CobradorNombreCompleto = "";

                    for (int j = 0; j < lstCobradorDataGridView.Count; j++)
                    {
                        if (lstCobranza[i].CobradorId == lstCobradorDataGridView[j].CobradorId)
                        {
                            CobradorNombreCompleto = lstCobradorDataGridView[j].NombreCompleto;
                        }
                    }

                    DataGridViewCobranza.Rows.Add(lstCobranza[i].CobranzaId.ToString(),
                        lstCobranza[i].DateTimeLastModification.ToString("dd/MM/yyyy HH:mm"),
                        CobradorNombreCompleto,
                        $@"${lstCobranza[i].DineroTotal.ToString("N2")}",
                        $@"${lstCobranza[i].DineroEfectivo.ToString("N2")}",
                        $@"${lstCobranza[i].DineroBanco.ToString("N2")}",
                        $@"${lstCobranza[i].DineroCheque.ToString("N2")}",
                        "",
                        "");
                }

                DataGridViewCobranza.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                statusLabel.Text = $@"Información: Cantidad de cobranzas listadas: {lstCobranza.Count}";
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
                FormularioCobranza FormularioCaja = new(_serviceProvider,
                        0);

                FormularioCaja.ShowDialog();
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
