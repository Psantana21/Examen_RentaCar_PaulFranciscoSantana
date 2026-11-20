namespace Examen_RentaCar_PaulFranciscoSantana
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkCorporativo = new System.Windows.Forms.CheckBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.Seguro = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtCompleto = new System.Windows.Forms.RadioButton();
            this.rbtBasico = new System.Windows.Forms.RadioButton();
            this.Entrega = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtDomicilio = new System.Windows.Forms.RadioButton();
            this.rbtSucursal = new System.Windows.Forms.RadioButton();
            this.chkGps = new System.Windows.Forms.CheckBox();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstAlquileres = new System.Windows.Forms.ListBox();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.Label();
            this.txtitbis = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.TextBox();
            this.lblitbis = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.Seguro.SuspendLayout();
            this.Entrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "RentaCar Express - Alquileres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salida:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vehículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarifa:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Días:";
            // 
            // chkCorporativo
            // 
            this.chkCorporativo.AutoSize = true;
            this.chkCorporativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkCorporativo.Location = new System.Drawing.Point(16, 86);
            this.chkCorporativo.Name = "chkCorporativo";
            this.chkCorporativo.Size = new System.Drawing.Size(154, 22);
            this.chkCorporativo.TabIndex = 7;
            this.chkCorporativo.Text = "Cliente Corporativo";
            this.chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(84, 55);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(286, 20);
            this.txtCliente.TabIndex = 8;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(84, 158);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(286, 20);
            this.txtVehiculo.TabIndex = 9;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(84, 197);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(286, 20);
            this.txtTarifa.TabIndex = 12;
            // 
            // Seguro
            // 
            this.Seguro.Controls.Add(this.label6);
            this.Seguro.Controls.Add(this.rbtCompleto);
            this.Seguro.Controls.Add(this.rbtBasico);
            this.Seguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Seguro.Location = new System.Drawing.Point(12, 267);
            this.Seguro.Name = "Seguro";
            this.Seguro.Size = new System.Drawing.Size(200, 100);
            this.Seguro.TabIndex = 20;
            this.Seguro.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Seguro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rbtCompleto
            // 
            this.rbtCompleto.AutoSize = true;
            this.rbtCompleto.Location = new System.Drawing.Point(6, 69);
            this.rbtCompleto.Name = "rbtCompleto";
            this.rbtCompleto.Size = new System.Drawing.Size(177, 21);
            this.rbtCompleto.TabIndex = 1;
            this.rbtCompleto.TabStop = true;
            this.rbtCompleto.Text = "Completo (+RD$300)";
            this.rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rbtBasico
            // 
            this.rbtBasico.AutoSize = true;
            this.rbtBasico.Checked = true;
            this.rbtBasico.Location = new System.Drawing.Point(6, 42);
            this.rbtBasico.Name = "rbtBasico";
            this.rbtBasico.Size = new System.Drawing.Size(74, 21);
            this.rbtBasico.TabIndex = 0;
            this.rbtBasico.TabStop = true;
            this.rbtBasico.Text = "Básico";
            this.rbtBasico.UseVisualStyleBackColor = true;
            // 
            // Entrega
            // 
            this.Entrega.Controls.Add(this.label7);
            this.Entrega.Controls.Add(this.rbtDomicilio);
            this.Entrega.Controls.Add(this.rbtSucursal);
            this.Entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Entrega.Location = new System.Drawing.Point(232, 267);
            this.Entrega.Name = "Entrega";
            this.Entrega.Size = new System.Drawing.Size(200, 100);
            this.Entrega.TabIndex = 21;
            this.Entrega.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Entrega";
            // 
            // rbtDomicilio
            // 
            this.rbtDomicilio.AutoSize = true;
            this.rbtDomicilio.Location = new System.Drawing.Point(6, 69);
            this.rbtDomicilio.Name = "rbtDomicilio";
            this.rbtDomicilio.Size = new System.Drawing.Size(175, 21);
            this.rbtDomicilio.TabIndex = 1;
            this.rbtDomicilio.TabStop = true;
            this.rbtDomicilio.Text = "Domicilio (+RD$500)";
            this.rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            this.rbtSucursal.AutoSize = true;
            this.rbtSucursal.Checked = true;
            this.rbtSucursal.Location = new System.Drawing.Point(6, 42);
            this.rbtSucursal.Name = "rbtSucursal";
            this.rbtSucursal.Size = new System.Drawing.Size(113, 21);
            this.rbtSucursal.TabIndex = 0;
            this.rbtSucursal.TabStop = true;
            this.rbtSucursal.Text = "En Sucursal";
            this.rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // chkGps
            // 
            this.chkGps.AutoSize = true;
            this.chkGps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGps.Location = new System.Drawing.Point(16, 387);
            this.chkGps.Name = "chkGps";
            this.chkGps.Size = new System.Drawing.Size(161, 17);
            this.chkGps.TabIndex = 22;
            this.chkGps.Text = "GPS (+RD$100 por día)";
            this.chkGps.UseVisualStyleBackColor = true;
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(84, 235);
            this.nudDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(129, 20);
            this.nudDias.TabIndex = 26;
            this.nudDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(448, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(291, 41);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar al alquiler";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Location = new System.Drawing.Point(16, 418);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(167, 41);
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "Calcular Total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(189, 418);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(167, 41);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Nuevo Alquiler";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(362, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 41);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstAlquileres
            // 
            this.lstAlquileres.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAlquileres.FormattingEnabled = true;
            this.lstAlquileres.ItemHeight = 14;
            this.lstAlquileres.Location = new System.Drawing.Point(393, 131);
            this.lstAlquileres.Name = "lstAlquileres";
            this.lstAlquileres.Size = new System.Drawing.Size(395, 158);
            this.lstAlquileres.TabIndex = 31;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(390, 115);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(387, 13);
            this.lblEncabezado.TabIndex = 32;
            this.lblEncabezado.Text = "Días                     Vehículo                        Tarifa               Tot" +
    "al";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AutoSize = true;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSubtotal.Location = new System.Drawing.Point(494, 305);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(52, 15);
            this.txtSubtotal.TabIndex = 33;
            this.txtSubtotal.Text = "Subtotal";
            // 
            // txtDescuento
            // 
            this.txtDescuento.AutoSize = true;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDescuento.Location = new System.Drawing.Point(494, 329);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(66, 15);
            this.txtDescuento.TabIndex = 34;
            this.txtDescuento.Text = "Descuento";
            this.txtDescuento.Click += new System.EventHandler(this.lblDescuento_Click);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.AutoSize = true;
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDomicilio.Location = new System.Drawing.Point(494, 355);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(59, 15);
            this.txtDomicilio.TabIndex = 35;
            this.txtDomicilio.Text = "Domicilio";
            // 
            // txtitbis
            // 
            this.txtitbis.AutoSize = true;
            this.txtitbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtitbis.Location = new System.Drawing.Point(494, 382);
            this.txtitbis.Name = "txtitbis";
            this.txtitbis.Size = new System.Drawing.Size(75, 15);
            this.txtitbis.TabIndex = 36;
            this.txtitbis.Text = "ITBIS (18 %)";
            // 
            // textTotal
            // 
            this.textTotal.AutoSize = true;
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.textTotal.Location = new System.Drawing.Point(482, 412);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(110, 15);
            this.textTotal.TabIndex = 37;
            this.textTotal.Text = "TOTAL A PAGAR";
            this.textTotal.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(652, 305);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 20);
            this.lblSubtotal.TabIndex = 38;
            // 
            // lblDescuento
            // 
            this.lblDescuento.Location = new System.Drawing.Point(652, 329);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(100, 20);
            this.lblDescuento.TabIndex = 39;
            // 
            // lblitbis
            // 
            this.lblitbis.Location = new System.Drawing.Point(652, 377);
            this.lblitbis.Name = "lblitbis";
            this.lblitbis.Size = new System.Drawing.Size(100, 20);
            this.lblitbis.TabIndex = 41;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Location = new System.Drawing.Point(652, 353);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(100, 20);
            this.lblDomicilio.TabIndex = 40;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(652, 409);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 42;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dtpSalida.Location = new System.Drawing.Point(84, 119);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(286, 23);
            this.dtpSalida.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblitbis);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.txtitbis);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.lstAlquileres);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.chkGps);
            this.Controls.Add(this.Entrega);
            this.Controls.Add(this.Seguro);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.chkCorporativo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "RentaCar Express - Alquileres";
            this.Seguro.ResumeLayout(false);
            this.Seguro.PerformLayout();
            this.Entrega.ResumeLayout(false);
            this.Entrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCorporativo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.GroupBox Seguro;
        private System.Windows.Forms.RadioButton rbtCompleto;
        private System.Windows.Forms.RadioButton rbtBasico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Entrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtDomicilio;
        private System.Windows.Forms.RadioButton rbtSucursal;
        private System.Windows.Forms.CheckBox chkGps;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstAlquileres;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label txtSubtotal;
        private System.Windows.Forms.Label txtDescuento;
        private System.Windows.Forms.Label txtDomicilio;
        private System.Windows.Forms.Label txtitbis;
        private System.Windows.Forms.Label textTotal;
        private System.Windows.Forms.TextBox lblSubtotal;
        private System.Windows.Forms.TextBox lblDescuento;
        private System.Windows.Forms.TextBox lblitbis;
        private System.Windows.Forms.TextBox lblDomicilio;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.DateTimePicker dtpSalida;
    }
}

