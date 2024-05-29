using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Areas.JuanApp.Repositories;

namespace JuanApp.Formularios.Entrada
{
    public partial class FormularioCliente : Form
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteService _clienteService;
        private readonly int _clienteId;

        public FormularioCliente(IClienteRepository clienteRepository,
            IClienteService clienteService,
            int ClienteId)
        {
            try
            {
                _clienteRepository = clienteRepository;
                _clienteService = clienteService;
                _clienteId = ClienteId;

                InitializeComponent();

                if (ClienteId > 0)
                {
                    Cliente Cliente = _clienteRepository.GetByClienteId(ClienteId);

                    txtCodigoDeCliente.Text = Cliente.CodigoDeCliente;
                    txtNombreDeCliente.Text = Cliente.NombreDeCliente;
                    txtCodigoPostal.Text = Cliente.CodigoPostal;
                    txtCUIT.Text = Cliente.CUIT;
                    txtProvincia.Text = Cliente.Provincia;
                    txtTelefono.Text = Cliente.Telefono;
                    txtDomicilio.Text = Cliente.Domicilio;
                    txtLocalidad.Text = Cliente.Localidad;

                    txtCodigoDeCliente.Enabled = false;
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
                        string.IsNullOrEmpty(txtNombreDeCliente.Text))
                {
                    statusLabel.Text = "Faltan datos a completar";
                }
                else
                {
                    if (_clienteId == 0)
                    {
                        //Agregar

                        Cliente ClienteTest = _clienteRepository
                            .AsQueryable()
                            .Where(x => x.CodigoDeCliente == txtCodigoDeCliente.Text)
                            .FirstOrDefault();

                        if (ClienteTest == null)
                        {
                            Cliente Cliente = new()
                            {
                                ClienteId = _clienteId,
                                Active = true,
                                UserCreationId = 1,
                                UserLastModificationId = 1,
                                DateTimeCreation = DateTime.Now,
                                DateTimeLastModification = DateTime.Now,
                                NombreDeCliente = txtNombreDeCliente.Text,
                                CodigoDeCliente = txtCodigoDeCliente.Text,
                                CodigoPostal = txtCodigoPostal.Text,
                                CUIT = txtCUIT.Text,
                                Domicilio = txtDomicilio.Text,
                                Localidad = txtLocalidad.Text,
                                Telefono = txtTelefono.Text,
                                Provincia = txtProvincia.Text
                            };
                            _clienteRepository.Add(Cliente);
                        }
                        else
                        {
                            MessageBox.Show("Este código de cliente ya existe en el sistema. No se guardará como nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        //Actualizar
                        Cliente Cliente = _clienteRepository.GetByClienteId(_clienteId);

                        Cliente.CodigoDeCliente = txtCodigoDeCliente.Text;
                        Cliente.NombreDeCliente = txtNombreDeCliente.Text;
                        Cliente.CodigoPostal = txtCodigoPostal.Text;
                        Cliente.CUIT = txtCUIT.Text;
                        Cliente.Domicilio = txtDomicilio.Text;
                        Cliente.Localidad = txtLocalidad.Text;
                        Cliente.Telefono = txtTelefono.Text;
                        Cliente.Provincia = txtProvincia.Text;

                        Cliente.UserLastModificationId = 1;
                        Cliente.DateTimeLastModification = DateTime.Now;

                        _clienteRepository.Update(Cliente);
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
