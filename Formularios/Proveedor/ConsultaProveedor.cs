using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace JuanApp.Formularios.Entrada
{
    public partial class ConsultaProveedor : Form
    {
        private readonly IProveedorRepository _proveedorRepository;
        private readonly ServiceProvider _serviceProvider;

        public ConsultaProveedor(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;

                _proveedorRepository = serviceProvider.GetRequiredService<IProveedorRepository>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "ProveedorId";
                col0.HeaderText = "ID del sistema";
                DataGridViewProveedor.Columns.Add(col0);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "NombreCompleto";
                col1.HeaderText = "Nombre completo";
                DataGridViewProveedor.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "Celular";
                col2.HeaderText = "Celular";
                DataGridViewProveedor.Columns.Add(col2);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewProveedor.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewProveedor.Columns.Add(colBorrar);

                WindowState = FormWindowState.Maximized;

                DataGridViewProveedor.AutoGenerateColumns = false;

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
                if (e.ColumnIndex == 3)
                {
                    //Actualizar
                    int ProveedorId = Convert.ToInt32(DataGridViewProveedor.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioProveedor FormularioProveedor = new(_serviceProvider,
                    ProveedorId);

                    FormularioProveedor.ShowDialog();

                    GetTabla();
                }
                else if (e.ColumnIndex == 4)
                {
                    //Borrar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int ProveedorId = Convert.ToInt32(DataGridViewProveedor.Rows[e.RowIndex].Cells[0].Value.ToString());

                        _proveedorRepository.DeleteByProveedorId(ProveedorId);

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
                List<JuanApp2.Areas.JuanApp2.ProveedorBack.Entities.Proveedor> lstProveedor = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstProveedor = _proveedorRepository
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

                    lstProveedor = _proveedorRepository
                    .AsQueryable()
                    .Where(x => words.All(word => x.NombreCompleto.Contains(word)))
                    .OrderBy(x => x.NombreCompleto)
                    .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                    .ToList();
                }

                DataGridViewProveedor.DataSource = lstProveedor;

                statusLabel.Text = $@"Información: Cantidad de proveedores listados: {lstProveedor.Count}";
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
                FormularioProveedor FormularioProveedor = new(_serviceProvider,
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
