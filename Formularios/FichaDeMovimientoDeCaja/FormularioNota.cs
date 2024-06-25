using JuanApp2.Areas.JuanApp2.NotaBack.Entities;
using JuanApp2.Areas.JuanApp2.NotaBack.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp2.Formularios.FichaDeMovimientoDeCaja
{
    public partial class FormularioNota : Form
    {
        private readonly INotaRepository _notaRepository;
        private readonly ServiceProvider _serviceProvider;

        public FormularioNota(ServiceProvider serviceProvider)
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            _serviceProvider = serviceProvider;

            _notaRepository = serviceProvider.GetRequiredService<INotaRepository>();

            Nota Nota1 = _notaRepository.GetNota1();
            Nota Nota2 = _notaRepository.GetNota2();
            Nota Nota3 = _notaRepository.GetNota3();
            Nota Nota4 = _notaRepository.GetNota4();

            txtNota1.Text = Nota1.Nota1;
            txtNota2.Text = Nota2.Nota2;
            txtNota3.Text = Nota3.Nota3;
            txtNota4.Text = Nota4.Nota4;
        }

        private void btnGuardarNota1_Click(object sender, EventArgs e)
        {
            Nota Nota1 = _notaRepository.GetNota1();
            Nota1.Nota1 = txtNota1.Text;
            Nota1.DateTimeLastModification = DateTime.Now;
            Nota1.UserLastModificationId = 1;

            _notaRepository.UpdateNota1(Nota1);
        }

        private void btnGuardarNota2_Click(object sender, EventArgs e)
        {
            Nota Nota2 = _notaRepository.GetNota2();
            Nota2.Nota2 = txtNota2.Text;
            Nota2.DateTimeLastModification = DateTime.Now;
            Nota2.UserLastModificationId = 1;

            _notaRepository.UpdateNota2(Nota2);
        }

        private void btnGurdarNota3_Click(object sender, EventArgs e)
        {
            Nota Nota3 = _notaRepository.GetNota3();
            Nota3.Nota3 = txtNota3.Text;
            Nota3.DateTimeLastModification = DateTime.Now;
            Nota3.UserLastModificationId = 1;

            _notaRepository.UpdateNota3(Nota3);
        }

        private void btnGuardarNota4_Click(object sender, EventArgs e)
        {
            Nota Nota4 = _notaRepository.GetNota4();
            Nota4.Nota4 = txtNota4.Text;
            Nota4.DateTimeLastModification = DateTime.Now;
            Nota4.UserLastModificationId = 1;

            _notaRepository.UpdateNota4(Nota4);
        }

        private void btnBorrarTodoNota1_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
        }

        private void btnBorrarTodoNota2_Click(object sender, EventArgs e)
        {
            txtNota2.Text = "";
        }

        private void btnBorrarTodoNota3_Click(object sender, EventArgs e)
        {
            txtNota3.Text = "";
        }

        private void btnBorrarTodoNota4_Click(object sender, EventArgs e)
        {
            txtNota4.Text = "";
        }
    }
}
