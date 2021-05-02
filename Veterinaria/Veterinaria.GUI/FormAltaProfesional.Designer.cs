
namespace Veterinaria.GUI
{
    partial class FormAltaProfesional
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
            this.txtIdProf = new System.Windows.Forms.TextBox();
            this.txtNombreProf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDomicilioProf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefonoProf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailProf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarProfesional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtIdProf
            // 
            this.txtIdProf.Location = new System.Drawing.Point(50, 55);
            this.txtIdProf.Name = "txtIdProf";
            this.txtIdProf.Size = new System.Drawing.Size(318, 20);
            this.txtIdProf.TabIndex = 1;
            // 
            // txtNombreProf
            // 
            this.txtNombreProf.Location = new System.Drawing.Point(50, 94);
            this.txtNombreProf.Name = "txtNombreProf";
            this.txtNombreProf.Size = new System.Drawing.Size(318, 20);
            this.txtNombreProf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtDomicilioProf
            // 
            this.txtDomicilioProf.Location = new System.Drawing.Point(50, 133);
            this.txtDomicilioProf.Name = "txtDomicilioProf";
            this.txtDomicilioProf.Size = new System.Drawing.Size(318, 20);
            this.txtDomicilioProf.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Domicilio";
            // 
            // txtTelefonoProf
            // 
            this.txtTelefonoProf.Location = new System.Drawing.Point(50, 172);
            this.txtTelefonoProf.Name = "txtTelefonoProf";
            this.txtTelefonoProf.Size = new System.Drawing.Size(318, 20);
            this.txtTelefonoProf.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono";
            // 
            // txtEmailProf
            // 
            this.txtEmailProf.Location = new System.Drawing.Point(50, 211);
            this.txtEmailProf.Name = "txtEmailProf";
            this.txtEmailProf.Size = new System.Drawing.Size(318, 20);
            this.txtEmailProf.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alta profesional";
            // 
            // btnAgregarProfesional
            // 
            this.btnAgregarProfesional.Location = new System.Drawing.Point(50, 250);
            this.btnAgregarProfesional.Name = "btnAgregarProfesional";
            this.btnAgregarProfesional.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProfesional.TabIndex = 11;
            this.btnAgregarProfesional.Text = "Agregar";
            this.btnAgregarProfesional.UseVisualStyleBackColor = true;
            this.btnAgregarProfesional.Click += new System.EventHandler(this.btnAgregarProfesional_Click);
            // 
            // FormAltaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarProfesional);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmailProf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefonoProf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDomicilioProf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreProf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdProf);
            this.Controls.Add(this.label1);
            this.Name = "FormAltaProfesional";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProf;
        private System.Windows.Forms.TextBox txtNombreProf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDomicilioProf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefonoProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailProf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarProfesional;
    }
}