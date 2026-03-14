namespace BibliotecaApp
{
    partial class EstadisticasForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLibrosDisponibles = new System.Windows.Forms.Label();
            this.lblTotalLibros = new System.Windows.Forms.Label();
            this.lblTotalPrestamos = new System.Windows.Forms.Label();
            this.lblUsuariosSinPrestamo = new System.Windows.Forms.Label();
            this.lblUsuariosConPrestamo = new System.Windows.Forms.Label();
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.lblLibrosPrestados = new System.Windows.Forms.Label();
            this.chartLibros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(238, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 30);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Estadisticas de la Biblioteca";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.UseWaitCursor = true;
            // 
            // lblLibrosDisponibles
            // 
            this.lblLibrosDisponibles.AutoSize = true;
            this.lblLibrosDisponibles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrosDisponibles.Location = new System.Drawing.Point(81, 171);
            this.lblLibrosDisponibles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibrosDisponibles.Name = "lblLibrosDisponibles";
            this.lblLibrosDisponibles.Size = new System.Drawing.Size(154, 21);
            this.lblLibrosDisponibles.TabIndex = 14;
            this.lblLibrosDisponibles.Text = "Libros Disponibles: 0";
            // 
            // lblTotalLibros
            // 
            this.lblTotalLibros.AutoSize = true;
            this.lblTotalLibros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLibros.Location = new System.Drawing.Point(81, 106);
            this.lblTotalLibros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalLibros.Name = "lblTotalLibros";
            this.lblTotalLibros.Size = new System.Drawing.Size(105, 21);
            this.lblTotalLibros.TabIndex = 15;
            this.lblTotalLibros.Text = "Total Libros: 0";
            // 
            // lblTotalPrestamos
            // 
            this.lblTotalPrestamos.AutoSize = true;
            this.lblTotalPrestamos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrestamos.Location = new System.Drawing.Point(81, 438);
            this.lblTotalPrestamos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrestamos.Name = "lblTotalPrestamos";
            this.lblTotalPrestamos.Size = new System.Drawing.Size(135, 21);
            this.lblTotalPrestamos.TabIndex = 16;
            this.lblTotalPrestamos.Text = "Total Prestamos: 0";
            // 
            // lblUsuariosSinPrestamo
            // 
            this.lblUsuariosSinPrestamo.AutoSize = true;
            this.lblUsuariosSinPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosSinPrestamo.Location = new System.Drawing.Point(81, 382);
            this.lblUsuariosSinPrestamo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuariosSinPrestamo.Name = "lblUsuariosSinPrestamo";
            this.lblUsuariosSinPrestamo.Size = new System.Drawing.Size(181, 21);
            this.lblUsuariosSinPrestamo.TabIndex = 17;
            this.lblUsuariosSinPrestamo.Text = "Usuarios sin Prestamo: 0";
            // 
            // lblUsuariosConPrestamo
            // 
            this.lblUsuariosConPrestamo.AutoSize = true;
            this.lblUsuariosConPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosConPrestamo.Location = new System.Drawing.Point(81, 330);
            this.lblUsuariosConPrestamo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuariosConPrestamo.Name = "lblUsuariosConPrestamo";
            this.lblUsuariosConPrestamo.Size = new System.Drawing.Size(186, 21);
            this.lblUsuariosConPrestamo.TabIndex = 18;
            this.lblUsuariosConPrestamo.Text = "Usuarios con Prestamo: 0";
            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.AutoSize = true;
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsuarios.Location = new System.Drawing.Point(81, 276);
            this.lblTotalUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(123, 21);
            this.lblTotalUsuarios.TabIndex = 19;
            this.lblTotalUsuarios.Text = "Total Usuarios: 0";
            // 
            // lblLibrosPrestados
            // 
            this.lblLibrosPrestados.AutoSize = true;
            this.lblLibrosPrestados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrosPrestados.Location = new System.Drawing.Point(81, 225);
            this.lblLibrosPrestados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibrosPrestados.Name = "lblLibrosPrestados";
            this.lblLibrosPrestados.Size = new System.Drawing.Size(141, 21);
            this.lblLibrosPrestados.TabIndex = 20;
            this.lblLibrosPrestados.Text = "Libros Prestados: 0";
            // 
            // chartLibros
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLibros.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLibros.Legends.Add(legend1);
            this.chartLibros.Location = new System.Drawing.Point(370, 140);
            this.chartLibros.Name = "chartLibros";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLibros.Series.Add(series1);
            this.chartLibros.Size = new System.Drawing.Size(300, 300);
            this.chartLibros.TabIndex = 21;
            this.chartLibros.Text = "chart1";
            // 
            // EstadisticasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 541);
            this.Controls.Add(this.chartLibros);
            this.Controls.Add(this.lblLibrosPrestados);
            this.Controls.Add(this.lblTotalUsuarios);
            this.Controls.Add(this.lblUsuariosConPrestamo);
            this.Controls.Add(this.lblUsuariosSinPrestamo);
            this.Controls.Add(this.lblTotalPrestamos);
            this.Controls.Add(this.lblTotalLibros);
            this.Controls.Add(this.lblLibrosDisponibles);
            this.Controls.Add(this.lblTitulo);
            this.Name = "EstadisticasForm";
            this.Text = "EstadisticasForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLibrosDisponibles;
        private System.Windows.Forms.Label lblTotalLibros;
        private System.Windows.Forms.Label lblTotalPrestamos;
        private System.Windows.Forms.Label lblUsuariosSinPrestamo;
        private System.Windows.Forms.Label lblUsuariosConPrestamo;
        private System.Windows.Forms.Label lblTotalUsuarios;
        private System.Windows.Forms.Label lblLibrosPrestados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibros;
    }
}