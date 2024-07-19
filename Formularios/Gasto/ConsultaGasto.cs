using JuanApp2.Areas.JuanApp2.GastoBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace JuanApp2.Formularios.Gasto
{
    public partial class ConsultaGasto : Form
    {
        private readonly IGastoRepository _gastoRepository;
        private readonly ServiceProvider _serviceProvider;

        public ConsultaGasto(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;

                _gastoRepository = serviceProvider.GetRequiredService<IGastoRepository>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "GastoId";
                col0.HeaderText = "ID del sistema";
                DataGridViewGasto.Columns.Add(col0);

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
                if (e.ColumnIndex == 4)
                {
                    //Actualizar
                    int GastoId = Convert.ToInt32(DataGridViewGasto.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioGasto FormularioGasto = new(_serviceProvider,
                    GastoId);

                    FormularioGasto.ShowDialog();

                    GetTabla();
                }
                else if (e.ColumnIndex == 5)
                {
                    //Borrar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int GastoId = Convert.ToInt32(DataGridViewGasto.Rows[e.RowIndex].Cells[0].Value.ToString());

                        _gastoRepository.DeleteByGastoId(GastoId);

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
                List<Areas.JuanApp2.GastoBack.Entities.Gasto> lstGasto = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstGasto = _gastoRepository
                    .AsQueryable()
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
                    .Where(x => words.All(word => x.Descripcion.Contains(word)))
                    .OrderBy(x => x.Fecha)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                    .ToList();
                }

                DataGridViewGasto.DataSource = lstGasto;

                statusLabel.Text = $@"Información: Cantidad de gastos listados: {lstGasto.Count}";
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
    }
}
