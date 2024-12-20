using JuanApp2.Areas.JuanApp2.CompraBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Entities;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp2.Formularios.Proveedor
{
    public partial class FormularioCompra : Form
    {
        private readonly ICompraRepository _compraRepository;
        private readonly IProveedorRepository _proveedorRepository;
        private readonly List<Areas.JuanApp2.ProveedorBack.Entities.Proveedor> _lstProveedor;
        private readonly int _compraId;

        public FormularioCompra(IServiceProvider serviceProvider,
            int compraId)
        {
            try
            {
                _compraRepository = serviceProvider.GetRequiredService<ICompraRepository>();
                _proveedorRepository = serviceProvider.GetRequiredService<IProveedorRepository>();

                _compraId = compraId;

                InitializeComponent();

                DateTimePickerFecha.Value = DateTime.Now;

                _lstProveedor = _proveedorRepository.GetAll();

                cmbProveedor.Items.Clear();
                foreach (Areas.JuanApp2.ProveedorBack.Entities.Proveedor proveedor in _lstProveedor)
                {
                    cmbProveedor.Items.Add($@"{proveedor.NombreCompleto}");
                }
                cmbProveedor.SelectedIndex = 0;

                if (_compraId > 0)
                {
                    Areas.JuanApp2.CompraBack.Entities.Compra Compra = _compraRepository
                                                                        .GetByCompraId(_compraId);

                    Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository.GetByProveedorId(Compra.ProveedorId);



                    DateTimePickerFecha.Value = Compra.Fecha;
                    txtDiaDePago.Value = Compra.DiaDePago;
                    txtDescripcion.Text = Compra.Descripcion;
                    txtUnidad.Value = Compra.Unidad;
                    txtKilogramo.Value = Compra.Kilogramo;
                    txtPrecio.Value = Compra.Precio;
                    txtSubtotal.Value = Compra.Subtotal;
                    cmbProveedor.SelectedItem = $@"{Proveedor.NombreCompleto}";
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
                if (txtDescripcion.Text == "")
                {
                    statusLabel.Text = "Agregue una descripcion";
                    return;
                }

                Areas.JuanApp2.ProveedorBack.Entities.Proveedor Proveedor = _proveedorRepository.GetByNombreCompleto(cmbProveedor.SelectedItem.ToString());

                if (_compraId == 0)
                {
                    //Agregar
                    Areas.JuanApp2.CompraBack.Entities.Compra Compra = new()
                    {
                        CompraId = 0,
                        Active = true,
                        UserCreationId = 1,
                        UserLastModificationId = 1,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        Fecha = DateTimePickerFecha.Value,
                        DebeOHaber = true,
                        Referencia = "COMPRA",
                        Descripcion = txtDescripcion.Text,
                        DiaDePago = Convert.ToInt32(txtDiaDePago.Value),
                        Unidad = Convert.ToInt32(txtUnidad.Value),
                        Kilogramo = txtKilogramo.Value,
                        Precio = txtPrecio.Value,
                        Subtotal = txtSubtotal.Value,
                        ProveedorId = Proveedor.ProveedorId
                    };
                    _compraRepository.Add(Compra);
                }
                else
                {
                    //Actualizar
                    JuanApp2.Areas.JuanApp2.CompraBack.Entities.Compra Compra = _compraRepository
                        .GetByCompraId(_compraId);

                    Compra.ProveedorId = Proveedor.ProveedorId;
                    Compra.Fecha = DateTimePickerFecha.Value;
                    Compra.DebeOHaber = true;
                    Compra.Referencia = "COMPRA";
                    Compra.Descripcion = txtDescripcion.Text;
                    Compra.DiaDePago = Convert.ToInt32(txtDiaDePago.Value);
                    Compra.Unidad = Convert.ToInt32(txtUnidad.Value);
                    Compra.Kilogramo = txtKilogramo.Value;
                    Compra.Precio = txtPrecio.Value;
                    Compra.Subtotal = txtSubtotal.Value;
                    Compra.UserLastModificationId = 1;
                    Compra.DateTimeLastModification = DateTime.Now;

                    _compraRepository.Update(Compra);
                }

                Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtDiaDePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtDescripcion.Focus();
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
                    txtUnidad.Focus();
                }
            }
            catch (Exception) { throw; }
        }

        private void txtUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    lblUnidades.Text = $@"Unidades * {txtUnidad.Value.ToString("N2")}";

                    txtKilogramo.Focus();
                }
            }
            catch (Exception) { throw; }
        }

        private void txtKilogramo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    lblKilogramos.Text = $@"Kilogramos * {txtKilogramo.Value.ToString("N2")}";

                    txtPrecio.Focus();
                }
            }
            catch (Exception) { throw; }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    lblPrecio.Text = $@"Precio * ${txtPrecio.Value.ToString("N2")}";

                    decimal Kilogramo = txtKilogramo.Value;
                    decimal Precio = txtPrecio.Value;

                    decimal Subtotal = Kilogramo * Precio;

                    txtSubtotal.Value = Subtotal;

                    lblSubtotal.Text = $@"Subtotal * ${txtSubtotal.Value.ToString("N2")}";

                    btnGuardar.Focus();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
