using JuanApp2.Areas.JuanApp2.CobradorBack.Entities;
using JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Entrada
{
    public partial class FormularioVario : Form
    {
        private readonly IModuloVarioRepository _modulovarioRepository;
        private readonly int _modulovarioId;

        public FormularioVario(IServiceProvider serviceProvider,
            int modulovarioId)
        {
            try
            {
                _modulovarioRepository = serviceProvider.GetRequiredService<IModuloVarioRepository>();

                _modulovarioId = modulovarioId;

                InitializeComponent();

                DateTimePickerFecha.Value = DateTime.Now;

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
                        DineroTotal = txtDineroTotal.Value
                    };
                    _modulovarioRepository.Add(ModuloVario);
                }
                else
                {
                    //Actualizar
                    JuanApp2.Areas.JuanApp2.ModuloVarioBack.Entities.ModuloVario ModuloVario = _modulovarioRepository
                        .GetByModuloVarioId(_modulovarioId);

                    ModuloVario.Fecha = DateTimePickerFecha.Value;
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
                    txtDineroTotal.Value += txtDineroBanco.Value;
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
                    txtDineroTotal.Value += txtDineroCheque.Value;
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
                    txtDineroTotal.Value += txtDineroEfectivo.Value;
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
    }
}
