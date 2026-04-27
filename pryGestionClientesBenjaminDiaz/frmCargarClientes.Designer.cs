namespace pryGestionClientesBenjaminDiaz
{
    partial class frmCargarClientes
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gboCargaDatos = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblNombreyApellido = new System.Windows.Forms.Label();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtNombreyApellido = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gboCargaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboCargaDatos
            // 
            this.gboCargaDatos.Controls.Add(this.btnCargar);
            this.gboCargaDatos.Controls.Add(this.lblDeuda);
            this.gboCargaDatos.Controls.Add(this.lblNombreyApellido);
            this.gboCargaDatos.Controls.Add(this.lblLimiteCredito);
            this.gboCargaDatos.Controls.Add(this.txtLimite);
            this.gboCargaDatos.Controls.Add(this.txtNombreyApellido);
            this.gboCargaDatos.Controls.Add(this.txtDeuda);
            this.gboCargaDatos.Controls.Add(this.txtCodigo);
            this.gboCargaDatos.Controls.Add(this.lblCodigo);
            this.gboCargaDatos.Location = new System.Drawing.Point(12, 12);
            this.gboCargaDatos.Name = "gboCargaDatos";
            this.gboCargaDatos.Size = new System.Drawing.Size(496, 237);
            this.gboCargaDatos.TabIndex = 0;
            this.gboCargaDatos.TabStop = false;
            this.gboCargaDatos.Text = "Carga de Datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(332, 192);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(45, 115);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 7;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblNombreyApellido
            // 
            this.lblNombreyApellido.AutoSize = true;
            this.lblNombreyApellido.Location = new System.Drawing.Point(234, 43);
            this.lblNombreyApellido.Name = "lblNombreyApellido";
            this.lblNombreyApellido.Size = new System.Drawing.Size(95, 13);
            this.lblNombreyApellido.TabIndex = 6;
            this.lblNombreyApellido.Text = "Nombre y Apellido:";
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(241, 115);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(88, 13);
            this.lblLimiteCredito.TabIndex = 5;
            this.lblLimiteCredito.Text = "Limite de Credito:";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(332, 112);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 20);
            this.txtLimite.TabIndex = 4;
            // 
            // txtNombreyApellido
            // 
            this.txtNombreyApellido.Location = new System.Drawing.Point(332, 40);
            this.txtNombreyApellido.Name = "txtNombreyApellido";
            this.txtNombreyApellido.Size = new System.Drawing.Size(100, 20);
            this.txtNombreyApellido.TabIndex = 3;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(103, 112);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 20);
            this.txtDeuda.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(45, 40);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // frmCargarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 264);
            this.Controls.Add(this.gboCargaDatos);
            this.Name = "frmCargarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargarClientes";
            this.gboCargaDatos.ResumeLayout(false);
            this.gboCargaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gboCargaDatos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblNombreyApellido;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtNombreyApellido;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}