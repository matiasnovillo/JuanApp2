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
                    Areas.JuanApp2.ModuloVarioBack.Entities.ModuloVario ModuloVario = _modulovarioRepository
                                                                        .GetByModuloVarioId(_modulovarioId);

                    DateTimePickerFecha.Value = ModuloVario.Fecha;
                    txtDescripcion.Text = ModuloVario.Descripcion;
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
                if (txtDescripcion.Text == "")
                {
                    statusLabel.Text = "Agregue una descripcion";
                    return;
                }

                if (_modulovarioId == 0)
                {
                    //Agregar
                    Areas.JuanApp2.ModuloVarioBack.Entities.ModuloVario ModuloVario = new()
                    {
                        ModuloVarioId = 0,
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
                        DineroTotal = txtDineroTotal.Value,
                        DebeOHaber = optDebe.Checked == true ? true : false
                    };
                    _modulovarioRepository.Add(ModuloVario);
                }
                else
                {
                    //Actualizar
                    Areas.JuanApp2.ModuloVarioBack.Entities.ModuloVario ModuloVario = _modulovarioRepository
                        .GetByModuloVarioId(_modulovarioId);

                    ModuloVario.Fecha = DateTimePickerFecha.Value;
                    ModuloVario.DebeOHaber = optDebe.Checked == true ? true : false;
                    ModuloVario.Descripcion = txtDescripcion.Text;
                    ModuloVario.DineroTotal = txtDineroTotal.Value;
                    ModuloVario.UserLastModificationId = 1;
                    ModuloVario.DateTimeLastModification = DateTime.Now;

                    _modulovarioRepository.Update(ModuloVario);
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
