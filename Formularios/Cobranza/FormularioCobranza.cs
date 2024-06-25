using JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp2.Formularios.Cobranza
{
    public partial class FormularioCobranza : Form
    {
        private readonly ICobranzaRepository _cobranzaRepository;
        private readonly ICobradorRepository _cobradorRepository;
        private readonly List<JuanApp2.Areas.JuanApp2.CobradorBack.Entities.Cobrador> _lstCobrador;
        private readonly int _cobranzaId;

        public FormularioCobranza(IServiceProvider serviceProvider,
            int cobranzaId)
        {
            try
            {
                _cobranzaRepository = serviceProvider.GetRequiredService<ICobranzaRepository>();
                _cobradorRepository = serviceProvider.GetRequiredService<ICobradorRepository>();

                _cobranzaId = cobranzaId;

                InitializeComponent();

                _lstCobrador = _cobradorRepository.GetAll();

                cmbCobrador.Items.Clear();
                foreach (JuanApp2.Areas.JuanApp2.CobradorBack.Entities.Cobrador cobrador in _lstCobrador)
                {
                    cmbCobrador.Items.Add($@"{cobrador.NombreCompleto}");
                }

                if (_lstCobrador.Count != 0)
                {
                    cmbCobrador.SelectedIndex = 0;
                }

                if (_cobranzaId > 0)
                {
                    Areas.JuanApp2.CobranzaBack.Entities.Cobranza Cobranza = _cobranzaRepository
                                                                        .GetByCobranzaId(_cobranzaId);

                    Areas.JuanApp2.CobradorBack.Entities.Cobrador Cobrador = _cobradorRepository.GetByCobradorId(Cobranza.CobradorId);

                    cmbCobrador.SelectedItem = $@"{Cobrador.NombreCompleto}";
                    txtDineroTotal.Value = Cobranza.DineroTotal;
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
                if (_lstCobrador.Count == 0)
                {
                    statusLabel.Text = "Seleccione un cobrador";
                    return;
                }

                Areas.JuanApp2.CobradorBack.Entities.Cobrador Cobrador = _cobradorRepository.GetByNombreCompleto(cmbCobrador.SelectedItem.ToString());

                if (_cobranzaId == 0)
                {
                    //Agregar
                    Areas.JuanApp2.CobranzaBack.Entities.Cobranza Cobranza = new()
                    {
                        CobranzaId = 0,
                        Active = true,
                        UserCreationId = 1,
                        UserLastModificationId = 1,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        CobradorId = Cobrador.CobradorId,
                        DineroBanco = 0,
                        DineroCheque = 0,
                        DineroEfectivo = 0,
                        DineroTotal = txtDineroTotal.Value
                    };
                    _cobranzaRepository.Add(Cobranza);
                }
                else
                {
                    //Actualizar
                    Areas.JuanApp2.CobranzaBack.Entities.Cobranza Cobranza = _cobranzaRepository
                        .GetByCobranzaId(_cobranzaId);

                    Cobranza.CobradorId = Cobrador.CobradorId;
                    Cobranza.DineroTotal = txtDineroTotal.Value;
                    Cobranza.UserLastModificationId = 1;
                    Cobranza.DateTimeLastModification = DateTime.Now;

                    _cobranzaRepository.Update(Cobranza);
                }

                Hide();
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
