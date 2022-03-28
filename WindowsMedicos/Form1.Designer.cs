
namespace WindowsMedicos
{
    partial class FormInscripcion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnMasPaciente = new System.Windows.Forms.Button();
            this.butnlistmedicos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModMedico = new System.Windows.Forms.Button();
            this.btnModifyPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Añadir Medico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMasPaciente
            // 
            this.btnMasPaciente.AllowDrop = true;
            this.btnMasPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasPaciente.Enabled = false;
            this.btnMasPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasPaciente.Location = new System.Drawing.Point(40, 75);
            this.btnMasPaciente.Name = "btnMasPaciente";
            this.btnMasPaciente.Size = new System.Drawing.Size(137, 38);
            this.btnMasPaciente.TabIndex = 1;
            this.btnMasPaciente.Text = "Añadir Paciente";
            this.btnMasPaciente.UseVisualStyleBackColor = true;
            this.btnMasPaciente.Click += new System.EventHandler(this.btnMasPaciente_Click);
            // 
            // butnlistmedicos
            // 
            this.butnlistmedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butnlistmedicos.Enabled = false;
            this.butnlistmedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnlistmedicos.Location = new System.Drawing.Point(40, 119);
            this.butnlistmedicos.Name = "butnlistmedicos";
            this.butnlistmedicos.Size = new System.Drawing.Size(285, 38);
            this.butnlistmedicos.TabIndex = 2;
            this.butnlistmedicos.Text = "Listar Medicos";
            this.butnlistmedicos.UseVisualStyleBackColor = true;
            this.butnlistmedicos.Click += new System.EventHandler(this.butnlistmedicos_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(40, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(285, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Listar Pacientes de un Medico";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(40, 207);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(285, 38);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Eliminar Paciente";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(87, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 53);
            this.button6.TabIndex = 5;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnModMedico);
            this.panel1.Controls.Add(this.btnModifyPatient);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnMasPaciente);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.butnlistmedicos);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(19, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 400);
            this.panel1.TabIndex = 6;
            // 
            // btnModMedico
            // 
            this.btnModMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModMedico.Enabled = false;
            this.btnModMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModMedico.Location = new System.Drawing.Point(183, 31);
            this.btnModMedico.Name = "btnModMedico";
            this.btnModMedico.Size = new System.Drawing.Size(142, 38);
            this.btnModMedico.TabIndex = 7;
            this.btnModMedico.Text = "Modificar Medico";
            this.btnModMedico.UseVisualStyleBackColor = true;
            this.btnModMedico.Click += new System.EventHandler(this.btnModMedico_Click);
            // 
            // btnModifyPatient
            // 
            this.btnModifyPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyPatient.Enabled = false;
            this.btnModifyPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyPatient.Location = new System.Drawing.Point(183, 75);
            this.btnModifyPatient.Name = "btnModifyPatient";
            this.btnModifyPatient.Size = new System.Drawing.Size(143, 38);
            this.btnModifyPatient.TabIndex = 6;
            this.btnModifyPatient.Text = "Modificar Paciente";
            this.btnModifyPatient.UseVisualStyleBackColor = true;
            this.btnModifyPatient.Click += new System.EventHandler(this.btnModifyPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bienvenido al Hospital de Sant Pau";
            // 
            // FormInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormInscripcion";
            this.Text = "Fromulario de Hospital";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMasPaciente;
        private System.Windows.Forms.Button butnlistmedicos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModifyPatient;
        private System.Windows.Forms.Button btnModMedico;
        private System.Windows.Forms.Label label1;
    }
}

