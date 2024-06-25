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
                    JuanApp2.Areas.JuanApp2.CobranzaBack.Entities.Cobranza Cobranza = _cobranzaRepository
                                                                        .GetByCobranzaId(_cobranzaId);

                    JuanApp2.Areas.JuanApp2.CobradorBack.Entities.Cobrador Cobrador = _cobradorRepository.GetByCobradorId(Cobranza.CobradorId);

                    cmbCobrador.SelectedItem = $@"{Cobrador.NombreCompleto}";
                    txtDineroBanco.Value = Cobranza.DineroBanco;
                    txtDineroCheque.Value = Cobranza.DineroCheque;
                    txtDineroEfectivo.Value = Cobranza.DineroEfectivo;
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
                decimal DineroTotalDeSuma = txtDineroBanco.Value + txtDineroCheque.Value + txtDineroEfectivo.Value;

                if (DineroTotalDeSuma != txtDineroTotal.Value)
                {
                    statusLabel.Text = "La suma de cada dinero no coincide con el total";
                    return;
                }

                if (_lstCobrador.Count == 0)
                {
                    statusLabel.Text = "Seleccione un cobrador";
                    return;
                }

                JuanApp2.Areas.JuanApp2.CobradorBack.Entities.Cobrador Cobrador = _cobradorRepository.GetByNombreCompleto(cmbCobrador.SelectedItem.ToString());

                if (_cobranzaId == 0)
                {
                    //Agregar
                    JuanApp2.Areas.JuanApp2.CobranzaBack.Entities.Cobranza Cobranza = new()
                    {
                        CobranzaId = 0,
                        Active = true,
                        UserCreationId = 1,
                        UserLastModificationId = 1,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        CobradorId = Cobrador.CobradorId,
                        DineroBanco = txtDineroBanco.Value,
                        DineroCheque = txtDineroCheque.Value,
                        DineroEfectivo = txtDineroEfectivo.Value,
                        DineroTotal = txtDineroTotal.Value
                    };
                    _cobranzaRepository.Add(Cobranza);
                }
                else
                {
                    //Actualizar
                    JuanApp2.Areas.JuanApp2.CobranzaBack.Entities.Cobranza Cobranza = _cobranzaRepository
                        .GetByCobranzaId(_cobranzaId);

                    Cobranza.CobradorId = Cobrador.CobradorId;
                    Cobranza.DineroBanco = txtDineroBanco.Value;
                    Cobranza.DineroCheque = txtDineroCheque.Value;
                    Cobranza.DineroEfectivo = txtDineroEfectivo.Value;
                    Cobranza.DineroTotal = txtDineroTotal.Value;
                    Cobranza.UserLastModificationId = 1;
                    Cobranza.DateTimeLastModification = DateTime.Now;

                    _cobranzaRepository.Update(Cobranza);
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
                    lblDineroBanco.Text = $@"Dinero en banco = {txtDineroBanco.Value.ToString("N2")}";

                    txtDineroTotal.Value += txtDineroBanco.Value;
                    lblDineroTotal.Text = $@"Dinero total = {txtDineroTotal.Value.ToString("N2")}";
                    
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
                    lblDineroCheque.Text = $@"Dinero en cheque = {txtDineroCheque.Value.ToString("N2")}";

                    txtDineroTotal.Value += txtDineroCheque.Value;
                    lblDineroTotal.Text = $@"Dinero total = {txtDineroTotal.Value.ToString("N2")}";
                    
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
                    lblDineroEfectivo.Text = $@"Dinero en efectivo = {txtDineroEfectivo.Value.ToString("N2")}";

                    txtDineroTotal.Value += txtDineroEfectivo.Value;
                    lblDineroTotal.Text = $@"Dinero total = {txtDineroTotal.Value.ToString("N2")}";
                    
                    btnGuardar.Focus();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
