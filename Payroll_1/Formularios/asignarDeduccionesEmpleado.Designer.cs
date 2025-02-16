namespace Payroll_1.Formularios
{
    partial class asignarDeduccionesEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmpleados = new DataGridView();
            dgvDeducciones = new DataGridView();
            cbxDeducciones = new ComboBox();
            btnAsignar = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(71, 27);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(633, 150);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
            // 
            // dgvDeducciones
            // 
            dgvDeducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeducciones.Location = new Point(71, 215);
            dgvDeducciones.Name = "dgvDeducciones";
            dgvDeducciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeducciones.Size = new Size(408, 150);
            dgvDeducciones.TabIndex = 1;
            // 
            // cbxDeducciones
            // 
            cbxDeducciones.FormattingEnabled = true;
            cbxDeducciones.Location = new Point(583, 215);
            cbxDeducciones.Name = "cbxDeducciones";
            cbxDeducciones.Size = new Size(121, 23);
            cbxDeducciones.TabIndex = 2;
            cbxDeducciones.SelectedValueChanged += cbxDeducciones_SelectedValueChanged;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(583, 342);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(121, 23);
            btnAsignar.TabIndex = 4;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(8, 27);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(37, 36);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "button1";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // asignarDeduccionesEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(btnRegresar);
            Controls.Add(btnAsignar);
            Controls.Add(cbxDeducciones);
            Controls.Add(dgvDeducciones);
            Controls.Add(dgvEmpleados);
            Name = "asignarDeduccionesEmpleado";
            Text = "asignarDeduccionesEmpleado";
            Load += asignarDeduccionesEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private DataGridView dgvDeducciones;
        private ComboBox cbxDeducciones;
        private Button btnAsignar;
        private Button btnRegresar;
    }
}