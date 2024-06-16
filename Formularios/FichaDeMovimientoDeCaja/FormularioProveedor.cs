using JuanApp2.Areas.JuanApp2.CobradorBack.Entities;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Entities;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.FichaDeMovimientoDeCaja
{
    public partial class FormularioProveedor : Form
    {
        private readonly IModuloProveedorRepository _moduloproveedorRepository;
        private readonly IProveedorRepository _proveedorRepository;
        private readonly List<Proveedor> _lstProveedor;
        private readonly int _moduloproveedorId;

        public FormularioProveedor(IServiceProvider serviceProvider,
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
                foreach (Proveedor proveedor in _lstProveedor)
                {
                    cmbProveedor.Items.Add($@"{proveedor.NombreCompleto}");
                }

                if (_lstProveedor.Count != 0)
                {
                    cmbProveedor.SelectedIndex = 0;
                }

                if (_moduloproveedorId > 0)
                {
                    JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Entities.ModuloProveedor ModuloProveedor = _moduloproveedorRepository
                                                                        .GetByModuloProveedorId(_moduloproveedorId);

                    Proveedor Proveedor = _proveedorRepository.GetByProveedorId(ModuloProveedor.ProveedorId);

                    DateTimePickerFecha.Value = ModuloProveedor.Fecha;
                    cmbProveedor.SelectedItem = Proveedor.NombreCompleto;
                    txtDineroBanco.Value = ModuloProveedor.DineroBanco;
                    txtDineroCheque.Value = ModuloProveedor.DineroCheque;
                    txtDineroEfectivo.Value = ModuloProveedor.DineroEfectivo;
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
                decimal DineroTotalDeSuma = txtDineroBanco.Value + txtDineroCheque.Value + txtDineroEfectivo.Value;

                if (DineroTotalDeSuma != txtDineroTotal.Value)
                {
                    statusLabel.Text = "La suma de cada dinero no coincide con el total";
                    return;
                }

                if (_lstProveedor.Count == 0)
                {
                    statusLabel.Text = "Seleccione un proveedor";
                    return;
                }

                Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(cmbProveedor.SelectedItem.ToString());
                
                if (_moduloproveedorId == 0)
                {
                    //Agregar
                    JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Entities.ModuloProveedor ModuloProveedor = new()
                    {
                        ModuloProveedorId = 0,
                        Active = true,
                        UserCreationId = 1,
                        UserLastModificationId = 1,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        ProveedorId = Proveedor.ProveedorId,
                        Fecha = DateTimePickerFecha.Value,
                        DineroBanco = txtDineroBanco.Value,
                        DineroCheque = txtDineroCheque.Value,
                        DineroEfectivo = txtDineroEfectivo.Value,
                        DineroTotal = txtDineroTotal.Value
                    };
                    _moduloproveedorRepository.Add(ModuloProveedor);
                }
                else
                {
                    //Actualizar
                    JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Entities.ModuloProveedor ModuloProveedor = _moduloproveedorRepository
                        .GetByModuloProveedorId(_moduloproveedorId);

                    ModuloProveedor.Fecha = DateTimePickerFecha.Value;
                    ModuloProveedor.ProveedorId = Proveedor.ProveedorId;
                    ModuloProveedor.DineroBanco = txtDineroBanco.Value;
                    ModuloProveedor.DineroCheque = txtDineroCheque.Value;
                    ModuloProveedor.DineroEfectivo = txtDineroEfectivo.Value;
                    ModuloProveedor.DineroTotal = txtDineroTotal.Value;
                    ModuloProveedor.UserLastModificationId = 1;
                    ModuloProveedor.DateTimeLastModification = DateTime.Now;

                    _moduloproveedorRepository.Update(ModuloProveedor);
                }

                Hide();
            }
            catch (Exception) { throw; }
        }

        private void txtDineroBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtDineroTotal.Value += txtDineroBanco.Value;
                    txtDineroCheque.Focus();
                }
            }
            catch (Exception) { throw; }
        }

        private void txtDineroCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtDineroTotal.Value += txtDineroCheque.Value;
                    txtDineroEfectivo.Focus();
                }
            }
            catch (Exception) { throw; }
        }

        private void txtDineroEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtDineroTotal.Value += txtDineroEfectivo.Value;
                    btnGuardar.Focus();
                }
            }
            catch (Exception) { throw; }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtDineroBanco.Focus();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
