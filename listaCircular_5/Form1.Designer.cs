namespace listaCircular_5
{
    partial class frmListaCircular
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdReporte = new System.Windows.Forms.Button();
            this.cmdAgregarInicio = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdEliminarInicio = new System.Windows.Forms.Button();
            this.cmdInsertarDespuesDe = new System.Windows.Forms.Button();
            this.cmdRecorrido = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtInsertarNombre = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtNombreBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(117, 72);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtMinutos.TabIndex = 3;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(12, 107);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 4;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdReporte
            // 
            this.cmdReporte.Location = new System.Drawing.Point(346, 387);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(75, 23);
            this.cmdReporte.TabIndex = 5;
            this.cmdReporte.Text = "Reporte";
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // cmdAgregarInicio
            // 
            this.cmdAgregarInicio.Location = new System.Drawing.Point(12, 136);
            this.cmdAgregarInicio.Name = "cmdAgregarInicio";
            this.cmdAgregarInicio.Size = new System.Drawing.Size(100, 23);
            this.cmdAgregarInicio.TabIndex = 6;
            this.cmdAgregarInicio.Text = "Agregar al Inicio";
            this.cmdAgregarInicio.UseVisualStyleBackColor = true;
            this.cmdAgregarInicio.Click += new System.EventHandler(this.cmdAgregarInicio_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(12, 165);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 7;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(12, 194);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 8;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdEliminarInicio
            // 
            this.cmdEliminarInicio.Location = new System.Drawing.Point(12, 223);
            this.cmdEliminarInicio.Name = "cmdEliminarInicio";
            this.cmdEliminarInicio.Size = new System.Drawing.Size(100, 23);
            this.cmdEliminarInicio.TabIndex = 9;
            this.cmdEliminarInicio.Text = "Eliminar al Inicio";
            this.cmdEliminarInicio.UseVisualStyleBackColor = true;
            this.cmdEliminarInicio.Click += new System.EventHandler(this.cmdEliminarInicio_Click);
            // 
            // cmdInsertarDespuesDe
            // 
            this.cmdInsertarDespuesDe.Location = new System.Drawing.Point(12, 252);
            this.cmdInsertarDespuesDe.Name = "cmdInsertarDespuesDe";
            this.cmdInsertarDespuesDe.Size = new System.Drawing.Size(114, 24);
            this.cmdInsertarDespuesDe.TabIndex = 10;
            this.cmdInsertarDespuesDe.Text = "Insertar Despues De";
            this.cmdInsertarDespuesDe.UseVisualStyleBackColor = true;
            this.cmdInsertarDespuesDe.Click += new System.EventHandler(this.cmdInsertarDespuesDe_Click);
            // 
            // cmdRecorrido
            // 
            this.cmdRecorrido.Location = new System.Drawing.Point(11, 294);
            this.cmdRecorrido.Name = "cmdRecorrido";
            this.cmdRecorrido.Size = new System.Drawing.Size(75, 23);
            this.cmdRecorrido.TabIndex = 11;
            this.cmdRecorrido.Text = "Recorrido";
            this.cmdRecorrido.UseVisualStyleBackColor = true;
            this.cmdRecorrido.Click += new System.EventHandler(this.cmdRecorrido_Click);
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(259, 29);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(246, 352);
            this.txtReporte.TabIndex = 12;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(117, 168);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 13;
            // 
            // txtInsertarNombre
            // 
            this.txtInsertarNombre.Location = new System.Drawing.Point(132, 256);
            this.txtInsertarNombre.Name = "txtInsertarNombre";
            this.txtInsertarNombre.Size = new System.Drawing.Size(100, 20);
            this.txtInsertarNombre.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 336);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2017, 5, 12, 19, 18, 15, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 374);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // txtNombreBase
            // 
            this.txtNombreBase.Location = new System.Drawing.Point(132, 297);
            this.txtNombreBase.Name = "txtNombreBase";
            this.txtNombreBase.Size = new System.Drawing.Size(100, 20);
            this.txtNombreBase.TabIndex = 17;
            // 
            // frmListaCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 496);
            this.Controls.Add(this.txtNombreBase);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtInsertarNombre);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.cmdRecorrido);
            this.Controls.Add(this.cmdInsertarDespuesDe);
            this.Controls.Add(this.cmdEliminarInicio);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdAgregarInicio);
            this.Controls.Add(this.cmdReporte);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmListaCircular";
            this.Text = "Lista Circular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.Button cmdAgregarInicio;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdEliminarInicio;
        private System.Windows.Forms.Button cmdInsertarDespuesDe;
        private System.Windows.Forms.Button cmdRecorrido;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtInsertarNombre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtNombreBase;
    }
}

