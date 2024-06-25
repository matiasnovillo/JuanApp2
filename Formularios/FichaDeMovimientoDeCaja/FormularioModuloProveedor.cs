using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp2.Formularios.FichaDeMovimientoDeCaja
{
    public partial class FormularioModuloProveedor : Form
    {
        private readonly IModuloProveedorRepository _moduloproveedorRepository;
        private readonly IProveedorRepository _proveedorRepository;
        private readonly List<Areas.JuanApp2.ProveedorBack.Entities.Proveedor> _lstProveedor;
        private readonly int _moduloproveedorId;

        public FormularioModuloProveedor(IServiceProvider serviceProvider,
            int moduloproveedorId)
        {
            try
            {
                _moduloproveedorRepository = serviceProvider.GetRequiredService<IModuloProveedorRepository>();
                _proveedorRepository = serviceProvider.GetRequiredService<IProveedorRepository>();

                _moduloproveedorId = moduloproveedorId;

                InitializeComponent();

                DateTimePickerFecha.Value = DateTime.Now;

                _lstProveedor = _proveedorRepository.GetAll();

                cmbProveedor.Items.Clear();
                foreach (Areas.JuanApp2.ProveedorBack.Entities.Proveedor proveedor in _lstProveedor)
                {
                    cmbProveedor.Items.Add($@"{proveedor.NombreCompleto}");
                }

                if (_lstProveedor.Count != 0)
                {
                    cmbProveedor.SelectedIndex = 0;
                }

                if (_moduloproveedorId > 0)
                {
                    Areas.JuanApp2.ModuloProveedorBack.Entities.ModuloProveedor ModuloProveedor = _moduloproveedorRepository
                                                                        .GetByModuloProveedorId(_moduloproveedorId);

                    Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository.GetByProveedorId(ModuloProveedor.ProveedorId);

                    DateTimePickerFecha.Value = ModuloProveedor.Fecha;
                    cmbProveedor.SelectedItem = Proveedor.NombreCompleto;
                    txtDescripcion.Text = ModuloProveedor.Descripcion;
                    txtDineroTotal.Value = ModuloProveedor.DineroTotal;
                }

                statusLabel.Text = "";
            }
            catch (Exception) { throw; }
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_lstProveedor.Count == 0)
                {
                    statusLabel.Text = "Seleccione un proveedor";
                    return;
                }

                if (txtDescripcion.Text == "")
                {
                    statusLabel.Text = "Agregue una descripcion";
                    return;
                }

                Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(cmbProveedor.SelectedItem.ToString());

                if (_moduloproveedorId == 0)
                {
                    //Agregar
                    Areas.JuanApp2.ModuloProveedorBack.Entities.ModuloProveedor ModuloProveedor = new()
                    {
                        ModuloProveedorId = 0,
                        Active = true,
                        UserCreationId = 1,
                        UserLastModificationId = 1,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        ProveedorId = Proveedor.ProveedorId,
                        Fecha = DateTimePickerFecha.Value,
                        DineroBanco = 0,
                        DineroCheque = 0,
                        DineroEfectivo = 0,
                        DineroTotal = txtDineroTotal.Value,
                        Descripcion = txtDescripcion.Text
                    };
                    _moduloproveedorRepository.Add(ModuloProveedor);
                }
                else
                {
                    //Actualizar
                    Areas.JuanApp2.ModuloProveedorBack.Entities.ModuloProveedor ModuloProveedor = _moduloproveedorRepository
                        .GetByModuloProveedorId(_moduloproveedorId);

                    ModuloProveedor.UserLastModificationId = 1;
                    ModuloProveedor.DateTimeLastModification = DateTime.Now;
                    ModuloProveedor.ProveedorId = Proveedor.ProveedorId;
                    ModuloProveedor.Fecha = DateTimePickerFecha.Value;
                    ModuloProveedor.DineroTotal = txtDineroTotal.Value;
                    ModuloProveedor.Descripcion = txtDescripcion.Text;

                    _moduloproveedorRepository.Update(ModuloProveedor);
                }

                Hide();
            }
            catch (Exception) { throw; }
        }


        private void txtDescripcion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtDineroTotal.Focus();
                }
            }
            catch (Exception) { throw; }
        }

        private void txtDineroTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    lblDineroTotal.Text = $@"Dinero total * {txtDineroTotal.Value.ToString("N2")}";

                    btnGuardar.Focus();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
