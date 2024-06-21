using JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp2.Formularios.Cobrador
{
    public partial class FormularioCobrador : Form
    {
        private readonly ICobradorRepository _cobradorRepository;
        private readonly int _cobradorId;

        public FormularioCobrador(IServiceProvider serviceProvider,
            int cobradorId)
        {
            try
            {
                _cobradorRepository = serviceProvider.GetRequiredService<ICobradorRepository>();

                _cobradorId = cobradorId;

                InitializeComponent();

                if (_cobradorId > 0)
                {
                    JuanApp2.Areas.JuanApp2.CobradorBack.Entities.Cobrador Cobrador = _cobradorRepository
                                                                        .GetByCobradorId(_cobradorId);

                    txtNombreCompleto.Text = Cobrador.NombreCompleto;
                    txtCelular.Text = Cobrador.Celular;
                    txtEmail.Text = Cobrador.Email;
                    txtDireccion.Text = Cobrador.Direccion;
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
                    if (_cobradorId == 0)
                    {
                        //Agregar
                        JuanApp2.Areas.JuanApp2.CobradorBack.Entities.Cobrador CobradorTest = _cobradorRepository
                            .AsQueryable()
                            .Where(x => x.NombreCompleto == txtNombreCompleto.Text)
                            .FirstOrDefault();

                        if (CobradorTest == null)
                        {
                            JuanApp2.Areas.JuanApp2.CobradorBack.Entities.Cobrador Cobrador = new()
                            {
                                CobradorId = 0,
                                Active = true,
                                UserCreationId = 1,
                                UserLastModificationId = 1,
                                DateTimeCreation = DateTime.Now,
                                DateTimeLastModification = DateTime.Now,
                                NombreCompleto = txtNombreCompleto.Text,
                                Celular = txtCelular.Text,
                                Direccion = txtDireccion.Text,
                                Email = txtEmail.Text
                            };
                            _cobradorRepository.Add(Cobrador);
                        }
                        else
                        {
                            MessageBox.Show("Este cobrador ya existe. No se guardará como nuevo",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        //Actualizar
                        JuanApp2.Areas.JuanApp2.CobradorBack.Entities.Cobrador Cobrador = _cobradorRepository
                            .GetByCobradorId(_cobradorId);

                        Cobrador.NombreCompleto = txtNombreCompleto.Text;
                        Cobrador.Celular = txtCelular.Text;
                        Cobrador.Email = txtEmail.Text;
                        Cobrador.Direccion = txtDireccion.Text;
                        Cobrador.UserLastModificationId = 1;
                        Cobrador.DateTimeLastModification = DateTime.Now;

                        _cobradorRepository.Update(Cobrador);
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
