using JuanApp2.Areas.JuanApp2.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Entrada
{
    public partial class FormularioCaja : Form
    {
        private readonly ICajaRepository _cajaRepository;
        private readonly int _cajaId;

        public FormularioCaja(IServiceProvider serviceProvider,
            int cajaId)
        {
            try
            {
                _cajaRepository = serviceProvider.GetRequiredService<ICajaRepository>();

                _cajaId = cajaId;

                InitializeComponent();

                if (cajaId > 0)
                {
                    JuanApp2.Areas.JuanApp2.Entities.Caja Caja = _cajaRepository
                                                                        .GetByCajaId(cajaId);

                    //txtNroDePesada.Text = Entrada.NroDePesaje.ToString();
                    //txtCodigoDeProducto.Text = Entrada.CodigoDeProducto;
                    //txtNombreDeProducto.Text = Entrada.NombreDeProducto;
                    //txtTexContenido.Text = Entrada.TexContenido.ToString();
                    //numericUpDownNeto.Value = Entrada.Neto;

                    //txtNroDePesada.Enabled = false;
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
                //if (string.IsNullOrEmpty(txtNroDePesada.Text) ||
                //       string.IsNullOrEmpty(txtCodigoDeProducto.Text) ||
                //       string.IsNullOrEmpty(txtTexContenido.Text) ||
                //       numericUpDownNeto.Value == 0 ||
                //       string.IsNullOrEmpty(txtNombreDeProducto.Text))
                //{
                //    statusLabel.Text = "Faltan datos a completar";
                //}
                //else
                //{
                //    if (_entradaId == 0)
                //    {
                //        //Agregar
                //        JuanApp.Areas.JuanApp.Entities.Entrada EntradaTest = _entradaRepository
                //            .AsQueryable()
                //            .Where(x => x.NroDePesaje == Convert.ToInt32(txtNroDePesada.Text))
                //            .FirstOrDefault();

                //        if (EntradaTest == null)
                //        {
                //            Areas.JuanApp.Entities.Entrada Entrada = new()
                //            {
                //                EntradaId = _entradaId,
                //                Active = true,
                //                UserCreationId = 1,
                //                UserLastModificationId = 1,
                //                DateTimeCreation = DateTime.Now,
                //                DateTimeLastModification = DateTime.Now,
                //                CodigoDeBarra = "",
                //                NroDePesaje = Convert.ToInt32(txtNroDePesada.Text),
                //                CodigoDeProducto = txtCodigoDeProducto.Text,
                //                NombreDeProducto = txtNombreDeProducto.Text,
                //                TexContenido = Convert.ToInt32(txtTexContenido.Text),
                //                Neto = numericUpDownNeto.Value
                //            };
                //            _entradaRepository.Add(Entrada);
                //        }
                //        else
                //        {
                //            MessageBox.Show("Este Nº de pesaje ya existe en el sistema. No se guardará como nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        }

                //    }
                //    else
                //    {
                //        //Actualizar
                //        Areas.JuanApp.Entities.Entrada Entrada = _entradaRepository.GetByEntradaId(_entradaId);

                //        Entrada.NroDePesaje = Convert.ToInt32(txtNroDePesada.Text);
                //        Entrada.CodigoDeProducto = txtCodigoDeProducto.Text;
                //        Entrada.NombreDeProducto = txtNombreDeProducto.Text;
                //        Entrada.TexContenido = Convert.ToInt32(txtTexContenido.Text);
                //        Entrada.Neto = numericUpDownNeto.Value;
                //        Entrada.UserLastModificationId = 1;
                //        Entrada.DateTimeLastModification = DateTime.Now;

                //        _entradaRepository.Update(Entrada);
                //    }

                //    Hide();
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
