using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp2.Formularios.Proveedor
{
    public partial class FormularioGasto : Form
    {
        private readonly IProveedorRepository _proveedorRepository;
        private readonly int _proveedorId;

        public FormularioGasto(IServiceProvider serviceProvider,
            int proveedorId)
        {
            try
            {
                _proveedorRepository = serviceProvider.GetRequiredService<IProveedorRepository>();

                _proveedorId = proveedorId;

                InitializeComponent();

                if (_proveedorId > 0)
                {
                    JuanApp2.Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository
                                                                        .GetByProveedorId(_proveedorId);

                    txtNombreCompleto.Text = Proveedor.NombreCompleto;
                    txtCelular.Text = Proveedor.Celular;
                    txtPaginaWeb.Text = Proveedor.PaginaWeb;
                    txtDireccion.Text = Proveedor.Direccion;
                }

                statusLabel.Text = "";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreCompleto.Text))
                {
                    statusLabel.Text = "Faltan datos a completar";
                }
                else
                {
                    if (_proveedorId == 0)
                    {
                        //Agregar
                        JuanApp2.Areas.JuanApp2.ProveedorBack.Entities.Proveedor ProveedorTest = _proveedorRepository
                            .AsQueryable()
                            .Where(x => x.NombreCompleto == txtNombreCompleto.Text)
                            .FirstOrDefault();

                        if (ProveedorTest == null)
                        {
                            JuanApp2.Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = new()
                            {
                                ProveedorId = 0,
                                Active = true,
                                UserCreationId = 1,
                                UserLastModificationId = 1,
                                DateTimeCreation = DateTime.Now,
                                DateTimeLastModification = DateTime.Now,
                                NombreCompleto = txtNombreCompleto.Text,
                                Celular = txtCelular.Text,
                                Direccion = txtDireccion.Text,
                                PaginaWeb = txtPaginaWeb.Text
                            };
                            _proveedorRepository.Add(Proveedor);
                        }
                        else
                        {
                            MessageBox.Show("Este proveedor ya existe. No se guardará como nuevo",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        //Actualizar
                        JuanApp2.Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository
                            .GetByProveedorId(_proveedorId);

                        Proveedor.NombreCompleto = txtNombreCompleto.Text;
                        Proveedor.Celular = txtCelular.Text;
                        Proveedor.PaginaWeb = txtPaginaWeb.Text;
                        Proveedor.Direccion = txtDireccion.Text;
                        Proveedor.UserLastModificationId = 1;
                        Proveedor.DateTimeLastModification = DateTime.Now;

                        _proveedorRepository.Update(Proveedor);
                    }

                    Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
