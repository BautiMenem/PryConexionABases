namespace PryConexionABases
{
    partial class frmConexion
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBaseCon = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cboColumna = new System.Windows.Forms.ComboBox();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar Base";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBaseCon
            // 
            this.lblBaseCon.AutoSize = true;
            this.lblBaseCon.Location = new System.Drawing.Point(93, 26);
            this.lblBaseCon.Name = "lblBaseCon";
            this.lblBaseCon.Size = new System.Drawing.Size(144, 13);
            this.lblBaseCon.TabIndex = 1;
            this.lblBaseCon.Text = "Nombre de Base Conectada:";
            this.lblBaseCon.Click += new System.EventHandler(this.lblBaseCon_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(265, 26);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(10, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = ".";
            this.lblBase.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 50);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(504, 241);
            this.dgvDatos.TabIndex = 3;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cboColumna
            // 
            this.cboColumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumna.FormattingEnabled = true;
            this.cboColumna.Location = new System.Drawing.Point(122, 300);
            this.cboColumna.Name = "cboColumna";
            this.cboColumna.Size = new System.Drawing.Size(121, 21);
            this.cboColumna.TabIndex = 4;
            this.cboColumna.SelectedIndexChanged += new System.EventHandler(this.cboComlumna_SelectedIndexChanged);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(9, 303);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(107, 13);
            this.lblSeleccionar.TabIndex = 5;
            this.lblSeleccionar.Text = "Seleccionar Columna";
            // 
            // frmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 332);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.cboColumna);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblBaseCon);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmConexion";
            this.Text = "Conexion A Base";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBaseCon;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cboColumna;
        private System.Windows.Forms.Label lblSeleccionar;
    }
}

