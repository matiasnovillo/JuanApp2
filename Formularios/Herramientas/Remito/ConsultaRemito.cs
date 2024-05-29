using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Formularios.Entrada;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Herramientas.Remito
{
    public partial class ConsultaRemito : Form
    {
        private readonly IRemitoRepository _remitoRepository;
        private readonly IRemitoService _remitoService;

        public ConsultaRemito(ServiceProvider serviceProvider)
        {
            try
            {
                _remitoRepository = serviceProvider.GetRequiredService<IRemitoRepository>();
                _remitoService = serviceProvider.GetRequiredService<IRemitoService>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "RemitoId";
                col0.HeaderText = "RemitoId";
                DataGridViewRemito.Columns.Add(col0);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "Fecha";
                col1.HeaderText = "Fecha";
                DataGridViewRemito.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "CodigoCliente";
                col2.HeaderText = "CodigoCliente";
                DataGridViewRemito.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "NombreCliente";
                col3.HeaderText = "NombreCliente";
                DataGridViewRemito.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new();
                col4.DataPropertyName = "KilosTotales";
                col4.HeaderText = "KilosTotales";
                DataGridViewRemito.Columns.Add(col4);

                DataGridViewTextBoxColumn col5 = new();
                col5.DataPropertyName = "PrecioTotal";
                col5.HeaderText = "PrecioTotal";
                DataGridViewRemito.Columns.Add(col5);

                DataGridViewTextBoxColumn col6 = new();
                col6.DataPropertyName = "SubtotalTotal";
                col6.HeaderText = "SubtotalTotal";
                DataGridViewRemito.Columns.Add(col6);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewRemito.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewRemito.Columns.Add(colBorrar);

                DataGridViewRemito.AutoGenerateColumns = false;

                WindowState = FormWindowState.Maximized;

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

        private void DataGridViewRemito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    //Actualizar
                    int RemitoId = Convert.ToInt32(DataGridViewRemito.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioRemito FormularioRemito = new(_remitoRepository,
                    _remitoService,
                    RemitoId);

                    FormularioRemito.ShowDialog();

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
                        int RemitoId = Convert.ToInt32(DataGridViewRemito.Rows[e.RowIndex].Cells[0].Value.ToString());

                        _remitoRepository.DeleteByRemitoId(RemitoId);

                        GetTabla();
                    }
                }
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
                FormularioRemito FormularioRemito = new(_remitoRepository,
                        _remitoService,
                        0);

                FormularioRemito.ShowDialog();
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
                List<Areas.JuanApp.Entities.Remito> lstRemito = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstRemito = _remitoRepository
                    .AsQueryable()
                    .OrderBy(x => x.RemitoId)
                    .ToList();
                }
                else
                {
                    lstRemito = _remitoRepository
                    .AsQueryable()
                    .Where(x => x.CodigoCliente.ToString() == txtBuscar.Text ||
                    x.NombreCliente.ToString() == txtBuscar.Text)
                    .OrderBy(x => x.RemitoId)
                    .ToList();
                }

                DataGridViewRemito.DataSource = lstRemito;

                statusLabel.Text = $@"Información: Cantidad de remitos listados: {lstRemito.Count}";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
