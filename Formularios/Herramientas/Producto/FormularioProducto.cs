using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using JuanApp.Areas.JuanApp.Entities;

namespace JuanApp.Formularios.Herramientas.Producto
{
    public partial class FormularioProducto : Form
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IProductoService _productoService;
        private readonly int _productoId;

        public FormularioProducto(IProductoRepository productoRepository,
            IProductoService productoService,
            int ProductoId)
        {
            try
            {
                _productoRepository = productoRepository;
                _productoService = productoService;
                _productoId = ProductoId;

                InitializeComponent();

                if (ProductoId > 0)
                {
                    Areas.JuanApp.Entities.Producto Producto = _productoRepository.GetByProductoId(ProductoId);
                    txtCodigoDeProducto.Text = Producto.CodigoProducto;
                    txtNombreDeProducto.Text = Producto.Nombre;

                    txtCodigoDeProducto.Enabled = false;
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
                if (string.IsNullOrEmpty(txtCodigoDeProducto.Text) ||
                        string.IsNullOrEmpty(txtNombreDeProducto.Text))
                {
                    statusLabel.Text = "Faltan datos a completar";
                }
                else
                {
                    if (_productoId == 0)
                    {
                        //Agregar
                        Areas.JuanApp.Entities.Producto Producto = new()
                        {
                            ProductoId = _productoId,
                            Active = true,
                            UserCreationId = 1,
                            UserLastModificationId = 1,
                            DateTimeCreation = DateTime.Now,
                            DateTimeLastModification = DateTime.Now,
                            Nombre = txtNombreDeProducto.Text,
                            CodigoProducto = txtCodigoDeProducto.Text,
                        };
                        _productoRepository.Add(Producto);
                    }
                    else
                    {
                        //Actualizar
                        Areas.JuanApp.Entities.Producto Producto = _productoRepository.GetByProductoId(_productoId);

                        Producto.CodigoProducto = txtCodigoDeProducto.Text;
                        Producto.Nombre = txtNombreDeProducto.Text;
                        Producto.UserLastModificationId = 1;
                        Producto.DateTimeLastModification = DateTime.Now;

                        _productoRepository.Update(Producto);
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
