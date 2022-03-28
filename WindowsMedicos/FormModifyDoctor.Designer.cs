
namespace WindowsMedicos
{
    partial class FormModifyDoctor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModEspecMedico = new System.Windows.Forms.TextBox();
            this.txtEdadModMedico = new System.Windows.Forms.TextBox();
            this.txtNombreModMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarModifyPaciente = new System.Windows.Forms.Button();
            this.btnModifyPaciente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtModEspecMedico);
            this.groupBox1.Controls.Add(this.txtEdadModMedico);
            this.groupBox1.Controls.Add(this.txtNombreModMedico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 148);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medico";
            // 
            // txtModEspecMedico
            // 
            this.txtModEspecMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModEspecMedico.Location = new System.Drawing.Point(186, 99);
            this.txtModEspecMedico.Name = "txtModEspecMedico";
            this.txtModEspecMedico.Size = new System.Drawing.Size(100, 20);
            this.txtModEspecMedico.TabIndex = 26;
            // 
            // txtEdadModMedico
            // 
            this.txtEdadModMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdadModMedico.Location = new System.Drawing.Point(186, 64);
            this.txtEdadModMedico.Name = "txtEdadModMedico";
            this.txtEdadModMedico.Size = new System.Drawing.Size(100, 20);
            this.txtEdadModMedico.TabIndex = 25;
            // 
            // txtNombreModMedico
            // 
            this.txtNombreModMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreModMedico.Location = new System.Drawing.Point(186, 29);
            this.txtNombreModMedico.Name = "txtNombreModMedico";
            this.txtNombreModMedico.Size = new System.Drawing.Size(100, 20);
            this.txtNombreModMedico.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Edad Medico";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Especialidad Medico";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre Medico";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(157, 88);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(220, 21);
            this.comboBoxDoctor.TabIndex = 35;
            this.comboBoxDoctor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Medico a modificar";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 39);
            this.label4.TabIndex = 33;
            this.label4.Text = "Modificar Medico";
            // 
            // btnCancelarModifyPaciente
            // 
            this.btnCancelarModifyPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarModifyPaciente.Location = new System.Drawing.Point(240, 315);
            this.btnCancelarModifyPaciente.Name = "btnCancelarModifyPaciente";
            this.btnCancelarModifyPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModifyPaciente.TabIndex = 32;
            this.btnCancelarModifyPaciente.Text = "Cancelar";
            this.btnCancelarModifyPaciente.UseVisualStyleBackColor = true;
            this.btnCancelarModifyPaciente.Click += new System.EventHandler(this.btnCancelarModifyPaciente_Click);
            // 
            // btnModifyPaciente
            // 
            this.btnModifyPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.btnModifyPaciente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModifyPaciente.Location = new System.Drawing.Point(318, 315);
            this.btnModifyPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.btnModifyPaciente.Name = "btnModifyPaciente";
            this.btnModifyPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnModifyPaciente.TabIndex = 31;
            this.btnModifyPaciente.Text = "Modificar";
            this.btnModifyPaciente.UseVisualStyleBackColor = false;
            this.btnModifyPaciente.Click += new System.EventHandler(this.btnModifyPaciente_Click);
            // 
            // FormModifyDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelarModifyPaciente);
            this.Controls.Add(this.btnModifyPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormModifyDoctor";
            this.Text = "FormModifyDoctor";
            this.Load += new System.EventHandler(this.FormModifyDoctor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEdadModMedico;
        private System.Windows.Forms.TextBox txtNombreModMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarModifyPaciente;
        private System.Windows.Forms.Button btnModifyPaciente;
        private System.Windows.Forms.TextBox txtModEspecMedico;
    }
}