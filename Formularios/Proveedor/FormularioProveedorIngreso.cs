using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorIngresoBack.Entities;
using JuanApp2.Areas.JuanApp2.ProveedorIngresoBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp2.Formularios.Proveedor
{
    public partial class FormularioProveedorIngreso : Form
    {
        private readonly IProveedorIngresoRepository _proveedoringresoRepository;
        private readonly IProveedorRepository _proveedorRepository;
        private int _proveedoringresoId;
        private List<Areas.JuanApp2.ProveedorBack.Entities.Proveedor> _lstProveedor;

        public FormularioProveedorIngreso(IServiceProvider serviceProvider,
            int proveedoringresoId)
        {
            try
            {
                _proveedoringresoRepository = serviceProvider.GetRequiredService<IProveedorIngresoRepository>();
                _proveedorRepository = serviceProvider.GetRequiredService<IProveedorRepository>();

                _proveedoringresoId = proveedoringresoId;

                InitializeComponent();

                DateTimePickerFecha.Value = DateTime.Now;

                optHaber.Checked = true;
                optDebe.Checked = false;

                _lstProveedor = _proveedorRepository.GetAll();

                cmbProveedor.Items.Clear();
                foreach (Areas.JuanApp2.ProveedorBack.Entities.Proveedor proveedor in _lstProveedor)
                {
                    cmbProveedor.Items.Add($@"{proveedor.NombreCompleto}");
                }
                cmbProveedor.SelectedIndex = 0;

                if (_proveedoringresoId > 0)
                {
                    ProveedorIngreso ProveedorIngreso = _proveedoringresoRepository
                                                                                                        .GetByProveedorIngresoId(_proveedoringresoId);

                    Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository
                                                                                    .GetByProveedorId(ProveedorIngreso.ProveedorId);

                    DateTimePickerFecha.Value = ProveedorIngreso.Fecha;
                    txtDescripcion.Text = ProveedorIngreso.Descripcion;
                    txtImporte.Value = ProveedorIngreso.Importe;
                    cmbProveedor.SelectedItem = $@"{Proveedor.NombreCompleto}";
                    if (ProveedorIngreso.DebeOHaber == true)
                    {
                        optDebe.Checked = true;
                        optHaber.Checked = false;
                    }
                    else
                    {
                        optDebe.Checked = false;
                        optHaber.Checked = true;
                    }
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
                if (txtDescripcion.Text == "")
                {
                    statusLabel.Text = "Agregue una descripcion";
                    return;
                }

                Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(cmbProveedor.SelectedItem.ToString());

                if (_proveedoringresoId == 0)
                {
                    //Agregar
                    ProveedorIngreso ProveedorIngreso = new()
                    {
                        ProveedorIngresoId = 0,
                        Active = true,
                        UserCreationId = 1,
                        UserLastModificationId = 1,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        Descripcion = txtDescripcion.Text,
                        Fecha = DateTimePickerFecha.Value,
                        DebeOHaber = optDebe.Checked == true ? true : false,
                        Importe = txtImporte.Value,
                        ProveedorId = Proveedor.ProveedorId
                    };
                    _proveedoringresoRepository.Add(ProveedorIngreso);
                }
                else
                {
                    //Actualizar
                    ProveedorIngreso ProveedorIngreso = _proveedoringresoRepository
                                                            .GetByProveedorIngresoId(_proveedoringresoId);

                    ProveedorIngreso.Fecha = DateTimePickerFecha.Value;
                    ProveedorIngreso.DebeOHaber = optDebe.Checked == true ? true : false;
                    ProveedorIngreso.Descripcion = txtDescripcion.Text;
                    ProveedorIngreso.Importe = txtImporte.Value;
                    Proveedor.ProveedorId = Proveedor.ProveedorId;

                    ProveedorIngreso.UserLastModificationId = 1;
                    ProveedorIngreso.DateTimeLastModification = DateTime.Now;

                    _proveedoringresoRepository.Update(ProveedorIngreso);
                }

                Hide();
            }
            catch (Exception) { throw; }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtImporte.Focus();
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
                    lblImporte.Text = $@"Importe * {txtImporte.Value.ToString("N2")}";

                    btnGuardar.Focus();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
