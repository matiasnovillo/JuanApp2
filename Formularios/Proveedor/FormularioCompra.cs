using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using JuanApp2.Areas.JuanApp2.CompraBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Entrada
{
    public partial class FormularioCompra : Form
    {
        private readonly ICompraRepository _compraRepository;
        private readonly int _compraId;

        public FormularioCompra(IServiceProvider serviceProvider,
            int compraId)
        {
            try
            {
                _compraRepository = serviceProvider.GetRequiredService<ICompraRepository>();

                _compraId = compraId;

                InitializeComponent();

                optHaber.Checked = true;
                optDebe.Checked = false;

                DateTimePickerFecha.Value = DateTime.Now;

                if (_compraId > 0)
                {
                    JuanApp2.Areas.JuanApp2.CompraBack.Entities.Compra Compra = _compraRepository
                                                                        .GetByCompraId(_compraId);

                    DateTimePickerFecha.Value = Compra.Fecha;
                    txtDiaDePago.Value = Compra.DiaDePago;
                    txtDiaDePago.Value = Compra.DiaDePago;
                    txtReferencia.Text = Compra.Referencia;
                    txtDescripcion.Text = Compra.Descripcion;
                    txtUnidad.Value = Compra.Unidad;
                    txtKilogramo.Value = Compra.Kilogramo;
                    txtPrecio.Value = Compra.Precio;
                    txtSubtotal.Value = Compra.Subtotal;
                    if (Compra.DebeOHaber == true)
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
                if (txtReferencia.Text == "" ||
                    txtDescripcion.Text == "")
                {
                    statusLabel.Text = "Faltan datos a completar";
                }

                if (_compraId == 0)
                {
                    //Agregar
                    JuanApp2.Areas.JuanApp2.CompraBack.Entities.Compra Compra = new()
                    {
                        CompraId = 0,
                        Active = true,
                        UserCreationId = 1,
                        UserLastModificationId = 1,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        Fecha = DateTimePickerFecha.Value,
                        DebeOHaber = optDebe.Checked == true ? true : false,
                        Referencia = txtReferencia.Text,
                        Descripcion = txtDescripcion.Text,
                        DiaDePago = Convert.ToInt32(txtDiaDePago.Value),
                        Unidad = Convert.ToInt32(txtUnidad.Value),
                        Kilogramo = txtKilogramo.Value,
                        Precio = txtPrecio.Value,
                        Subtotal = txtSubtotal.Value
                    };
                    _compraRepository.Add(Compra);
                }
                else
                {
                    //Actualizar
                    JuanApp2.Areas.JuanApp2.CompraBack.Entities.Compra Compra = _compraRepository
                        .GetByCompraId(_compraId);

                    Compra.Fecha = DateTimePickerFecha.Value;
                    Compra.DebeOHaber = optDebe.Checked == true ? true : false;
                    Compra.Referencia = txtReferencia.Text;
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
    }
}
