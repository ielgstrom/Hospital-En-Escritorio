
namespace WindowsMedicos
{
    partial class FormModifyPaciente
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
            this.comboBoxModPaciente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdadModPaciente = new System.Windows.Forms.TextBox();
            this.txtNombreModPaciente = new System.Windows.Forms.TextBox();
            this.btnCancelarModifyPaciente = new System.Windows.Forms.Button();
            this.btnModifyPaciente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxModPaciente
            // 
            this.comboBoxModPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxModPaciente.FormattingEnabled = true;
            this.comboBoxModPaciente.Location = new System.Drawing.Point(187, 96);
            this.comboBoxModPaciente.Name = "comboBoxModPaciente";
            this.comboBoxModPaciente.Size = new System.Drawing.Size(100, 21);
            this.comboBoxModPaciente.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 39);
            this.label4.TabIndex = 26;
            this.label4.Text = "Modificar Paciente";
            // 
            // txtEdadModPaciente
            // 
            this.txtEdadModPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdadModPaciente.Location = new System.Drawing.Point(186, 64);
            this.txtEdadModPaciente.Name = "txtEdadModPaciente";
            this.txtEdadModPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtEdadModPaciente.TabIndex = 25;
            // 
            // txtNombreModPaciente
            // 
            this.txtNombreModPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreModPaciente.Location = new System.Drawing.Point(186, 29);
            this.txtNombreModPaciente.Name = "txtNombreModPaciente";
            this.txtNombreModPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreModPaciente.TabIndex = 24;
            // 
            // btnCancelarModifyPaciente
            // 
            this.btnCancelarModifyPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarModifyPaciente.Location = new System.Drawing.Point(277, 296);
            this.btnCancelarModifyPaciente.Name = "btnCancelarModifyPaciente";
            this.btnCancelarModifyPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModifyPaciente.TabIndex = 23;
            this.btnCancelarModifyPaciente.Text = "Cancelar";
            this.btnCancelarModifyPaciente.UseVisualStyleBackColor = true;
            this.btnCancelarModifyPaciente.Click += new System.EventHandler(this.btnCancelarModifyPaciente_Click);
            // 
            // btnModifyPaciente
            // 
            this.btnModifyPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.btnModifyPaciente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModifyPaciente.Location = new System.Drawing.Point(356, 296);
            this.btnModifyPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.btnModifyPaciente.Name = "btnModifyPaciente";
            this.btnModifyPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnModifyPaciente.TabIndex = 22;
            this.btnModifyPaciente.Text = "Modificar";
            this.btnModifyPaciente.UseVisualStyleBackColor = false;
            this.btnModifyPaciente.Click += new System.EventHandler(this.btnModifyPaciente_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Edad Paciente";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Medico Asignado";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre Paciente";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Paciente a modificar";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.comboBoxModPaciente);
            this.groupBox1.Controls.Add(this.txtEdadModPaciente);
            this.groupBox1.Controls.Add(this.txtNombreModPaciente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(69, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 148);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente";
            // 
            // FormModifyPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 328);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelarModifyPaciente);
            this.Controls.Add(this.btnModifyPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormModifyPaciente";
            this.Text = "FormModifyPaciente";
            this.Load += new System.EventHandler(this.FormModifyPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxModPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdadModPaciente;
        private System.Windows.Forms.TextBox txtNombreModPaciente;
        private System.Windows.Forms.Button btnCancelarModifyPaciente;
        private System.Windows.Forms.Button btnModifyPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}