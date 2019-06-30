﻿namespace MyPet.UI
{
    partial class frmEspecie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspecie));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpEspecie = new System.Windows.Forms.GroupBox();
            this.lblIDEspecie = new System.Windows.Forms.Label();
            this.txtIDEspecie = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lblCacteristicasEspecie = new System.Windows.Forms.Label();
            this.txtCaracteristicaEspecie = new System.Windows.Forms.TextBox();
            this.lblDescricaoEspecie = new System.Windows.Forms.Label();
            this.txtDescricaoEspecie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpEspecie.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 79);
            this.dataGridView1.TabIndex = 21;
            // 
            // grpEspecie
            // 
            this.grpEspecie.Controls.Add(this.lblIDEspecie);
            this.grpEspecie.Controls.Add(this.txtIDEspecie);
            this.grpEspecie.Controls.Add(this.btnCancelar);
            this.grpEspecie.Controls.Add(this.btnExcluir);
            this.grpEspecie.Controls.Add(this.btnSalvar);
            this.grpEspecie.Controls.Add(this.btnIncluir);
            this.grpEspecie.Controls.Add(this.lblCacteristicasEspecie);
            this.grpEspecie.Controls.Add(this.txtCaracteristicaEspecie);
            this.grpEspecie.Controls.Add(this.lblDescricaoEspecie);
            this.grpEspecie.Controls.Add(this.txtDescricaoEspecie);
            this.grpEspecie.Location = new System.Drawing.Point(12, 12);
            this.grpEspecie.Name = "grpEspecie";
            this.grpEspecie.Size = new System.Drawing.Size(549, 241);
            this.grpEspecie.TabIndex = 20;
            this.grpEspecie.TabStop = false;
            this.grpEspecie.Text = "Cadastro Espécie";
            // 
            // lblIDEspecie
            // 
            this.lblIDEspecie.AutoSize = true;
            this.lblIDEspecie.Location = new System.Drawing.Point(47, 25);
            this.lblIDEspecie.Name = "lblIDEspecie";
            this.lblIDEspecie.Size = new System.Drawing.Size(59, 13);
            this.lblIDEspecie.TabIndex = 17;
            this.lblIDEspecie.Text = "ID Espécie";
            // 
            // txtIDEspecie
            // 
            this.txtIDEspecie.AcceptsReturn = true;
            this.txtIDEspecie.Enabled = false;
            this.txtIDEspecie.Location = new System.Drawing.Point(48, 41);
            this.txtIDEspecie.Name = "txtIDEspecie";
            this.txtIDEspecie.Size = new System.Drawing.Size(205, 20);
            this.txtIDEspecie.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MyPet.UI.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(498, 42);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::MyPet.UI.Properties.Resources.delete;
            this.btnExcluir.Location = new System.Drawing.Point(452, 41);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 40);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::MyPet.UI.Properties.Resources.salvar;
            this.btnSalvar.Location = new System.Drawing.Point(406, 42);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 40);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(360, 42);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(40, 40);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lblCacteristicasEspecie
            // 
            this.lblCacteristicasEspecie.AutoSize = true;
            this.lblCacteristicasEspecie.Location = new System.Drawing.Point(47, 103);
            this.lblCacteristicasEspecie.Name = "lblCacteristicasEspecie";
            this.lblCacteristicasEspecie.Size = new System.Drawing.Size(78, 13);
            this.lblCacteristicasEspecie.TabIndex = 7;
            this.lblCacteristicasEspecie.Text = "Características";
            // 
            // txtCaracteristicaEspecie
            // 
            this.txtCaracteristicaEspecie.Location = new System.Drawing.Point(48, 119);
            this.txtCaracteristicaEspecie.Multiline = true;
            this.txtCaracteristicaEspecie.Name = "txtCaracteristicaEspecie";
            this.txtCaracteristicaEspecie.Size = new System.Drawing.Size(205, 62);
            this.txtCaracteristicaEspecie.TabIndex = 2;
            // 
            // lblDescricaoEspecie
            // 
            this.lblDescricaoEspecie.AutoSize = true;
            this.lblDescricaoEspecie.Location = new System.Drawing.Point(46, 64);
            this.lblDescricaoEspecie.Name = "lblDescricaoEspecie";
            this.lblDescricaoEspecie.Size = new System.Drawing.Size(55, 13);
            this.lblDescricaoEspecie.TabIndex = 1;
            this.lblDescricaoEspecie.Text = "Descrição";
            // 
            // txtDescricaoEspecie
            // 
            this.txtDescricaoEspecie.Location = new System.Drawing.Point(49, 80);
            this.txtDescricaoEspecie.Name = "txtDescricaoEspecie";
            this.txtDescricaoEspecie.Size = new System.Drawing.Size(204, 20);
            this.txtDescricaoEspecie.TabIndex = 1;
            // 
            // frmEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpEspecie);
            this.MinimizeBox = false;
            this.Name = "frmEspecie";
            this.Text = "frmEspecie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpEspecie.ResumeLayout(false);
            this.grpEspecie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpEspecie;
        private System.Windows.Forms.Label lblIDEspecie;
        private System.Windows.Forms.TextBox txtIDEspecie;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblCacteristicasEspecie;
        private System.Windows.Forms.TextBox txtCaracteristicaEspecie;
        private System.Windows.Forms.Label lblDescricaoEspecie;
        private System.Windows.Forms.TextBox txtDescricaoEspecie;
    }
}