namespace ProgramaEjercicios.Forms
{
    partial class FormCoordenadas
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CalcularLimpiar = new System.Windows.Forms.Button();
            this.lblPuntoY = new System.Windows.Forms.Label();
            this.lblPuntoX = new System.Windows.Forms.Label();
            this.inputPuntoY = new System.Windows.Forms.TextBox();
            this.inputPuntoX = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblResCuadrante = new System.Windows.Forms.Label();
            this.lblResDistancia = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblCuadrante = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 116);
            this.label4.TabIndex = 19;
            this.label4.Text = "cuadrante cuatro";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 116);
            this.label3.TabIndex = 18;
            this.label3.Text = "cuadrante tres";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 116);
            this.label2.TabIndex = 17;
            this.label2.Text = "cuadrante dos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 116);
            this.label1.TabIndex = 16;
            this.label1.Text = "cuadrante uno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(340, 402);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 239);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.CalcularLimpiar);
            this.panel2.Controls.Add(this.lblPuntoY);
            this.panel2.Controls.Add(this.lblPuntoX);
            this.panel2.Controls.Add(this.inputPuntoY);
            this.panel2.Controls.Add(this.inputPuntoX);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(122, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 185);
            this.panel2.TabIndex = 21;
            // 
            // CalcularLimpiar
            // 
            this.CalcularLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalcularLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.CalcularLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.CalcularLimpiar.Location = new System.Drawing.Point(113, 110);
            this.CalcularLimpiar.Name = "CalcularLimpiar";
            this.CalcularLimpiar.Size = new System.Drawing.Size(119, 34);
            this.CalcularLimpiar.TabIndex = 27;
            this.CalcularLimpiar.Text = "Calcular";
            this.CalcularLimpiar.UseVisualStyleBackColor = false;
            this.CalcularLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblPuntoY
            // 
            this.lblPuntoY.AutoSize = true;
            this.lblPuntoY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoY.Location = new System.Drawing.Point(39, 63);
            this.lblPuntoY.Name = "lblPuntoY";
            this.lblPuntoY.Size = new System.Drawing.Size(124, 19);
            this.lblPuntoY.TabIndex = 7;
            this.lblPuntoY.Text = "Coordenada Y";
            // 
            // lblPuntoX
            // 
            this.lblPuntoX.AutoSize = true;
            this.lblPuntoX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoX.Location = new System.Drawing.Point(39, 22);
            this.lblPuntoX.Name = "lblPuntoX";
            this.lblPuntoX.Size = new System.Drawing.Size(125, 19);
            this.lblPuntoX.TabIndex = 6;
            this.lblPuntoX.Text = "Coordenada X";
            // 
            // inputPuntoY
            // 
            this.inputPuntoY.Location = new System.Drawing.Point(195, 63);
            this.inputPuntoY.Name = "inputPuntoY";
            this.inputPuntoY.Size = new System.Drawing.Size(113, 27);
            this.inputPuntoY.TabIndex = 2;
            this.inputPuntoY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPuntoY_KeyPress);
            // 
            // inputPuntoX
            // 
            this.inputPuntoX.Location = new System.Drawing.Point(195, 20);
            this.inputPuntoX.Name = "inputPuntoX";
            this.inputPuntoX.Size = new System.Drawing.Size(113, 27);
            this.inputPuntoX.TabIndex = 0;
            this.inputPuntoX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPuntoX_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblResCuadrante);
            this.panel3.Controls.Add(this.lblResDistancia);
            this.panel3.Controls.Add(this.lblDistancia);
            this.panel3.Controls.Add(this.lblCuadrante);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(481, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 185);
            this.panel3.TabIndex = 22;
            // 
            // lblResCuadrante
            // 
            this.lblResCuadrante.AutoSize = true;
            this.lblResCuadrante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResCuadrante.Location = new System.Drawing.Point(182, 35);
            this.lblResCuadrante.Name = "lblResCuadrante";
            this.lblResCuadrante.Size = new System.Drawing.Size(0, 21);
            this.lblResCuadrante.TabIndex = 13;
            // 
            // lblResDistancia
            // 
            this.lblResDistancia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResDistancia.Location = new System.Drawing.Point(187, 101);
            this.lblResDistancia.Name = "lblResDistancia";
            this.lblResDistancia.Size = new System.Drawing.Size(103, 31);
            this.lblResDistancia.TabIndex = 12;
            this.lblResDistancia.Click += new System.EventHandler(this.lblResDistancia_Click);
            // 
            // lblDistancia
            // 
            this.lblDistancia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(60, 82);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(122, 51);
            this.lblDistancia.TabIndex = 11;
            this.lblDistancia.Text = "Distancia al origen";
            this.lblDistancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCuadrante
            // 
            this.lblCuadrante.AutoSize = true;
            this.lblCuadrante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuadrante.Location = new System.Drawing.Point(60, 36);
            this.lblCuadrante.Name = "lblCuadrante";
            this.lblCuadrante.Size = new System.Drawing.Size(97, 19);
            this.lblCuadrante.TabIndex = 10;
            this.lblCuadrante.Text = "Cuadrante:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgramaEjercicios.Properties.Resources.ejes_de_coordenadas;
            this.pictureBox1.Location = new System.Drawing.Point(122, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FormCoordenadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(975, 684);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCoordenadas";
            this.Text = "Coordenadas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPuntoY;
        private System.Windows.Forms.Label lblPuntoX;
        private System.Windows.Forms.TextBox inputPuntoY;
        private System.Windows.Forms.TextBox inputPuntoX;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblResCuadrante;
        private System.Windows.Forms.Label lblResDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblCuadrante;
        private System.Windows.Forms.Button CalcularLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}