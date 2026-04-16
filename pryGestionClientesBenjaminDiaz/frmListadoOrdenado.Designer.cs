namespace pryGestionClientesBenjaminDiaz
{
    partial class frmListadoOrdenado
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
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.dgvConsulta = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.gboConsulta = new System.Windows.Forms.DataGridView();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gboConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCampo
            // 
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Limite",
            "Deuda"});
            this.cmbCampo.Location = new System.Drawing.Point(131, 65);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 0;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.Controls.Add(this.btnListar);
            this.dgvConsulta.Controls.Add(this.gboConsulta);
            this.dgvConsulta.Controls.Add(this.cmbModo);
            this.dgvConsulta.Controls.Add(this.lblModo);
            this.dgvConsulta.Controls.Add(this.lblCampo);
            this.dgvConsulta.Controls.Add(this.cmbCampo);
            this.dgvConsulta.Location = new System.Drawing.Point(12, 25);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(554, 431);
            this.dgvConsulta.TabIndex = 1;
            this.dgvConsulta.TabStop = false;
            this.dgvConsulta.Text = "Consulta de datos";
            this.dgvConsulta.Enter += new System.EventHandler(this.dgvConsulta_Enter);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(382, 361);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(99, 37);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // gboConsulta
            // 
            this.gboConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gboConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gboConsulta.Location = new System.Drawing.Point(47, 118);
            this.gboConsulta.Name = "gboConsulta";
            this.gboConsulta.Size = new System.Drawing.Size(448, 217);
            this.gboConsulta.TabIndex = 4;
            this.gboConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gboConsulta_CellContentClick);
            // 
            // cmbModo
            // 
            this.cmbModo.FormattingEnabled = true;
            this.cmbModo.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbModo.Location = new System.Drawing.Point(338, 65);
            this.cmbModo.Name = "cmbModo";
            this.cmbModo.Size = new System.Drawing.Size(121, 21);
            this.cmbModo.TabIndex = 3;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.Location = new System.Drawing.Point(269, 63);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(63, 24);
            this.lblModo.TabIndex = 2;
            this.lblModo.Text = "Modo";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(43, 65);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(76, 24);
            this.lblCampo.TabIndex = 1;
            this.lblCampo.Text = "Campo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuario";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite de Credito";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            // 
            // frmListadoOrdenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 491);
            this.Controls.Add(this.dgvConsulta);
            this.Name = "frmListadoOrdenado";
            this.Text = "Listado Ordenado";
            this.Load += new System.EventHandler(this.frmListadoOrdenado_Load);
            this.dgvConsulta.ResumeLayout(false);
            this.dgvConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gboConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.GroupBox dgvConsulta;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.DataGridView gboConsulta;
        private System.Windows.Forms.ComboBox cmbModo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}