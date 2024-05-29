using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using JuanApp.Areas.JuanApp.Entities;

namespace JuanApp.Formularios.Herramientas.Remito
{
    public partial class FormularioRemito : Form
    {
        private readonly IRemitoRepository _remitoRepository;
        private readonly IRemitoService _remitoService;
        private readonly int _remitoId;

        public FormularioRemito(IRemitoRepository remitoRepository,
            IRemitoService remitoService,
            int RemitoId)
        {
            try
            {
                _remitoRepository = remitoRepository;
                _remitoService = remitoService;
                _remitoId = RemitoId;

                InitializeComponent();

                if (RemitoId > 0)
                {
                    Areas.JuanApp.Entities.Remito Remito = _remitoRepository.GetByRemitoId(RemitoId);
                    
                    DateTimePickerFechaDeEmision.Value = Remito.Fecha;
                    NumericUpDownKilosTotales.Value = Remito.KilosTotales;
                    NumericUpDownPrecioTotal.Value = Remito.PrecioTotal;
                    NumericUpDownSubtotalTotal.Value = Remito.SubtotalTotal;
                    txtCodigoCliente.Text = Remito.CodigoCliente;
                    txtNombreCliente.Text = Remito.NombreCliente;
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
                if (NumericUpDownKilosTotales.Value == 0 ||
                    NumericUpDownPrecioTotal.Value == 0 ||
                    NumericUpDownSubtotalTotal.Value == 0 ||
                    txtCodigoCliente.Text == "" ||
                    txtNombreCliente.Text == "")
                {
                    statusLabel.Text = "Faltan datos a completar";
                }
                else
                {
                    if (_remitoId == 0)
                    {
                        //Agregar
                        Areas.JuanApp.Entities.Remito Remito = new()
                        {
                            RemitoId = _remitoId,
                            Active = true,
                            UserCreationId = 1,
                            UserLastModificationId = 1,
                            DateTimeCreation = DateTime.Now,
                            DateTimeLastModification = DateTime.Now,
                            Fecha = DateTimePickerFechaDeEmision.Value,
                            KilosTotales = NumericUpDownKilosTotales.Value,
                            PrecioTotal = NumericUpDownPrecioTotal.Value,
                            SubtotalTotal = NumericUpDownSubtotalTotal.Value,
                            CodigoCliente = txtCodigoCliente.Text,
                            NombreCliente = txtNombreCliente.Text
                        };
                        _remitoRepository.Add(Remito);
                    }
                    else
                    {
                        //Actualizar
                        Areas.JuanApp.Entities.Remito Remito = _remitoRepository.GetByRemitoId(_remitoId);

                        Remito.Fecha = DateTimePickerFechaDeEmision.Value;
                        Remito.KilosTotales = NumericUpDownKilosTotales.Value;
                        Remito.PrecioTotal = NumericUpDownPrecioTotal.Value;
                        Remito.SubtotalTotal = NumericUpDownSubtotalTotal.Value;
                        Remito.CodigoCliente = txtCodigoCliente.Text;
                        Remito.NombreCliente = txtNombreCliente.Text;

                        Remito.UserLastModificationId = 1;
                        Remito.DateTimeLastModification = DateTime.Now;

                        _remitoRepository.Update(Remito);
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
