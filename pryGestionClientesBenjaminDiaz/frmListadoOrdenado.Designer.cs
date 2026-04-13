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
            this.gboConsulta = new System.Windows.Forms.GroupBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.gboConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // gboConsulta
            // 
            this.gboConsulta.Controls.Add(this.dataGridView1);
            this.gboConsulta.Controls.Add(this.cmbModo);
            this.gboConsulta.Controls.Add(this.lblModo);
            this.gboConsulta.Controls.Add(this.lblCampo);
            this.gboConsulta.Controls.Add(this.cmbCampo);
            this.gboConsulta.Location = new System.Drawing.Point(12, 25);
            this.gboConsulta.Name = "gboConsulta";
            this.gboConsulta.Size = new System.Drawing.Size(554, 398);
            this.gboConsulta.TabIndex = 1;
            this.gboConsulta.TabStop = false;
            this.gboConsulta.Text = "Consulta de datos";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(47, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 217);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
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
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(448, 429);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(99, 37);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // frmListadoOrdenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gboConsulta);
            this.Name = "frmListadoOrdenado";
            this.Text = "Listado Ordenado";
            this.gboConsulta.ResumeLayout(false);
            this.gboConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.GroupBox gboConsulta;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbModo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnListar;
    }
}