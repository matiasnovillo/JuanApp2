using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Salida
{
    public partial class FormularioSalida : Form
    {
        private readonly ISalidaRepository _salidaRepository;
        private readonly ISalidaService _salidaService;

        private readonly IEntradaRepository _entradaRepository;

        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteService _clienteService;

        private readonly IProductoRepository _productoRepository;

        private readonly int _salidaId;
        public FormularioSalida(IServiceProvider serviceProvider,
            int salidaId)
        {
            try
            {
                _salidaRepository = serviceProvider.GetRequiredService<ISalidaRepository>();
                _salidaService = serviceProvider.GetRequiredService<ISalidaService>();

                _entradaRepository = serviceProvider.GetRequiredService<IEntradaRepository>();

                _clienteRepository = serviceProvider.GetRequiredService<IClienteRepository>();
                _clienteService = serviceProvider.GetRequiredService<IClienteService>();

                _productoRepository = serviceProvider.GetRequiredService<IProductoRepository>();

                _salidaId = salidaId;

                InitializeComponent();

                if (salidaId > 0)
                {
                    Areas.JuanApp.Entities.Salida Salida = _salidaRepository
                                                                        .GetBySalidaId(salidaId);

                    txtNroDePesada.Text = Salida.NroDePesaje.ToString();
                    txtCodigoDeCliente.Text = Salida.CodigoDeCliente;
                    txtNombreDeCliente.Text = Salida.NombreDeCliente;
                    txtCodigoDeProducto.Text = Salida.CodigoDeProducto.ToString();
                    txtNombreProducto.Text = Salida.NombreDeProducto;
                    numericUpDownKilosTotales.Value = Salida.KilosReales;
                    numericUpDownPrecio.Value = Salida.Precio;
                    numericUpDownSubtotal.Value = Salida.Subtotal;

                    txtNroDePesada.Enabled = false;
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
                if (string.IsNullOrEmpty(txtCodigoDeCliente.Text) ||
                       string.IsNullOrEmpty(txtNombreDeCliente.Text) ||
                       string.IsNullOrEmpty(txtNroDePesada.Text) ||
                       string.IsNullOrEmpty(txtCodigoDeProducto.Text) ||
                       string.IsNullOrEmpty(txtNombreProducto.Text) ||
                       numericUpDownKilosTotales.Value == 0)
                {
                    statusLabel.Text = "Faltan datos a completar";
                }
                else
                {
                    if (_salidaId == 0)
                    {
                        Areas.JuanApp.Entities.Salida SalidaTest = _salidaRepository
                            .AsQueryable()
                            .Where(x => x.NroDePesaje == Convert.ToInt32(txtNroDePesada.Text))
                            .FirstOrDefault();

                        if (SalidaTest == null)
                        {
                            //Agregar
                            Areas.JuanApp.Entities.Salida Salida = new()
                            {
                                SalidaId = _salidaId,
                                Active = true,
                                UserCreationId = 1,
                                UserLastModificationId = 1,
                                DateTimeCreation = DateTime.Now,
                                DateTimeLastModification = DateTime.Now,
                                CodigoDeCliente = txtCodigoDeCliente.Text,
                                NombreDeCliente = txtNombreDeCliente.Text,
                                NroDePesaje = Convert.ToInt32(txtNroDePesada.Text),
                                CodigoDeProducto = Convert.ToInt32(txtCodigoDeProducto.Text),
                                NombreDeProducto = txtNombreProducto.Text,
                                KilosReales = numericUpDownKilosTotales.Value,
                                Precio = numericUpDownPrecio.Value,
                                Subtotal = numericUpDownSubtotal.Value
                            };
                            _salidaRepository.Add(Salida);
                        }
                        else
                        {
                            MessageBox.Show("Este Nº de pesaje ya existe en el sistema. No se guardará como nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        //Actualizar
                        Areas.JuanApp.Entities.Salida Salida = _salidaRepository.GetBySalidaId(_salidaId);

                        Salida.NroDePesaje = Convert.ToInt32(txtNroDePesada.Text);
                        Salida.CodigoDeCliente = txtCodigoDeCliente.Text;
                        Salida.NombreDeCliente = txtNombreDeCliente.Text;
                        Salida.CodigoDeProducto = Convert.ToInt32(txtCodigoDeProducto.Text);
                        Salida.NombreDeProducto = txtNombreProducto.Text;
                        Salida.KilosReales = numericUpDownKilosTotales.Value;
                        Salida.Precio = numericUpDownPrecio.Value;
                        Salida.Subtotal = numericUpDownSubtotal.Value;
                        Salida.UserLastModificationId = 1;
                        Salida.DateTimeLastModification = DateTime.Now;

                        _salidaRepository.Update(Salida);
                    }

                    Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtCodigoDeProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Producto Producto = _productoRepository
                        .AsQueryable()
                        .Where(x => x.CodigoProducto == txtCodigoDeProducto.Text)
                        .FirstOrDefault();

                    if (Producto != null)
                    {
                        txtNombreProducto.Text = Producto.Nombre;
                    }

                    numericUpDownPrecio.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtCodigoDeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Cliente Cliente = _clienteRepository
                        .AsQueryable()
                        .Where(x => x.CodigoDeCliente == txtCodigoDeCliente.Text)
                        .FirstOrDefault();

                    if (Cliente != null)
                    {
                        txtNombreDeCliente.Text = Cliente.NombreDeCliente;
                    }

                    txtCodigoDeProducto.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void numericUpDownKilosTotales_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    numericUpDownSubtotal.Value = numericUpDownPrecio.Value * numericUpDownKilosTotales.Value;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void numericUpDownPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    numericUpDownSubtotal.Value = numericUpDownPrecio.Value * numericUpDownKilosTotales.Value;

                    btnGuardar.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtNroDePesada_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Areas.JuanApp.Entities.Entrada Entrada = _entradaRepository
                        .AsQueryable()
                        .Where(x => x.NroDePesaje == Convert.ToInt32(txtNroDePesada.Text))
                        .FirstOrDefault();

                    if (Entrada != null)
                    {
                        txtNombreProducto.Text = Entrada.NombreDeProducto;
                        txtCodigoDeProducto.Text = Entrada.CodigoDeProducto;
                        numericUpDownKilosTotales.Value = Entrada.Neto;
                    }

                    txtCodigoDeCliente.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
