﻿using JuanApp.Formularios;
using Microsoft.Extensions.DependencyInjection;
using JuanApp2.Areas.System.FailureBack.Entities;
using JuanApp2.Areas.System.FailureBack.Interfaces;
using JuanApp.Formularios.Entrada;

namespace JuanApp
{
    public partial class Main : Form
    {
        private readonly ServiceProvider _serviceProvider;

        private readonly IFailureRepository _failureRepository;


        public Main(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _failureRepository = serviceProvider.GetRequiredService<IFailureRepository>();

            InitializeComponent();

            statusLabel.Text = "";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripButtonAcercaDe_Click(object sender, EventArgs e)
        {
            try
            {
                AcercaDe AcercaDe = new AcercaDe();
                AcercaDe.ShowDialog();
            }
            catch (Exception ex)
            {
                Failure Failure = new Failure()
                {
                    FailureId = 0,
                    Active = true,
                    UserCreationId = 1,
                    UserLastModificationId = 1,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    Message = ex.Message,
                    EmergencyLevel = 1,
                    StackTrace = ex.StackTrace,
                    Source = ex.Source,
                    Comment = ""
                };
                _failureRepository.Add(Failure);

                MessageBox.Show($@"Error: {ex.Message}", "Error");
            }
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
        }

        private void btnCobradores_Click(object sender, EventArgs e)
        {
            ConsultaCobrador ConsultaCobrador = new(_serviceProvider);

            ConsultaCobrador.ShowDialog();
        }

        private void btnCobranza_Click(object sender, EventArgs e)
        {
            ConsultaCobranza ConsultaCobranza = new(_serviceProvider);

            ConsultaCobranza.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ConsultaProveedor ConsultaProveedor = new(_serviceProvider);

            ConsultaProveedor.ShowDialog();
        }

        private void btnProveedorMain_Click(object sender, EventArgs e)
        {
            ConsultaProveedorMain ConsultaProveedorMain = new(_serviceProvider);

            ConsultaProveedorMain.ShowDialog();
        }
    }
}
