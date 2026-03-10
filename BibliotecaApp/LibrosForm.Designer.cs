namespace BibliotecaApp
{
    partial class LibrosForm
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(336, 78);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(500, 29);
            this.txtTitulo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(182, 291);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 50);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(427, 291);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 50);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(686, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 50);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(336, 141);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(500, 29);
            this.txtAutor.TabIndex = 9;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(336, 208);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(500, 29);
            this.txtAnio.TabIndex = 10;
            this.txtAnio.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitulo,
            this.colAutor,
            this.colAnio,
            this.colDisponible});
            this.dgvLibros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLibros.Location = new System.Drawing.Point(0, 384);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 72;
            this.dgvLibros.RowTemplate.Height = 31;
            this.dgvLibros.Size = new System.Drawing.Size(996, 361);
            this.dgvLibros.TabIndex = 11;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 9;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.MinimumWidth = 9;
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 9;
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colAnio
            // 
            this.colAnio.HeaderText = "Año";
            this.colAnio.MinimumWidth = 9;
            this.colAnio.Name = "colAnio";
            this.colAnio.ReadOnly = true;
            // 
            // colDisponible
            // 
            this.colDisponible.HeaderText = "Disponible";
            this.colDisponible.MinimumWidth = 9;
            this.colDisponible.Name = "colDisponible";
            this.colDisponible.ReadOnly = true;
            // 
            // LibrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 745);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LibrosForm";
            this.Text = "LibrosForm";
            this.Load += new System.EventHandler(this.LibrosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisponible;
    }
}