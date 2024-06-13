using JuanApp2.Areas.JuanApp2.CobradorBack.Entities;
using JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Entrada
{
    public partial class FormularioGasto : Form
    {
        private readonly IModuloGastoRepository _modulogastoRepository;
        private readonly int _modulogastoId;

        public FormularioGasto(IServiceProvider serviceProvider,
            int modulogastoId)
        {
            try
            {
                _modulogastoRepository = serviceProvider.GetRequiredService<IModuloGastoRepository>();

                _modulogastoId = modulogastoId;

                InitializeComponent();

                DateTimePickerFecha.Value = DateTime.Now;

                if (_modulogastoId > 0)
                {
                    JuanApp2.Areas.JuanApp2.ModuloGastoBack.Entities.ModuloGasto ModuloGasto = _modulogastoRepository
                                                                        .GetByModuloGastoId(_modulogastoId);

                    DateTimePickerFecha.Value = ModuloGasto.Fecha;
                    txtDescripcion.Text = ModuloGasto.Descripcion;
                    txtDineroBanco.Value = ModuloGasto.DineroBanco;
                    txtDineroCheque.Value = ModuloGasto.DineroCheque;
                    txtDineroEfectivo.Value = ModuloGasto.DineroEfectivo;
                    txtDineroTotal.Value = ModuloGasto.DineroTotal;
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

                if (_modulogastoId == 0)
                {
                    //Agregar
                    JuanApp2.Areas.JuanApp2.ModuloGastoBack.Entities.ModuloGasto ModuloGasto = new()
                    {
                        ModuloGastoId = 0,
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
                    _modulogastoRepository.Add(ModuloGasto);
                }
                else
                {
                    //Actualizar
                    JuanApp2.Areas.JuanApp2.ModuloGastoBack.Entities.ModuloGasto ModuloGasto = _modulogastoRepository
                        .GetByModuloGastoId(_modulogastoId);

                    ModuloGasto.Fecha = DateTimePickerFecha.Value;
                    ModuloGasto.Descripcion = txtDescripcion.Text;
                    ModuloGasto.DineroBanco = txtDineroBanco.Value;
                    ModuloGasto.DineroCheque = txtDineroCheque.Value;
                    ModuloGasto.DineroEfectivo = txtDineroEfectivo.Value;
                    ModuloGasto.DineroTotal = txtDineroTotal.Value;
                    ModuloGasto.UserLastModificationId = 1;
                    ModuloGasto.DateTimeLastModification = DateTime.Now;

                    _modulogastoRepository.Update(ModuloGasto);
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
