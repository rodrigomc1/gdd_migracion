﻿namespace PalcoNet.Vistas
{
    partial class RolSelector
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
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.lblRolSelector = new System.Windows.Forms.Label();
            this.groupBoxRol = new System.Windows.Forms.GroupBox();
            this.groupBoxRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(209, 103);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(88, 25);
            this.btnContinuar.TabIndex = 0;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(115, 103);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 25);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(6, 44);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(153, 24);
            this.comboBoxRol.TabIndex = 2;
            // 
            // lblRolSelector
            // 
            this.lblRolSelector.AutoSize = true;
            this.lblRolSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolSelector.Location = new System.Drawing.Point(3, 28);
            this.lblRolSelector.Name = "lblRolSelector";
            this.lblRolSelector.Size = new System.Drawing.Size(92, 13);
            this.lblRolSelector.TabIndex = 3;
            this.lblRolSelector.Text = "Seleccione un rol:";
            // 
            // groupBoxRol
            // 
            this.groupBoxRol.Controls.Add(this.lblRolSelector);
            this.groupBoxRol.Controls.Add(this.comboBoxRol);
            this.groupBoxRol.Location = new System.Drawing.Point(31, 13);
            this.groupBoxRol.Name = "groupBoxRol";
            this.groupBoxRol.Size = new System.Drawing.Size(266, 84);
            this.groupBoxRol.TabIndex = 4;
            this.groupBoxRol.TabStop = false;
            this.groupBoxRol.Text = "Seleccione Un Rol";
            // 
            // RolSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 148);
            this.Controls.Add(this.groupBoxRol);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnContinuar);
            this.Name = "RolSelector";
            this.Text = "Selector De Rol";
            this.Load += new System.EventHandler(this.RolSelector_Load);
            this.groupBoxRol.ResumeLayout(false);
            this.groupBoxRol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label lblRolSelector;
        private System.Windows.Forms.GroupBox groupBoxRol;
    }
}