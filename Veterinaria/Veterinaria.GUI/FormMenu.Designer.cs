﻿
namespace Veterinaria.GUI
{
    partial class FormMenu
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
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnAltaPaciente = new System.Windows.Forms.Button();
            this.btnBajaPaciente = new System.Windows.Forms.Button();
            this.btnAgregarVisita = new System.Windows.Forms.Button();
            this.btnListarHistoria = new System.Windows.Forms.Button();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.lblSucVet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(31, 57);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(116, 23);
            this.btnAltaCliente.TabIndex = 1;
            this.btnAltaCliente.Text = "AByM Clientes";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAByM_Click);
            // 
            // btnAltaPaciente
            // 
            this.btnAltaPaciente.Location = new System.Drawing.Point(31, 95);
            this.btnAltaPaciente.Name = "btnAltaPaciente";
            this.btnAltaPaciente.Size = new System.Drawing.Size(116, 23);
            this.btnAltaPaciente.TabIndex = 3;
            this.btnAltaPaciente.Text = "Alta paciente";
            this.btnAltaPaciente.UseVisualStyleBackColor = true;
            this.btnAltaPaciente.Click += new System.EventHandler(this.btnAltaPaciente_Click);
            // 
            // btnBajaPaciente
            // 
            this.btnBajaPaciente.Location = new System.Drawing.Point(31, 135);
            this.btnBajaPaciente.Name = "btnBajaPaciente";
            this.btnBajaPaciente.Size = new System.Drawing.Size(116, 23);
            this.btnBajaPaciente.TabIndex = 5;
            this.btnBajaPaciente.Text = "Baja paciente";
            this.btnBajaPaciente.UseVisualStyleBackColor = true;
            this.btnBajaPaciente.Click += new System.EventHandler(this.btnBajaPaciente_Click);
            // 
            // btnAgregarVisita
            // 
            this.btnAgregarVisita.Location = new System.Drawing.Point(31, 175);
            this.btnAgregarVisita.Name = "btnAgregarVisita";
            this.btnAgregarVisita.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarVisita.TabIndex = 7;
            this.btnAgregarVisita.Text = "Agregar visita";
            this.btnAgregarVisita.UseVisualStyleBackColor = true;
            // 
            // btnListarHistoria
            // 
            this.btnListarHistoria.Location = new System.Drawing.Point(31, 216);
            this.btnListarHistoria.Name = "btnListarHistoria";
            this.btnListarHistoria.Size = new System.Drawing.Size(116, 23);
            this.btnListarHistoria.TabIndex = 9;
            this.btnListarHistoria.Text = "Listar historia";
            this.btnListarHistoria.UseVisualStyleBackColor = true;
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(31, 258);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(116, 23);
            this.btnListarClientes.TabIndex = 11;
            this.btnListarClientes.Text = "Listar clientes";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // lblSucVet
            // 
            this.lblSucVet.AutoSize = true;
            this.lblSucVet.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucVet.Location = new System.Drawing.Point(27, 9);
            this.lblSucVet.Name = "lblSucVet";
            this.lblSucVet.Size = new System.Drawing.Size(297, 19);
            this.lblSucVet.TabIndex = 14;
            this.lblSucVet.Text = "\"Nombre sucursal\" - \"Domicilio sucursal\"";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSucVet);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.btnListarHistoria);
            this.Controls.Add(this.btnAgregarVisita);
            this.Controls.Add(this.btnBajaPaciente);
            this.Controls.Add(this.btnAltaPaciente);
            this.Controls.Add(this.btnAltaCliente);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnAltaPaciente;
        private System.Windows.Forms.Button btnBajaPaciente;
        private System.Windows.Forms.Button btnAgregarVisita;
        private System.Windows.Forms.Button btnListarHistoria;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.Label lblSucVet;
    }
}