using JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace JuanApp.Formularios.Entrada
{
    public partial class ConsultaProveedor : Form
    {
        private readonly ICobradorRepository _cobradorRepository;
        private readonly ServiceProvider _serviceProvider;

        public ConsultaProveedor(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;

                _cobradorRepository = serviceProvider.GetRequiredService<ICobradorRepository>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "CobradorId";
                col0.HeaderText = "ID del sistema";
                DataGridViewCobrador.Columns.Add(col0);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "NombreCompleto";
                col1.HeaderText = "Nombre completo";
                DataGridViewCobrador.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "Celular";
                col2.HeaderText = "Celular";
                DataGridViewCobrador.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "Email";
                col3.HeaderText = "Email";
                DataGridViewCobrador.Columns.Add(col3);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewCobrador.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewCobrador.Columns.Add(colBorrar);

                WindowState = FormWindowState.Maximized;

                DataGridViewCobrador.AutoGenerateColumns = false;

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
                if (e.ColumnIndex == 4)
                {
                    //Actualizar
                    int CobradorId = Convert.ToInt32(DataGridViewCobrador.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioProveedor FormularioCobrador = new(_serviceProvider,
                    CobradorId);

                    FormularioCobrador.ShowDialog();

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
                        int CobradorId = Convert.ToInt32(DataGridViewCobrador.Rows[e.RowIndex].Cells[0].Value.ToString());

                        _cobradorRepository.DeleteByCobradorId(CobradorId);

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
                List<JuanApp2.Areas.JuanApp2.CobradorBack.Entities.Cobrador> lstCobrador = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstCobrador = _cobradorRepository
                    .AsQueryable()
                    .OrderBy(x => x.NombreCompleto)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                    .ToList();
                }
                else
                {
                    string[] words = Regex
                        .Replace(txtBuscar.Text
                        .Trim(), @"\s+", " ")
                        .Split(" ");

                    lstCobrador = _cobradorRepository
                    .AsQueryable()
                    .Where(x => words.All(word => x.NombreCompleto.Contains(word)))
                    .OrderBy(x => x.NombreCompleto)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                    .ToList();
                }

                DataGridViewCobrador.DataSource = lstCobrador;

                statusLabel.Text = $@"Información: Cantidad de cobradores listados: {lstCobrador.Count}";
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

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioCompra FormularioCompra = new(_serviceProvider,
                        0);

                FormularioCompra.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
