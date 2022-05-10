namespace ProgramaEjercicios.Forms
{
    partial class FormCompraInteractiva
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputCodigoCliente = new System.Windows.Forms.TextBox();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.inputCedula = new System.Windows.Forms.TextBox();
            this.inputDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputValorUnitario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nuevaCompra = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.LabelCedula = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAgregarCarrito = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelInfoPago = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(842, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 684);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ProgramaEjercicios.Properties.Resources.fruit_shop;
            this.pictureBox1.Location = new System.Drawing.Point(9, 283);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Cliente:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Còdigo Cliente:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direcciòn:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "C.I:";
            // 
            // inputCodigoCliente
            // 
            this.inputCodigoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCodigoCliente.Location = new System.Drawing.Point(171, 55);
            this.inputCodigoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputCodigoCliente.Name = "inputCodigoCliente";
            this.inputCodigoCliente.Size = new System.Drawing.Size(175, 27);
            this.inputCodigoCliente.TabIndex = 6;
            // 
            // inputNombre
            // 
            this.inputNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNombre.Location = new System.Drawing.Point(181, 90);
            this.inputNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(175, 27);
            this.inputNombre.TabIndex = 7;
            // 
            // inputCedula
            // 
            this.inputCedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCedula.Location = new System.Drawing.Point(481, 55);
            this.inputCedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputCedula.Name = "inputCedula";
            this.inputCedula.Size = new System.Drawing.Size(152, 27);
            this.inputCedula.TabIndex = 8;
            // 
            // inputDireccion
            // 
            this.inputDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDireccion.Location = new System.Drawing.Point(481, 90);
            this.inputDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputDireccion.Name = "inputDireccion";
            this.inputDireccion.Size = new System.Drawing.Size(152, 27);
            this.inputDireccion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(802, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Producto:";
            // 
            // listProducto
            // 
            this.listProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProducto.FormattingEnabled = true;
            this.listProducto.Items.AddRange(new object[] {
            "Leche",
            "Yogurt",
            "Queso",
            "Nata",
            "Mantequilla",
            "Salchicha",
            "Pollo",
            "Carne",
            "Aceite",
            "Tomate",
            "Lechuga",
            "Manzana",
            "Uva"});
            this.listProducto.Location = new System.Drawing.Point(147, 161);
            this.listProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listProducto.Name = "listProducto";
            this.listProducto.Size = new System.Drawing.Size(136, 28);
            this.listProducto.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad:";
            // 
            // inputCantidad
            // 
            this.inputCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCantidad.Location = new System.Drawing.Point(425, 159);
            this.inputCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputCantidad.Name = "inputCantidad";
            this.inputCantidad.Size = new System.Drawing.Size(91, 27);
            this.inputCantidad.TabIndex = 14;
            this.inputCantidad.TextChanged += new System.EventHandler(this.inputCantidad_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(610, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Precio Unitario:";
            // 
            // inputValorUnitario
            // 
            this.inputValorUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValorUnitario.Location = new System.Drawing.Point(744, 158);
            this.inputValorUnitario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputValorUnitario.Name = "inputValorUnitario";
            this.inputValorUnitario.Size = new System.Drawing.Size(84, 27);
            this.inputValorUnitario.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCliente,
            this.producto,
            this.cantidad,
            this.precioUnitario});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(445, 303);
            this.dataGridView1.TabIndex = 17;
            // 
            // codCliente
            // 
            this.codCliente.HeaderText = "Codigo cliente";
            this.codCliente.Name = "codCliente";
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precioUnitario
            // 
            this.precioUnitario.HeaderText = "Precio unitario";
            this.precioUnitario.Name = "precioUnitario";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(61, 352);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 303);
            this.panel2.TabIndex = 18;
            // 
            // nuevaCompra
            // 
            this.nuevaCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nuevaCompra.AutoSize = true;
            this.nuevaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.nuevaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nuevaCompra.Location = new System.Drawing.Point(647, 66);
            this.nuevaCompra.Name = "nuevaCompra";
            this.nuevaCompra.Size = new System.Drawing.Size(174, 40);
            this.nuevaCompra.TabIndex = 27;
            this.nuevaCompra.Text = "Abrir nueva compra";
            this.nuevaCompra.UseVisualStyleBackColor = false;
            this.nuevaCompra.Click += new System.EventHandler(this.nuevaCompra_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 243);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Bienvenido:";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(58, 272);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(149, 29);
            this.labelNombre.TabIndex = 29;
            this.labelNombre.Text = "labelnombre";
            // 
            // LabelCedula
            // 
            this.LabelCedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelCedula.AutoSize = true;
            this.LabelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCedula.Location = new System.Drawing.Point(58, 305);
            this.LabelCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCedula.Name = "LabelCedula";
            this.LabelCedula.Size = new System.Drawing.Size(143, 29);
            this.LabelCedula.TabIndex = 30;
            this.LabelCedula.Text = "labelCedula";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(198, 299);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 29);
            this.label12.TabIndex = 31;
            // 
            // buttonAgregarCarrito
            // 
            this.buttonAgregarCarrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAgregarCarrito.AutoSize = true;
            this.buttonAgregarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.buttonAgregarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buttonAgregarCarrito.Location = new System.Drawing.Point(365, 207);
            this.buttonAgregarCarrito.Name = "buttonAgregarCarrito";
            this.buttonAgregarCarrito.Size = new System.Drawing.Size(158, 31);
            this.buttonAgregarCarrito.TabIndex = 32;
            this.buttonAgregarCarrito.Text = "Agregar el carrito";
            this.buttonAgregarCarrito.UseVisualStyleBackColor = false;
            this.buttonAgregarCarrito.Click += new System.EventHandler(this.buttonAgregarCarrito_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(621, 392);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(121, 29);
            this.labelTotal.TabIndex = 34;
            this.labelTotal.Text = "labelTotal";
            // 
            // labelInfoPago
            // 
            this.labelInfoPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfoPago.AutoSize = true;
            this.labelInfoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoPago.Location = new System.Drawing.Point(619, 362);
            this.labelInfoPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoPago.Name = "labelInfoPago";
            this.labelInfoPago.Size = new System.Drawing.Size(124, 24);
            this.labelInfoPago.TabIndex = 33;
            this.labelInfoPago.Text = "Total a pagar:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.labelTotal);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.LabelCedula);
            this.panel3.Controls.Add(this.buttonAgregarCarrito);
            this.panel3.Controls.Add(this.labelNombre);
            this.panel3.Controls.Add(this.labelInfoPago);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.inputCodigoCliente);
            this.panel3.Controls.Add(this.inputNombre);
            this.panel3.Controls.Add(this.nuevaCompra);
            this.panel3.Controls.Add(this.inputCedula);
            this.panel3.Controls.Add(this.inputDireccion);
            this.panel3.Controls.Add(this.inputValorUnitario);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.inputCantidad);
            this.panel3.Controls.Add(this.listProducto);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 684);
            this.panel3.TabIndex = 35;
            // 
            // FormCompraInteractiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(975, 684);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCompraInteractiva";
            this.Text = "Compra Interactiva";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputCodigoCliente;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.TextBox inputCedula;
        private System.Windows.Forms.TextBox inputDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox listProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputValorUnitario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.Button nuevaCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label LabelCedula;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonAgregarCarrito;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelInfoPago;
        private System.Windows.Forms.Panel panel3;
    }
}