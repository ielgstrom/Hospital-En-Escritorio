
namespace WindowsMedicos
{
    partial class FormListPatientsOfDoctor
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
            this.lblListDctrs = new System.Windows.Forms.Label();
            this.comboBoxDoctors = new System.Windows.Forms.ComboBox();
            this.btnCancelarSeePatients = new System.Windows.Forms.Button();
            this.richtxtPacientesMed = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListDctrs
            // 
            this.lblListDctrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblListDctrs.AutoSize = true;
            this.lblListDctrs.Location = new System.Drawing.Point(23, 20);
            this.lblListDctrs.Name = "lblListDctrs";
            this.lblListDctrs.Size = new System.Drawing.Size(87, 13);
            this.lblListDctrs.TabIndex = 12;
            this.lblListDctrs.Text = "Lista de Medicos";
            // 
            // comboBoxDoctors
            // 
            this.comboBoxDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxDoctors.FormattingEnabled = true;
            this.comboBoxDoctors.Location = new System.Drawing.Point(26, 47);
            this.comboBoxDoctors.Name = "comboBoxDoctors";
            this.comboBoxDoctors.Size = new System.Drawing.Size(146, 21);
            this.comboBoxDoctors.TabIndex = 11;
            this.comboBoxDoctors.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctors_SelectedIndexChanged);
            // 
            // btnCancelarSeePatients
            // 
            this.btnCancelarSeePatients.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelarSeePatients.Location = new System.Drawing.Point(108, 273);
            this.btnCancelarSeePatients.Name = "btnCancelarSeePatients";
            this.btnCancelarSeePatients.Size = new System.Drawing.Size(83, 23);
            this.btnCancelarSeePatients.TabIndex = 10;
            this.btnCancelarSeePatients.Text = "Cerrar";
            this.btnCancelarSeePatients.UseVisualStyleBackColor = true;
            this.btnCancelarSeePatients.Click += new System.EventHandler(this.btnCancelarSeePatients_Click);
            // 
            // richtxtPacientesMed
            // 
            this.richtxtPacientesMed.Location = new System.Drawing.Point(26, 124);
            this.richtxtPacientesMed.Name = "richtxtPacientesMed";
            this.richtxtPacientesMed.ReadOnly = true;
            this.richtxtPacientesMed.Size = new System.Drawing.Size(257, 131);
            this.richtxtPacientesMed.TabIndex = 13;
            this.richtxtPacientesMed.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Listado de pacientes";
            // 
            // FormListPatientsOfDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtxtPacientesMed);
            this.Controls.Add(this.lblListDctrs);
            this.Controls.Add(this.comboBoxDoctors);
            this.Controls.Add(this.btnCancelarSeePatients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormListPatientsOfDoctor";
            this.Text = "FormListPatientsOfDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListDctrs;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private System.Windows.Forms.Button btnCancelarSeePatients;
        private System.Windows.Forms.RichTextBox richtxtPacientesMed;
        private System.Windows.Forms.Label label1;
    }
}