using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Empleados : Form
    {
        CN_Empleado empleadoCN = new CN_Empleado();
        private string idEmpleado = null;
        private bool Editar = false;

        public Empleados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAreas();
            CargarTipoDocumentos();
            CargarEmpleados();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            int GetindexArea = CbArea.SelectedIndex + 1;
            int GetindexTipo = CbTipoDoc.SelectedIndex + 1;
            DateTime fechaSeleccionada = DtFecha.Value.Date;

            if (!ValidarCampos())
            {
                return;
            }

            if (Editar == false)
            {
                try
                {

                    empleadoCN.AgregarEmpleado(
                        GetindexTipo,
                        TxtDocumento.Text.Trim(),
                        TxtPrimerNombre.Text.Trim(),
                        TxtSegundoNombre.Text.Trim(),
                        TxtPrimerApellido.Text.Trim(),
                        TxtSegundoApellido.Text.Trim(),
                        fechaSeleccionada,
                        GetindexArea
                    );
                    MessageBox.Show("Datos Agregados correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
                    LimpiarText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo Fallo " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (Editar == true)
            {
                empleadoCN.EditarEmpleado(
                    GetindexTipo,
                    TxtDocumento.Text.Trim(),
                    TxtPrimerNombre.Text.Trim(),
                    TxtSegundoNombre.Text.Trim(),
                    TxtPrimerApellido.Text.Trim(),
                    TxtSegundoApellido.Text.Trim(),
                    fechaSeleccionada,
                    GetindexArea,
                    idEmpleado
                );
                MessageBox.Show("se edito correctamente");
                CargarEmpleados();
                LimpiarText();
                Editar = false;

            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DvEmpleado.SelectedRows.Count > 0)
            {
                idEmpleado = DvEmpleado.CurrentRow.Cells[0].Value.ToString();
                empleadoCN.EliminarEmpleado(idEmpleado);
                MessageBox.Show("Empleado Eliminado Correctamente");
                CargarEmpleados();

            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(DvEmpleado.SelectedRows.Count > 0)
            {
                Editar = true;
                CbTipoDoc.Text = DvEmpleado.CurrentRow.Cells["Tipo documento"].Value.ToString();
                TxtDocumento.Text = DvEmpleado.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
                TxtPrimerNombre.Text = DvEmpleado.CurrentRow.Cells["PrimerNombre"].Value.ToString();
                TxtSegundoNombre.Text = DvEmpleado.CurrentRow.Cells["SegundoNombre"].Value.ToString();
                TxtPrimerApellido.Text = DvEmpleado.CurrentRow.Cells["PrimerApellido"].Value.ToString();
                TxtSegundoApellido.Text = DvEmpleado.CurrentRow.Cells["SegundoNombre"].Value.ToString();
                DtFecha.Text = DvEmpleado.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                CbArea.Text =DvEmpleado.CurrentRow.Cells["NombreArea"].Value.ToString();
                idEmpleado = DvEmpleado.CurrentRow.Cells["IdEmpleado"].Value.ToString();
            }
            else  MessageBox.Show("seleccione una fila por favor");

        }

        #region MisMetodos
        private void CargarAreas()
        {
            CN_AreaTrabajo areas = new CN_AreaTrabajo();
            CbArea.DataSource = areas.MostraAreasTrabajo();
            CbArea.DisplayMember = "NombreArea";
            CbArea.ValueMember = "IdArea";

        }
        private void CargarTipoDocumentos()
        {

            CN_TipoDocumento tipoDocumento = new CN_TipoDocumento();
            CbTipoDoc.DataSource = tipoDocumento.MostrarTipoDocumento();
            CbTipoDoc.DisplayMember = "NombreTipo";
            CbTipoDoc.ValueMember = "IdTipoDocumento";

        }

        private void CargarEmpleados()
        {
            CN_Empleado empleado = new CN_Empleado();
            DvEmpleado.DataSource = empleado.MostrarEmpleado();
        }

        private void LimpiarText()
        {
            TxtDocumento.Clear();
            TxtPrimerNombre.Clear();
            TxtSegundoNombre.Clear();
            TxtPrimerApellido.Clear();
            TxtSegundoApellido.Clear();
            DtFecha.Value = DateTime.Now;

        }

        private bool ValidarCampos()
        {
            // Verificar que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(TxtDocumento.Text.Trim()) ||
                string.IsNullOrWhiteSpace(TxtPrimerNombre.Text.Trim()) ||
                string.IsNullOrWhiteSpace(TxtPrimerApellido.Text.Trim()))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        #endregion

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarText();
        }

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla si no es válida
            }
        }
    }
}
