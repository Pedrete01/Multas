namespace Multas
{
    partial class FormMultas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.camposMulta = new System.Windows.Forms.GroupBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaLim = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaExp = new System.Windows.Forms.DateTimePicker();
            this.textObservaciones = new System.Windows.Forms.TextBox();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.textNAgente = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.labelImporte = new System.Windows.Forms.Label();
            this.labelNAgente = new System.Windows.Forms.Label();
            this.labelFechaLim = new System.Windows.Forms.Label();
            this.labelFechaExp = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.dgvMultas = new System.Windows.Forms.DataGridView();
            this.labelListadoMultas = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.camposMulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // camposMulta
            // 
            this.camposMulta.Controls.Add(this.textId);
            this.camposMulta.Controls.Add(this.buttonEditar);
            this.camposMulta.Controls.Add(this.dateTimePickerFechaLim);
            this.camposMulta.Controls.Add(this.dateTimePickerFechaExp);
            this.camposMulta.Controls.Add(this.textObservaciones);
            this.camposMulta.Controls.Add(this.textImporte);
            this.camposMulta.Controls.Add(this.textNAgente);
            this.camposMulta.Controls.Add(this.textDni);
            this.camposMulta.Controls.Add(this.labelObservaciones);
            this.camposMulta.Controls.Add(this.labelImporte);
            this.camposMulta.Controls.Add(this.labelNAgente);
            this.camposMulta.Controls.Add(this.labelFechaLim);
            this.camposMulta.Controls.Add(this.labelFechaExp);
            this.camposMulta.Controls.Add(this.labelDni);
            this.camposMulta.Controls.Add(this.buttonGuardar);
            this.camposMulta.Controls.Add(this.buttonCancelar);
            this.camposMulta.Controls.Add(this.buttonBorrar);
            this.camposMulta.Controls.Add(this.buttonCrear);
            this.camposMulta.Location = new System.Drawing.Point(12, 12);
            this.camposMulta.Name = "camposMulta";
            this.camposMulta.Size = new System.Drawing.Size(776, 366);
            this.camposMulta.TabIndex = 0;
            this.camposMulta.TabStop = false;
            this.camposMulta.Text = "Multa";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(481, 310);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(131, 36);
            this.buttonEditar.TabIndex = 17;
            this.buttonEditar.Text = "MODIFICAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // dateTimePickerFechaLim
            // 
            this.dateTimePickerFechaLim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaLim.Location = new System.Drawing.Point(122, 105);
            this.dateTimePickerFechaLim.Name = "dateTimePickerFechaLim";
            this.dateTimePickerFechaLim.Size = new System.Drawing.Size(199, 27);
            this.dateTimePickerFechaLim.TabIndex = 16;
            // 
            // dateTimePickerFechaExp
            // 
            this.dateTimePickerFechaExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaExp.Location = new System.Drawing.Point(122, 72);
            this.dateTimePickerFechaExp.Name = "dateTimePickerFechaExp";
            this.dateTimePickerFechaExp.Size = new System.Drawing.Size(199, 27);
            this.dateTimePickerFechaExp.TabIndex = 15;
            // 
            // textObservaciones
            // 
            this.textObservaciones.Location = new System.Drawing.Point(371, 74);
            this.textObservaciones.Multiline = true;
            this.textObservaciones.Name = "textObservaciones";
            this.textObservaciones.Size = new System.Drawing.Size(378, 186);
            this.textObservaciones.TabIndex = 14;
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(122, 233);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(114, 27);
            this.textImporte.TabIndex = 13;
            // 
            // textNAgente
            // 
            this.textNAgente.Location = new System.Drawing.Point(122, 141);
            this.textNAgente.Name = "textNAgente";
            this.textNAgente.Size = new System.Drawing.Size(199, 27);
            this.textNAgente.TabIndex = 12;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(122, 40);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(199, 27);
            this.textDni.TabIndex = 11;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Location = new System.Drawing.Point(371, 43);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(105, 20);
            this.labelObservaciones.TabIndex = 10;
            this.labelObservaciones.Text = "Observaciones";
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Location = new System.Drawing.Point(22, 236);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(69, 20);
            this.labelImporte.TabIndex = 9;
            this.labelImporte.Text = "IMPORTE";
            // 
            // labelNAgente
            // 
            this.labelNAgente.AutoSize = true;
            this.labelNAgente.Location = new System.Drawing.Point(22, 144);
            this.labelNAgente.Name = "labelNAgente";
            this.labelNAgente.Size = new System.Drawing.Size(78, 20);
            this.labelNAgente.TabIndex = 8;
            this.labelNAgente.Text = "Nº Agente";
            // 
            // labelFechaLim
            // 
            this.labelFechaLim.AutoSize = true;
            this.labelFechaLim.Location = new System.Drawing.Point(22, 107);
            this.labelFechaLim.Name = "labelFechaLim";
            this.labelFechaLim.Size = new System.Drawing.Size(78, 20);
            this.labelFechaLim.TabIndex = 7;
            this.labelFechaLim.Text = "Fecha Lím.";
            // 
            // labelFechaExp
            // 
            this.labelFechaExp.AutoSize = true;
            this.labelFechaExp.Location = new System.Drawing.Point(22, 74);
            this.labelFechaExp.Name = "labelFechaExp";
            this.labelFechaExp.Size = new System.Drawing.Size(78, 20);
            this.labelFechaExp.TabIndex = 6;
            this.labelFechaExp.Text = "Fecha Exp.";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(22, 43);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(35, 20);
            this.labelDni.TabIndex = 5;
            this.labelDni.Text = "DNI";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(122, 310);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(94, 36);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(22, 310);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 36);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(344, 310);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(131, 36);
            this.buttonBorrar.TabIndex = 2;
            this.buttonBorrar.Text = "ELIMINAR";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(618, 310);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(131, 36);
            this.buttonCrear.TabIndex = 0;
            this.buttonCrear.Text = "CREAR";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // dgvMultas
            // 
            this.dgvMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultas.Location = new System.Drawing.Point(12, 431);
            this.dgvMultas.Name = "dgvMultas";
            this.dgvMultas.RowHeadersWidth = 51;
            this.dgvMultas.RowTemplate.Height = 29;
            this.dgvMultas.Size = new System.Drawing.Size(776, 449);
            this.dgvMultas.TabIndex = 1;
            this.dgvMultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMultas_CellClick);
            this.dgvMultas.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvMultas_RowStateChanged);
            // 
            // labelListadoMultas
            // 
            this.labelListadoMultas.AutoSize = true;
            this.labelListadoMultas.Location = new System.Drawing.Point(17, 395);
            this.labelListadoMultas.Name = "labelListadoMultas";
            this.labelListadoMultas.Size = new System.Drawing.Size(126, 20);
            this.labelListadoMultas.TabIndex = 2;
            this.labelListadoMultas.Text = "Listado de multas";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(122, 174);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(199, 27);
            this.textId.TabIndex = 18;
            // 
            // FormMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 892);
            this.Controls.Add(this.labelListadoMultas);
            this.Controls.Add(this.dgvMultas);
            this.Controls.Add(this.camposMulta);
            this.Name = "FormMultas";
            this.Text = "Multas";
            this.Load += new System.EventHandler(this.FormMultas_Load);
            this.camposMulta.ResumeLayout(false);
            this.camposMulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox camposMulta;
        private Button buttonCrear;
        private Button buttonGuardar;
        private Button buttonCancelar;
        private Button buttonBorrar;
        private DataGridView dgvMultas;
        private Label labelListadoMultas;
        private Label labelObservaciones;
        private Label labelImporte;
        private Label labelNAgente;
        private Label labelFechaLim;
        private Label labelFechaExp;
        private Label labelDni;
        private DateTimePicker dateTimePickerFechaLim;
        private DateTimePicker dateTimePickerFechaExp;
        private TextBox textObservaciones;
        private TextBox textImporte;
        private TextBox textNAgente;
        private TextBox textDni;
        private Button buttonEditar;
        private TextBox textId;
    }
}