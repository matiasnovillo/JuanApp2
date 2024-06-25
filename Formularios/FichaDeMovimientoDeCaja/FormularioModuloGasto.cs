using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp2.Formularios.FichaDeMovimientoDeCaja
{
    public partial class FormularioModuloGasto : Form
    {
        private readonly IModuloGastoRepository _modulogastoRepository;
        private readonly int _modulogastoId;

        public FormularioModuloGasto(IServiceProvider serviceProvider,
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
                    Areas.JuanApp2.ModuloGastoBack.Entities.ModuloGasto ModuloGasto = _modulogastoRepository
                                                                        .GetByModuloGastoId(_modulogastoId);

                    DateTimePickerFecha.Value = ModuloGasto.Fecha;
                    txtDescripcion.Text = ModuloGasto.Descripcion;
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
                if (txtDescripcion.Text == "")
                {
                    statusLabel.Text = "Descripción es requerido";
                    return;
                }

                if (_modulogastoId == 0)
                {
                    //Agregar
                    Areas.JuanApp2.ModuloGastoBack.Entities.ModuloGasto ModuloGasto = new()
                    {
                        ModuloGastoId = 0,
                        Active = true,
                        UserCreationId = 1,
                        UserLastModificationId = 1,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        Descripcion = txtDescripcion.Text,
                        Fecha = DateTimePickerFecha.Value,
                        DineroBanco = 0,
                        DineroCheque = 0,
                        DineroEfectivo = 0,
                        DineroTotal = txtDineroTotal.Value
                    };
                    _modulogastoRepository.Add(ModuloGasto);
                }
                else
                {
                    //Actualizar
                    Areas.JuanApp2.ModuloGastoBack.Entities.ModuloGasto ModuloGasto = _modulogastoRepository
                        .GetByModuloGastoId(_modulogastoId);

                    ModuloGasto.Fecha = DateTimePickerFecha.Value;
                    ModuloGasto.Descripcion = txtDescripcion.Text;
                    ModuloGasto.DineroTotal = txtDineroTotal.Value;
                    ModuloGasto.UserLastModificationId = 1;
                    ModuloGasto.DateTimeLastModification = DateTime.Now;

                    _modulogastoRepository.Update(ModuloGasto);
                }

                Hide();
            }
            catch (Exception) { throw; }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtDineroTotal.Focus();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
