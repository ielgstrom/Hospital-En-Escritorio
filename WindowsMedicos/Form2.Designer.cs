
namespace WindowsMedicos
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAñadirMedico = new System.Windows.Forms.Button();
            this.btnCancelarMedico = new System.Windows.Forms.Button();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtEdadMedico = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Medico";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especialidad Medico";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad Medico";
            // 
            // btnAñadirMedico
            // 
            this.btnAñadirMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadirMedico.BackColor = System.Drawing.SystemColors.Control;
            this.btnAñadirMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAñadirMedico.Location = new System.Drawing.Point(357, 204);
            this.btnAñadirMedico.Margin = new System.Windows.Forms.Padding(0);
            this.btnAñadirMedico.Name = "btnAñadirMedico";
            this.btnAñadirMedico.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirMedico.TabIndex = 3;
            this.btnAñadirMedico.Text = "Añadir";
            this.btnAñadirMedico.UseVisualStyleBackColor = false;
            this.btnAñadirMedico.Click += new System.EventHandler(this.btnAñadirMedico_Click);
            // 
            // btnCancelarMedico
            // 
            this.btnCancelarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarMedico.Location = new System.Drawing.Point(279, 204);
            this.btnCancelarMedico.Name = "btnCancelarMedico";
            this.btnCancelarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMedico.TabIndex = 4;
            this.btnCancelarMedico.Text = "Cancelar";
            this.btnCancelarMedico.UseVisualStyleBackColor = true;
            this.btnCancelarMedico.Click += new System.EventHandler(this.btnCancelarMedico_Click);
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreMedico.Location = new System.Drawing.Point(237, 75);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMedico.TabIndex = 5;
            // 
            // txtEdadMedico
            // 
            this.txtEdadMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdadMedico.Location = new System.Drawing.Point(237, 110);
            this.txtEdadMedico.Name = "txtEdadMedico";
            this.txtEdadMedico.Size = new System.Drawing.Size(100, 20);
            this.txtEdadMedico.TabIndex = 6;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEspecialidad.Location = new System.Drawing.Point(237, 142);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.txtEspecialidad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Añadir Médico";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 236);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtEdadMedico);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.btnCancelarMedico);
            this.Controls.Add(this.btnAñadirMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAñadirMedico;
        private System.Windows.Forms.Button btnCancelarMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtEdadMedico;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label label4;
    }
}