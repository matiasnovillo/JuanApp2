using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp2.Formularios.FichaDeMovimientoDeCaja
{
    public partial class FormularioModuloVario : Form
    {
        private readonly IModuloVarioRepository _modulovarioRepository;
        private readonly int _modulovarioId;

        public FormularioModuloVario(IServiceProvider serviceProvider,
            int modulovarioId)
        {
            try
            {
                _modulovarioRepository = serviceProvider.GetRequiredService<IModuloVarioRepository>();

                _modulovarioId = modulovarioId;

                InitializeComponent();

                DateTimePickerFecha.Value = DateTime.Now;

                optHaber.Checked = true;
                optDebe.Checked = false;

                if (_modulovarioId > 0)
                {
                    JuanApp2.Areas.JuanApp2.ModuloVarioBack.Entities.ModuloVario ModuloVario = _modulovarioRepository
                                                                        .GetByModuloVarioId(_modulovarioId);

                    DateTimePickerFecha.Value = ModuloVario.Fecha;
                    txtDescripcion.Text = ModuloVario.Descripcion;
                    txtDineroBanco.Value = ModuloVario.DineroBanco;
                    txtDineroCheque.Value = ModuloVario.DineroCheque;
                    txtDineroEfectivo.Value = ModuloVario.DineroEfectivo;
                    txtDineroTotal.Value = ModuloVario.DineroTotal;
                    if (ModuloVario.DebeOHaber == true)
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
                decimal DineroTotalDeSuma = txtDineroBanco.Value + txtDineroCheque.Value + txtDineroEfectivo.Value;

                if (DineroTotalDeSuma != txtDineroTotal.Value)
                {
                    statusLabel.Text = "la suma de cada dinero no coincide con el total";
                    return;
                }

                if (_modulovarioId == 0)
                {
                    //Agregar
                    JuanApp2.Areas.JuanApp2.ModuloVarioBack.Entities.ModuloVario ModuloVario = new()
                    {
                        ModuloVarioId = 0,
                        Active = true,
                        UserCreationId = 1,
                        UserLastModificationId = 1,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        Descripcion = txtDescripcion.Text,
                        Fecha = DateTimePickerFecha.Value,
                        DineroBanco = txtDineroBanco.Value,
                        DineroCheque = txtDineroCheque.Value,
                        DineroEfectivo = txtDineroEfectivo.Value,
                        DineroTotal = txtDineroTotal.Value,
                        DebeOHaber = optDebe.Checked == true ? true : false
                    };
                    _modulovarioRepository.Add(ModuloVario);
                }
                else
                {
                    //Actualizar
                    JuanApp2.Areas.JuanApp2.ModuloVarioBack.Entities.ModuloVario ModuloVario = _modulovarioRepository
                        .GetByModuloVarioId(_modulovarioId);

                    ModuloVario.Fecha = DateTimePickerFecha.Value;
                    ModuloVario.DebeOHaber = optDebe.Checked == true ? true : false;
                    ModuloVario.Descripcion = txtDescripcion.Text;
                    ModuloVario.DineroBanco = txtDineroBanco.Value;
                    ModuloVario.DineroCheque = txtDineroCheque.Value;
                    ModuloVario.DineroEfectivo = txtDineroEfectivo.Value;
                    ModuloVario.DineroTotal = txtDineroTotal.Value;
                    ModuloVario.UserLastModificationId = 1;
                    ModuloVario.DateTimeLastModification = DateTime.Now;

                    _modulovarioRepository.Update(ModuloVario);
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

        private void txtDineroCheque_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
