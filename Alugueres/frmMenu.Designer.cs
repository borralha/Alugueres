﻿namespace Alugueres
{
    partial class frmMenu
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
            this.brnClientes = new System.Windows.Forms.Button();
            this.btnAlugueres = new System.Windows.Forms.Button();
            this.btnViaturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // brnClientes
            // 
            this.brnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnClientes.Location = new System.Drawing.Point(148, 170);
            this.brnClientes.Name = "brnClientes";
            this.brnClientes.Size = new System.Drawing.Size(149, 65);
            this.brnClientes.TabIndex = 1;
            this.brnClientes.Text = "Gerir Clientes";
            this.brnClientes.UseVisualStyleBackColor = true;
            // 
            // btnAlugueres
            // 
            this.btnAlugueres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugueres.Location = new System.Drawing.Point(330, 170);
            this.btnAlugueres.Name = "btnAlugueres";
            this.btnAlugueres.Size = new System.Drawing.Size(149, 65);
            this.btnAlugueres.TabIndex = 2;
            this.btnAlugueres.Text = "Gerir Alugueres";
            this.btnAlugueres.UseVisualStyleBackColor = true;
            // 
            // btnViaturas
            // 
            this.btnViaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViaturas.Location = new System.Drawing.Point(503, 170);
            this.btnViaturas.Name = "btnViaturas";
            this.btnViaturas.Size = new System.Drawing.Size(149, 65);
            this.btnViaturas.TabIndex = 3;
            this.btnViaturas.Text = "Gerir Viaturas";
            this.btnViaturas.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViaturas);
            this.Controls.Add(this.btnAlugueres);
            this.Controls.Add(this.brnClientes);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnClientes;
        private System.Windows.Forms.Button btnAlugueres;
        private System.Windows.Forms.Button btnViaturas;
    }
}

