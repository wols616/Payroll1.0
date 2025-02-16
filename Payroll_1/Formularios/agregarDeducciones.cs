﻿using Payroll_1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_1.Formularios
{
    public partial class agregarDeducciones : Form
    {
        public agregarDeducciones()
        {
            InitializeComponent();
        }

        private void cargarTablaDeducciones()
        {
            dgvDeducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<Deduccion> deducciones = Deduccion.ObtenerDeducciones();
            dgvDeducciones.DataSource = deducciones;
            dgvDeducciones.Columns["IdDeduccion"].Visible = false;
        }
        private void agregarDeducciones_Load(object sender, EventArgs e)
        {
            cargarTablaDeducciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreDeduccion = this.txtNombre.Text;
            decimal porcentaje = Decimal.Parse(this.txtPorcentajee.Text);
            Deduccion deduccion = new Deduccion(nombreDeduccion, porcentaje);
            deduccion.AgregarDeduccion();
            cargarTablaDeducciones();
        }

        private void dgvDeducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    // Obtener los valores de la fila seleccionada
            //    DataGridViewRow row = dgvDeducciones.Rows[e.RowIndex];
            //    txtNombre.Text = row.Cells["NombreDeduccion"].Value.ToString();
            //    txtPorcentaje.Text = row.Cells["Porcentaje"].Value.ToString();
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDeducciones.CurrentRow != null)
            {
                int idDeduccion = Convert.ToInt32(dgvDeducciones.CurrentRow.Cells["IdDeduccion"].Value);
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta deducción?",
                                             "Confirmación de eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    Deduccion.EliminarDeduccion(idDeduccion);
                }
                cargarTablaDeducciones();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idDeduccion = Convert.ToInt32(dgvDeducciones.CurrentRow.Cells["IdDeduccion"].Value);
            string nombreDeduccion = this.txtNombre.Text;
            decimal porcentaje = Decimal.Parse(this.txtPorcentajee.Text);

            Deduccion deduccion = new Deduccion(idDeduccion, nombreDeduccion, porcentaje);
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea actualizar esta deducción?",
                                             "Confirmación de actualización",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
                deduccion.ActualizarDeduccion();
            }
            cargarTablaDeducciones();
        }

        private void dgvDeducciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeducciones.CurrentRow != null)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dgvDeducciones.CurrentRow;
                txtNombre.Text = row.Cells["NombreDeduccion"].Value.ToString();
                txtPorcentajee.Text = row.Cells["Porcentaje"].Value.ToString();
            }
        }
    }
}
