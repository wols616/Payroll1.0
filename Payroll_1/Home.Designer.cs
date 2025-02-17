namespace Payroll_1
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDeducciones = new Button();
            btnAsignarDeducciones = new Button();
            SuspendLayout();
            // 
            // btnDeducciones
            // 
            btnDeducciones.Location = new Point(349, 331);
            btnDeducciones.Name = "btnDeducciones";
            btnDeducciones.Size = new Size(147, 23);
            btnDeducciones.TabIndex = 0;
            btnDeducciones.Text = "Agregar Deducciones";
            btnDeducciones.UseVisualStyleBackColor = true;
            btnDeducciones.Click += btnDeducciones_Click;
            // 
            // btnAsignarDeducciones
            // 
            btnAsignarDeducciones.Location = new Point(349, 288);
            btnAsignarDeducciones.Name = "btnAsignarDeducciones";
            btnAsignarDeducciones.Size = new Size(147, 23);
            btnAsignarDeducciones.TabIndex = 1;
            btnAsignarDeducciones.Text = "Nomina";
            btnAsignarDeducciones.UseVisualStyleBackColor = true;
            btnAsignarDeducciones.Click += btnAsignarDeducciones_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAsignarDeducciones);
            Controls.Add(btnDeducciones);
            Name = "Home";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeducciones;
        private Button btnAsignarDeducciones;
    }
}
