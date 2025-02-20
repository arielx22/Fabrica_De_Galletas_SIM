namespace Fábrica_De_Galletas_SIM
{
    partial class simulacionFabricaGalletas
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
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndLlegadaCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoEntreLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoPreparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finPreparacionDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaIncioAbastecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entreHoraFinAbastecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinAbastecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndTamañoCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camionEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamañoCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silo1Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silo1Almacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silo2Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silo2Almacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silo3Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silo3Almacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silo4Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silo4Almacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCamiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSimular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxHasta = new System.Windows.Forms.TextBox();
            this.txtBoxDesde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFilas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxTamañoMaximoSilo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSilo4Cantidad = new System.Windows.Forms.TextBox();
            this.txtBoxSilo3Cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSilo2Cantidad = new System.Windows.Forms.TextBox();
            this.txtBoxSilo1Cantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPromedioCamionesDias = new System.Windows.Forms.Label();
            this.lblCantidadCamiones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSimulacion
            // 
            this.dgvSimulacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fila,
            this.evento,
            this.tiempo,
            this.rndLlegadaCamion,
            this.tiempoEntreLlegada,
            this.proximoCamion,
            this.tiempoPreparacion,
            this.finPreparacionDescarga,
            this.tasaDescarga,
            this.tiempoDescarga,
            this.finDescarga,
            this.horaIncioAbastecimiento,
            this.entreHoraFinAbastecimiento,
            this.horaFinAbastecimiento,
            this.rndTamañoCamion,
            this.colaCamion,
            this.idCamion,
            this.camionEstado,
            this.tamañoCamion,
            this.cantidadActual,
            this.silo1Estado,
            this.silo1Almacenamiento,
            this.silo2Estado,
            this.silo2Almacenamiento,
            this.silo3Estado,
            this.silo3Almacenamiento,
            this.silo4Estado,
            this.silo4Almacenamiento,
            this.dias,
            this.cantidadCamiones,
            this.promedioCamion});
            this.dgvSimulacion.Location = new System.Drawing.Point(12, 108);
            this.dgvSimulacion.Name = "dgvSimulacion";
            this.dgvSimulacion.ReadOnly = true;
            this.dgvSimulacion.Size = new System.Drawing.Size(1346, 430);
            this.dgvSimulacion.TabIndex = 9;
            // 
            // fila
            // 
            this.fila.HeaderText = "Fila";
            this.fila.Name = "fila";
            this.fila.ReadOnly = true;
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "Tiempo (Hora)";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            // 
            // rndLlegadaCamion
            // 
            this.rndLlegadaCamion.HeaderText = "RND Llegada Camion";
            this.rndLlegadaCamion.Name = "rndLlegadaCamion";
            this.rndLlegadaCamion.ReadOnly = true;
            // 
            // tiempoEntreLlegada
            // 
            this.tiempoEntreLlegada.HeaderText = "Tiempo Entre Llegada";
            this.tiempoEntreLlegada.Name = "tiempoEntreLlegada";
            this.tiempoEntreLlegada.ReadOnly = true;
            // 
            // proximoCamion
            // 
            this.proximoCamion.HeaderText = "Proximo Camión";
            this.proximoCamion.Name = "proximoCamion";
            this.proximoCamion.ReadOnly = true;
            // 
            // tiempoPreparacion
            // 
            this.tiempoPreparacion.HeaderText = "Tiempo Preparacion Descarga";
            this.tiempoPreparacion.Name = "tiempoPreparacion";
            this.tiempoPreparacion.ReadOnly = true;
            // 
            // finPreparacionDescarga
            // 
            this.finPreparacionDescarga.HeaderText = "Fin Preparacion Descarga";
            this.finPreparacionDescarga.Name = "finPreparacionDescarga";
            this.finPreparacionDescarga.ReadOnly = true;
            // 
            // tasaDescarga
            // 
            this.tasaDescarga.HeaderText = "Tasa de Descarga";
            this.tasaDescarga.Name = "tasaDescarga";
            this.tasaDescarga.ReadOnly = true;
            // 
            // tiempoDescarga
            // 
            this.tiempoDescarga.HeaderText = "Tiempo Descarga";
            this.tiempoDescarga.Name = "tiempoDescarga";
            this.tiempoDescarga.ReadOnly = true;
            // 
            // finDescarga
            // 
            this.finDescarga.HeaderText = "Fin Descarga";
            this.finDescarga.Name = "finDescarga";
            this.finDescarga.ReadOnly = true;
            // 
            // horaIncioAbastecimiento
            // 
            this.horaIncioAbastecimiento.HeaderText = "Hora Incio Abastecimiento";
            this.horaIncioAbastecimiento.Name = "horaIncioAbastecimiento";
            this.horaIncioAbastecimiento.ReadOnly = true;
            // 
            // entreHoraFinAbastecimiento
            // 
            this.entreHoraFinAbastecimiento.HeaderText = "Tiempo entre Hora Fin Abastecimiento";
            this.entreHoraFinAbastecimiento.Name = "entreHoraFinAbastecimiento";
            this.entreHoraFinAbastecimiento.ReadOnly = true;
            // 
            // horaFinAbastecimiento
            // 
            this.horaFinAbastecimiento.HeaderText = "Hora fin Abastecimiento";
            this.horaFinAbastecimiento.Name = "horaFinAbastecimiento";
            this.horaFinAbastecimiento.ReadOnly = true;
            // 
            // rndTamañoCamion
            // 
            this.rndTamañoCamion.HeaderText = "RND Tamaño Camión";
            this.rndTamañoCamion.Name = "rndTamañoCamion";
            this.rndTamañoCamion.ReadOnly = true;
            // 
            // colaCamion
            // 
            this.colaCamion.HeaderText = "Cola Camion";
            this.colaCamion.Name = "colaCamion";
            this.colaCamion.ReadOnly = true;
            // 
            // idCamion
            // 
            this.idCamion.HeaderText = "Id Camion";
            this.idCamion.Name = "idCamion";
            this.idCamion.ReadOnly = true;
            // 
            // camionEstado
            // 
            this.camionEstado.HeaderText = "Camión Estado";
            this.camionEstado.Name = "camionEstado";
            this.camionEstado.ReadOnly = true;
            // 
            // tamañoCamion
            // 
            this.tamañoCamion.HeaderText = "Tamaño Camión (Tn)";
            this.tamañoCamion.Name = "tamañoCamion";
            this.tamañoCamion.ReadOnly = true;
            // 
            // cantidadActual
            // 
            this.cantidadActual.HeaderText = "Cantidad Actual (Tn)";
            this.cantidadActual.Name = "cantidadActual";
            this.cantidadActual.ReadOnly = true;
            // 
            // silo1Estado
            // 
            this.silo1Estado.HeaderText = "Silo 1 Estado";
            this.silo1Estado.Name = "silo1Estado";
            this.silo1Estado.ReadOnly = true;
            // 
            // silo1Almacenamiento
            // 
            this.silo1Almacenamiento.HeaderText = "Silo 1 Almacemiento(Tn)";
            this.silo1Almacenamiento.Name = "silo1Almacenamiento";
            this.silo1Almacenamiento.ReadOnly = true;
            // 
            // silo2Estado
            // 
            this.silo2Estado.HeaderText = "Silo 2 Estado";
            this.silo2Estado.Name = "silo2Estado";
            this.silo2Estado.ReadOnly = true;
            // 
            // silo2Almacenamiento
            // 
            this.silo2Almacenamiento.HeaderText = "Silo 2 Almacemiento(Tn)";
            this.silo2Almacenamiento.Name = "silo2Almacenamiento";
            this.silo2Almacenamiento.ReadOnly = true;
            // 
            // silo3Estado
            // 
            this.silo3Estado.HeaderText = "Silo 3 Estado";
            this.silo3Estado.Name = "silo3Estado";
            this.silo3Estado.ReadOnly = true;
            // 
            // silo3Almacenamiento
            // 
            this.silo3Almacenamiento.HeaderText = "Silo 3 Almacemiento(Tn)";
            this.silo3Almacenamiento.Name = "silo3Almacenamiento";
            this.silo3Almacenamiento.ReadOnly = true;
            // 
            // silo4Estado
            // 
            this.silo4Estado.HeaderText = "Silo 4 Estado";
            this.silo4Estado.Name = "silo4Estado";
            this.silo4Estado.ReadOnly = true;
            // 
            // silo4Almacenamiento
            // 
            this.silo4Almacenamiento.HeaderText = "Silo 4 Almacemiento(Tn)";
            this.silo4Almacenamiento.Name = "silo4Almacenamiento";
            this.silo4Almacenamiento.ReadOnly = true;
            // 
            // dias
            // 
            this.dias.HeaderText = "Dias";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            // 
            // cantidadCamiones
            // 
            this.cantidadCamiones.HeaderText = "Cantidad Camiones";
            this.cantidadCamiones.Name = "cantidadCamiones";
            this.cantidadCamiones.ReadOnly = true;
            // 
            // promedioCamion
            // 
            this.promedioCamion.HeaderText = "Promedio Camiones (Dias)";
            this.promedioCamion.Name = "promedioCamion";
            this.promedioCamion.ReadOnly = true;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(909, 79);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 11;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxHasta);
            this.groupBox1.Controls.Add(this.txtBoxDesde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxFilas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 90);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filas";
            // 
            // txtBoxHasta
            // 
            this.txtBoxHasta.Location = new System.Drawing.Point(223, 55);
            this.txtBoxHasta.Name = "txtBoxHasta";
            this.txtBoxHasta.Size = new System.Drawing.Size(77, 20);
            this.txtBoxHasta.TabIndex = 9;
            this.txtBoxHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtBoxDesde
            // 
            this.txtBoxDesde.Location = new System.Drawing.Point(79, 55);
            this.txtBoxDesde.Name = "txtBoxDesde";
            this.txtBoxDesde.Size = new System.Drawing.Size(77, 20);
            this.txtBoxDesde.TabIndex = 8;
            this.txtBoxDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desde:";
            // 
            // txtBoxFilas
            // 
            this.txtBoxFilas.Location = new System.Drawing.Point(79, 23);
            this.txtBoxFilas.Name = "txtBoxFilas";
            this.txtBoxFilas.Size = new System.Drawing.Size(77, 20);
            this.txtBoxFilas.TabIndex = 3;
            this.txtBoxFilas.Text = "50";
            this.txtBoxFilas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filas*:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxTamañoMaximoSilo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxSilo4Cantidad);
            this.groupBox2.Controls.Add(this.txtBoxSilo3Cantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBoxSilo2Cantidad);
            this.groupBox2.Controls.Add(this.txtBoxSilo1Cantidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(333, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Silos";
            // 
            // txtBoxTamañoMaximoSilo
            // 
            this.txtBoxTamañoMaximoSilo.Location = new System.Drawing.Point(475, 59);
            this.txtBoxTamañoMaximoSilo.Name = "txtBoxTamañoMaximoSilo";
            this.txtBoxTamañoMaximoSilo.Size = new System.Drawing.Size(77, 20);
            this.txtBoxTamañoMaximoSilo.TabIndex = 16;
            this.txtBoxTamañoMaximoSilo.Text = "23";
            this.txtBoxTamañoMaximoSilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPressSilos);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tamaño Maximo*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Silo 4 Cantidad*:";
            // 
            // txtBoxSilo4Cantidad
            // 
            this.txtBoxSilo4Cantidad.Location = new System.Drawing.Point(299, 59);
            this.txtBoxSilo4Cantidad.Name = "txtBoxSilo4Cantidad";
            this.txtBoxSilo4Cantidad.Size = new System.Drawing.Size(77, 20);
            this.txtBoxSilo4Cantidad.TabIndex = 13;
            this.txtBoxSilo4Cantidad.Text = "0";
            this.txtBoxSilo4Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPressSilos);
            // 
            // txtBoxSilo3Cantidad
            // 
            this.txtBoxSilo3Cantidad.Location = new System.Drawing.Point(299, 27);
            this.txtBoxSilo3Cantidad.Name = "txtBoxSilo3Cantidad";
            this.txtBoxSilo3Cantidad.Size = new System.Drawing.Size(77, 20);
            this.txtBoxSilo3Cantidad.TabIndex = 12;
            this.txtBoxSilo3Cantidad.Text = "0";
            this.txtBoxSilo3Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPressSilos);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Silo 3 Cantidad*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Silo 2 Cantidad*:";
            // 
            // txtBoxSilo2Cantidad
            // 
            this.txtBoxSilo2Cantidad.Location = new System.Drawing.Point(129, 59);
            this.txtBoxSilo2Cantidad.Name = "txtBoxSilo2Cantidad";
            this.txtBoxSilo2Cantidad.Size = new System.Drawing.Size(77, 20);
            this.txtBoxSilo2Cantidad.TabIndex = 8;
            this.txtBoxSilo2Cantidad.Text = "0";
            this.txtBoxSilo2Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPressSilos);
            // 
            // txtBoxSilo1Cantidad
            // 
            this.txtBoxSilo1Cantidad.Location = new System.Drawing.Point(129, 27);
            this.txtBoxSilo1Cantidad.Name = "txtBoxSilo1Cantidad";
            this.txtBoxSilo1Cantidad.Size = new System.Drawing.Size(77, 20);
            this.txtBoxSilo1Cantidad.TabIndex = 3;
            this.txtBoxSilo1Cantidad.Text = "0";
            this.txtBoxSilo1Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPressSilos);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Silo 1 Cantidad*:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDias);
            this.groupBox3.Controls.Add(this.lblPromedioCamionesDias);
            this.groupBox3.Controls.Add(this.lblCantidadCamiones);
            this.groupBox3.Location = new System.Drawing.Point(990, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 90);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(231, 30);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(31, 13);
            this.lblDias.TabIndex = 7;
            this.lblDias.Text = "Dias:";
            // 
            // lblPromedioCamionesDias
            // 
            this.lblPromedioCamionesDias.AutoSize = true;
            this.lblPromedioCamionesDias.Location = new System.Drawing.Point(15, 62);
            this.lblPromedioCamionesDias.Name = "lblPromedioCamionesDias";
            this.lblPromedioCamionesDias.Size = new System.Drawing.Size(157, 13);
            this.lblPromedioCamionesDias.TabIndex = 6;
            this.lblPromedioCamionesDias.Text = "Promedio de Camiones en Dias:";
            // 
            // lblCantidadCamiones
            // 
            this.lblCantidadCamiones.AutoSize = true;
            this.lblCantidadCamiones.Location = new System.Drawing.Point(15, 30);
            this.lblCantidadCamiones.Name = "lblCantidadCamiones";
            this.lblCantidadCamiones.Size = new System.Drawing.Size(101, 13);
            this.lblCantidadCamiones.TabIndex = 0;
            this.lblCantidadCamiones.Text = "Cantidad Camiones:";
            // 
            // simulacionFabricaGalletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 550);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSimulacion);
            this.Name = "simulacionFabricaGalletas";
            this.Text = "Fábrica de Galletas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSimulacion;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxHasta;
        private System.Windows.Forms.TextBox txtBoxDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFilas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxSilo2Cantidad;
        private System.Windows.Forms.TextBox txtBoxSilo1Cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxSilo4Cantidad;
        private System.Windows.Forms.TextBox txtBoxSilo3Cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxTamañoMaximoSilo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPromedioCamionesDias;
        private System.Windows.Forms.Label lblCantidadCamiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndLlegadaCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoEntreLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoPreparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn finPreparacionDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn finDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaIncioAbastecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn entreHoraFinAbastecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinAbastecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndTamañoCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn camionEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamañoCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn silo1Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn silo1Almacenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn silo2Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn silo2Almacenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn silo3Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn silo3Almacenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn silo4Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn silo4Almacenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCamiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedioCamion;
    }
}

