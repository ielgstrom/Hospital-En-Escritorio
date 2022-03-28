
namespace WindowsMedicos
{
    partial class FormDeleteUser
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
            this.btnCancelarEliminarPaciente = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.comboBoxPacientes = new System.Windows.Forms.ComboBox();
            this.lblPatientDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarEliminarPaciente
            // 
            this.btnCancelarEliminarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarEliminarPaciente.Location = new System.Drawing.Point(12, 189);
            this.btnCancelarEliminarPaciente.Name = "btnCancelarEliminarPaciente";
            this.btnCancelarEliminarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEliminarPaciente.TabIndex = 6;
            this.btnCancelarEliminarPaciente.Text = "Cancelar";
            this.btnCancelarEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnCancelarEliminarPaciente.Click += new System.EventHandler(this.btnCancelarEliminarPaciente_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarPaciente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(99, 189);
            this.btnEliminarPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPaciente.TabIndex = 5;
            this.btnEliminarPaciente.Text = "Eliminar";
            this.btnEliminarPaciente.UseVisualStyleBackColor = false;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // comboBoxPacientes
            // 
            this.comboBoxPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPacientes.FormattingEnabled = true;
            this.comboBoxPacientes.Location = new System.Drawing.Point(45, 60);
            this.comboBoxPacientes.Name = "comboBoxPacientes";
            this.comboBoxPacientes.Size = new System.Drawing.Size(94, 21);
            this.comboBoxPacientes.TabIndex = 7;
            // 
            // lblPatientDelete
            // 
            this.lblPatientDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatientDelete.AutoSize = true;
            this.lblPatientDelete.Location = new System.Drawing.Point(42, 33);
            this.lblPatientDelete.Name = "lblPatientDelete";
            this.lblPatientDelete.Size = new System.Drawing.Size(97, 13);
            this.lblPatientDelete.TabIndex = 8;
            this.lblPatientDelete.Text = "Paciente a Eliminar";
            // 
            // FormDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 221);
            this.Controls.Add(this.lblPatientDelete);
            this.Controls.Add(this.comboBoxPacientes);
            this.Controls.Add(this.btnCancelarEliminarPaciente);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Name = "FormDeleteUser";
            this.Text = "FormDeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarEliminarPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.ComboBox comboBoxPacientes;
        private System.Windows.Forms.Label lblPatientDelete;
    }
}