
namespace WindowsMedicos
{
    partial class FormNewPersona
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdadPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.btnCancelarMedico = new System.Windows.Forms.Button();
            this.btnAñadirMedico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Añadir Paciente";
            // 
            // txtEdadPaciente
            // 
            this.txtEdadPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdadPaciente.Location = new System.Drawing.Point(216, 115);
            this.txtEdadPaciente.Name = "txtEdadPaciente";
            this.txtEdadPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtEdadPaciente.TabIndex = 15;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombrePaciente.Location = new System.Drawing.Point(216, 80);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePaciente.TabIndex = 14;
            // 
            // btnCancelarMedico
            // 
            this.btnCancelarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarMedico.Location = new System.Drawing.Point(225, 200);
            this.btnCancelarMedico.Name = "btnCancelarMedico";
            this.btnCancelarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMedico.TabIndex = 13;
            this.btnCancelarMedico.Text = "Cancelar";
            this.btnCancelarMedico.UseVisualStyleBackColor = true;
            this.btnCancelarMedico.Click += new System.EventHandler(this.btnCancelarMedico_Click);
            // 
            // btnAñadirMedico
            // 
            this.btnAñadirMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadirMedico.BackColor = System.Drawing.SystemColors.Control;
            this.btnAñadirMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAñadirMedico.Location = new System.Drawing.Point(303, 200);
            this.btnAñadirMedico.Margin = new System.Windows.Forms.Padding(0);
            this.btnAñadirMedico.Name = "btnAñadirMedico";
            this.btnAñadirMedico.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirMedico.TabIndex = 12;
            this.btnAñadirMedico.Text = "Añadir";
            this.btnAñadirMedico.UseVisualStyleBackColor = false;
            this.btnAñadirMedico.Click += new System.EventHandler(this.btnAñadirMedico_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Edad Paciente";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Medico a Asignar";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre Paciente";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(217, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // FormNewPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 232);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdadPaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.btnCancelarMedico);
            this.Controls.Add(this.btnAñadirMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNewPersona";
            this.Text = "FormNewPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdadPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Button btnCancelarMedico;
        private System.Windows.Forms.Button btnAñadirMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}