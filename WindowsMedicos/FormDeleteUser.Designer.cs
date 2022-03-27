
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
            this.btnCancelarMedico = new System.Windows.Forms.Button();
            this.btnAñadirMedico = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPatientDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarMedico
            // 
            this.btnCancelarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarMedico.Location = new System.Drawing.Point(12, 189);
            this.btnCancelarMedico.Name = "btnCancelarMedico";
            this.btnCancelarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMedico.TabIndex = 6;
            this.btnCancelarMedico.Text = "Cancelar";
            this.btnCancelarMedico.UseVisualStyleBackColor = true;
            // 
            // btnAñadirMedico
            // 
            this.btnAñadirMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadirMedico.BackColor = System.Drawing.SystemColors.Control;
            this.btnAñadirMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAñadirMedico.Location = new System.Drawing.Point(99, 189);
            this.btnAñadirMedico.Margin = new System.Windows.Forms.Padding(0);
            this.btnAñadirMedico.Name = "btnAñadirMedico";
            this.btnAñadirMedico.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirMedico.TabIndex = 5;
            this.btnAñadirMedico.Text = "Eliminar";
            this.btnAñadirMedico.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 7;
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCancelarMedico);
            this.Controls.Add(this.btnAñadirMedico);
            this.Name = "FormDeleteUser";
            this.Text = "FormDeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarMedico;
        private System.Windows.Forms.Button btnAñadirMedico;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPatientDelete;
    }
}