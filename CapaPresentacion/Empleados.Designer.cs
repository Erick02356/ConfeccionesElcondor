namespace CapaPresentacion
{
    partial class Empleados
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
            this.CbArea = new System.Windows.Forms.ComboBox();
            this.LbArea = new System.Windows.Forms.Label();
            this.LbTipo = new System.Windows.Forms.Label();
            this.CbTipoDoc = new System.Windows.Forms.ComboBox();
            this.DvEmpleado = new System.Windows.Forms.DataGridView();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.LbDocumento = new System.Windows.Forms.Label();
            this.LbPrimerNombre = new System.Windows.Forms.Label();
            this.LbSegundoNombre = new System.Windows.Forms.Label();
            this.LbPrimerApellido = new System.Windows.Forms.Label();
            this.LbSegundoApellido = new System.Windows.Forms.Label();
            this.LbFecha = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtPrimerNombre = new System.Windows.Forms.TextBox();
            this.TxtSegundoNombre = new System.Windows.Forms.TextBox();
            this.TxtPrimerApellido = new System.Windows.Forms.TextBox();
            this.TxtSegundoApellido = new System.Windows.Forms.TextBox();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // CbArea
            // 
            this.CbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbArea.FormattingEnabled = true;
            this.CbArea.Location = new System.Drawing.Point(1044, 317);
            this.CbArea.Name = "CbArea";
            this.CbArea.Size = new System.Drawing.Size(195, 21);
            this.CbArea.TabIndex = 0;
            // 
            // LbArea
            // 
            this.LbArea.AutoSize = true;
            this.LbArea.Location = new System.Drawing.Point(921, 320);
            this.LbArea.Name = "LbArea";
            this.LbArea.Size = new System.Drawing.Size(65, 13);
            this.LbArea.TabIndex = 1;
            this.LbArea.Text = "AreaTrabajo";
            // 
            // LbTipo
            // 
            this.LbTipo.AutoSize = true;
            this.LbTipo.Location = new System.Drawing.Point(921, 62);
            this.LbTipo.Name = "LbTipo";
            this.LbTipo.Size = new System.Drawing.Size(99, 13);
            this.LbTipo.TabIndex = 3;
            this.LbTipo.Text = "Tipo de documento";
            // 
            // CbTipoDoc
            // 
            this.CbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoDoc.FormattingEnabled = true;
            this.CbTipoDoc.Location = new System.Drawing.Point(1044, 62);
            this.CbTipoDoc.Name = "CbTipoDoc";
            this.CbTipoDoc.Size = new System.Drawing.Size(195, 21);
            this.CbTipoDoc.TabIndex = 2;
            // 
            // DvEmpleado
            // 
            this.DvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvEmpleado.Location = new System.Drawing.Point(12, 56);
            this.DvEmpleado.Name = "DvEmpleado";
            this.DvEmpleado.Size = new System.Drawing.Size(903, 283);
            this.DvEmpleado.TabIndex = 4;
            // 
            // LbTitulo
            // 
            this.LbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.Location = new System.Drawing.Point(368, 1);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(560, 52);
            this.LbTitulo.TabIndex = 5;
            this.LbTitulo.Text = "REGISTRO EMPLEADOS USAN SERVICIO DE RESTAURANTE";
            this.LbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbDocumento
            // 
            this.LbDocumento.AutoSize = true;
            this.LbDocumento.Location = new System.Drawing.Point(921, 106);
            this.LbDocumento.Name = "LbDocumento";
            this.LbDocumento.Size = new System.Drawing.Size(117, 13);
            this.LbDocumento.TabIndex = 6;
            this.LbDocumento.Text = "Numero de Documento";
            // 
            // LbPrimerNombre
            // 
            this.LbPrimerNombre.AutoSize = true;
            this.LbPrimerNombre.Location = new System.Drawing.Point(921, 142);
            this.LbPrimerNombre.Name = "LbPrimerNombre";
            this.LbPrimerNombre.Size = new System.Drawing.Size(74, 13);
            this.LbPrimerNombre.TabIndex = 7;
            this.LbPrimerNombre.Text = "Primer nombre";
            // 
            // LbSegundoNombre
            // 
            this.LbSegundoNombre.AutoSize = true;
            this.LbSegundoNombre.Location = new System.Drawing.Point(921, 173);
            this.LbSegundoNombre.Name = "LbSegundoNombre";
            this.LbSegundoNombre.Size = new System.Drawing.Size(90, 13);
            this.LbSegundoNombre.TabIndex = 8;
            this.LbSegundoNombre.Text = "Segundo Nombre";
            // 
            // LbPrimerApellido
            // 
            this.LbPrimerApellido.AutoSize = true;
            this.LbPrimerApellido.Location = new System.Drawing.Point(921, 206);
            this.LbPrimerApellido.Name = "LbPrimerApellido";
            this.LbPrimerApellido.Size = new System.Drawing.Size(76, 13);
            this.LbPrimerApellido.TabIndex = 9;
            this.LbPrimerApellido.Text = "Primer Apellido";
            // 
            // LbSegundoApellido
            // 
            this.LbSegundoApellido.AutoSize = true;
            this.LbSegundoApellido.Location = new System.Drawing.Point(921, 243);
            this.LbSegundoApellido.Name = "LbSegundoApellido";
            this.LbSegundoApellido.Size = new System.Drawing.Size(90, 13);
            this.LbSegundoApellido.TabIndex = 10;
            this.LbSegundoApellido.Text = "Segundo Apellido";
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Location = new System.Drawing.Point(921, 281);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(93, 13);
            this.LbFecha.TabIndex = 11;
            this.LbFecha.Text = "Fecha Nacimiento";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(1044, 99);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(195, 20);
            this.TxtDocumento.TabIndex = 12;
            this.TxtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.Location = new System.Drawing.Point(1044, 139);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(195, 20);
            this.TxtPrimerNombre.TabIndex = 13;
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Location = new System.Drawing.Point(1044, 173);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(195, 20);
            this.TxtSegundoNombre.TabIndex = 14;
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.Location = new System.Drawing.Point(1044, 203);
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(195, 20);
            this.TxtPrimerApellido.TabIndex = 15;
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.Location = new System.Drawing.Point(1044, 240);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(195, 20);
            this.TxtSegundoApellido.TabIndex = 16;
            // 
            // DtFecha
            // 
            this.DtFecha.Location = new System.Drawing.Point(1044, 281);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(195, 20);
            this.DtFecha.TabIndex = 17;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(1044, 384);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(165, 53);
            this.BtnGuardar.TabIndex = 18;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(46, 384);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(153, 53);
            this.BtnEditar.TabIndex = 19;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(302, 384);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(167, 53);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(731, 384);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(165, 53);
            this.BtnLimpiar.TabIndex = 21;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 469);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DtFecha);
            this.Controls.Add(this.TxtSegundoApellido);
            this.Controls.Add(this.TxtPrimerApellido);
            this.Controls.Add(this.TxtSegundoNombre);
            this.Controls.Add(this.TxtPrimerNombre);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.LbSegundoApellido);
            this.Controls.Add(this.LbPrimerApellido);
            this.Controls.Add(this.LbSegundoNombre);
            this.Controls.Add(this.LbPrimerNombre);
            this.Controls.Add(this.LbDocumento);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.DvEmpleado);
            this.Controls.Add(this.LbTipo);
            this.Controls.Add(this.CbTipoDoc);
            this.Controls.Add(this.LbArea);
            this.Controls.Add(this.CbArea);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbArea;
        private System.Windows.Forms.Label LbArea;
        private System.Windows.Forms.Label LbTipo;
        private System.Windows.Forms.ComboBox CbTipoDoc;
        private System.Windows.Forms.DataGridView DvEmpleado;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label LbDocumento;
        private System.Windows.Forms.Label LbPrimerNombre;
        private System.Windows.Forms.Label LbSegundoNombre;
        private System.Windows.Forms.Label LbPrimerApellido;
        private System.Windows.Forms.Label LbSegundoApellido;
        private System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtPrimerNombre;
        private System.Windows.Forms.TextBox TxtSegundoNombre;
        private System.Windows.Forms.TextBox TxtPrimerApellido;
        private System.Windows.Forms.TextBox TxtSegundoApellido;
        private System.Windows.Forms.DateTimePicker DtFecha;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}

