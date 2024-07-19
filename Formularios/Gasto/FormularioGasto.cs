using JuanApp2.Areas.JuanApp2.GastoBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp2.Formularios.Gasto
{
    public partial class FormularioGasto : Form
    {
        private readonly IGastoRepository _gastoRepository;
        private readonly int _gastoId;

        public FormularioGasto(IServiceProvider serviceProvider,
            int gastoId)
        {
            try
            {
                _gastoRepository = serviceProvider.GetRequiredService<IGastoRepository>();

                _gastoId = gastoId;

                InitializeComponent();

                DateTimePickerFecha.Value = DateTime.Now;
                txtImporte.Value = 0;

                if (_gastoId > 0)
                {
                    Areas.JuanApp2.GastoBack.Entities.Gasto Gasto = _gastoRepository
                                                                        .GetByGastoId(_gastoId);

                    txtDescripcion.Text = Gasto.Descripcion;
                    txtImporte.Value = Gasto.Importe;
                    DateTimePickerFecha.Value = Gasto.Fecha;
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
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    statusLabel.Text = "Faltan datos a completar";
                }
                else
                {
                    if (_gastoId == 0)
                    {
                        //Agregar
                        Areas.JuanApp2.GastoBack.Entities.Gasto Gasto = new()
                        {
                            GastoId = 0,
                            Active = true,
                            UserCreationId = 1,
                            UserLastModificationId = 1,
                            DateTimeCreation = DateTime.Now,
                            DateTimeLastModification = DateTime.Now,
                            Descripcion = txtDescripcion.Text,
                            Fecha = DateTimePickerFecha.Value,
                            Importe = txtImporte.Value
                        };
                        _gastoRepository.Add(Gasto);
                    }
                    else
                    {
                        //Actualizar
                        Areas.JuanApp2.GastoBack.Entities.Gasto Gasto = _gastoRepository
                            .GetByGastoId(_gastoId);

                        Gasto.Descripcion = txtDescripcion.Text;
                        Gasto.Fecha = DateTimePickerFecha.Value;
                        Gasto.Importe = txtImporte.Value;
                        Gasto.UserLastModificationId = 1;
                        Gasto.DateTimeLastModification = DateTime.Now;

                        _gastoRepository.Update(Gasto);
                    }

                    Hide();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
